using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;

public static class RebarHelper
{
    public static void DrawColumnRebar(Document doc, UIDocument uidoc, double coverThickness, int quantity)
    {
        Reference reference = uidoc.Selection.PickObject(ObjectType.Element, "Chọn cột bê tông để đặt thép");
        Element column = doc.GetElement(reference);
        BoundingBoxXYZ bbox = column.get_BoundingBox(null);

        XYZ min = bbox.Min;
        XYZ max = bbox.Max;

        // Lấy BarType thép và Shape thép đai (stirrup)
        RebarBarType barType = new FilteredElementCollector(doc)
            .OfClass(typeof(RebarBarType))
            .Cast<RebarBarType>()
            .FirstOrDefault();

        RebarShape shapeStirrup = new FilteredElementCollector(doc)
            .OfClass(typeof(RebarShape))
            .Cast<RebarShape>()
            .FirstOrDefault(s => s.Name.ToLower().Contains("stirrup"));

        if (barType == null || shapeStirrup == null)
            throw new InvalidOperationException("Không tìm thấy BarType hoặc RebarShape (stirrup).");

        using (Transaction tx = new Transaction(doc, "Vẽ Thép Cột"))
        {
            tx.Start();

            // Tạo danh sách điểm đáy cho thanh thép dọc, phân bố đều theo trục X
            List<XYZ> points = new List<XYZ>();

            if (quantity == 1)
            {
                // Nếu chỉ 1 thanh, đặt ở giữa
                double midX = (min.X + max.X) / 2.0;
                double y = min.Y + coverThickness;
                points.Add(new XYZ(midX, y, min.Z));
            }
            else if (quantity > 1)
            {
                double startX = min.X + coverThickness;
                double endX = max.X - coverThickness;
                double y = min.Y + coverThickness;

                for (int i = 0; i < quantity; i++)
                {
                    double t = (double)i / (quantity - 1);
                    double x = startX + t * (endX - startX);
                    points.Add(new XYZ(x, y, min.Z));
                }
            }
            else
            {
                tx.RollBack();
                throw new ArgumentException("Số lượng thanh thép phải lớn hơn 0.");
            }

            // Vẽ thép dọc từ đáy lên đỉnh cột
            foreach (XYZ pt in points)
            {
                Curve mainBar = Line.CreateBound(pt, new XYZ(pt.X, pt.Y, max.Z));
                Rebar.CreateFromCurves(doc, RebarStyle.Standard, barType, null, null, column, null,
                    new List<Curve> { mainBar }, RebarHookOrientation.Left, RebarHookOrientation.Left, true, false);
            }

            // Vẽ thép đai (stirrup) với spacing 150mm
            double stirrupSpacing = UnitUtils.ConvertToInternalUnits(150, UnitTypeId.Millimeters);
            int stirrupCount = (int)Math.Floor((max.Z - min.Z) / stirrupSpacing);

            for (int i = 0; i <= stirrupCount; i++)
            {
                double z = min.Z + i * stirrupSpacing;

                XYZ p1 = new XYZ(min.X + coverThickness, min.Y + coverThickness, z);
                XYZ p2 = new XYZ(max.X - coverThickness, min.Y + coverThickness, z);
                XYZ p3 = new XYZ(max.X - coverThickness, max.Y - coverThickness, z);
                XYZ p4 = new XYZ(min.X + coverThickness, max.Y - coverThickness, z);

                List<Curve> loop = new List<Curve>()
                {
                    Line.CreateBound(p1, p2),
                    Line.CreateBound(p2, p3),
                    Line.CreateBound(p3, p4),
                    Line.CreateBound(p4, p1)
                };

                Rebar.CreateFromCurves(doc, RebarStyle.Standard, barType, null, null, column, null,
                    loop, RebarHookOrientation.Left, RebarHookOrientation.Left, true, false);
            }

            tx.Commit();
        }
    }
}

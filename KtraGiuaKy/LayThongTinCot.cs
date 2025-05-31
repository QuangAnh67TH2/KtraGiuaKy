using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;

using System.Windows.Forms;

namespace KtraGiuaKy
{
    public partial class LayThongTinCot : System.Windows.Forms.Form
    {
        ExternalCommandData commandData;
        public LayThongTinCot(ExternalCommandData commandData)
        {
            InitializeComponent();
            this.commandData = commandData;
        }       

        private void btnQuet_Click(object sender, EventArgs e)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            FilteredElementCollector collector = new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_StructuralColumns)
                .WhereElementIsNotElementType();

            List<ThongTinCot> columns = new List<ThongTinCot>();

            foreach (Element elem in collector)
            {
                if (!(elem is FamilyInstance fi)) continue;

                // Nếu là cột dựng theo LocationPoint
                LocationPoint loc = fi.Location as LocationPoint;
                if (loc == null) continue;

                // Lấy các thông số b, h (chiều ngang và chiều dọc mặt cắt)
                double bb = GetParamValue(elem, "b"); 
                double hh = GetParamValue(elem, "h"); 

               

                // Lấy chiều dài cột theo phương Z
                double LL = GetColumnHeight(elem);

                string position = GetColumnPosition(elem, doc);

                columns.Add(new ThongTinCot
                {
                    Position = position,
                    Height = hh,
                    Width = bb,
                    Depth = LL,
                    ElementId = elem.Id
                });
            }

            cmbCPosition.DataSource = columns;

        }

        private void comboBoxColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongTinCot selected = cmbCPosition.SelectedItem as ThongTinCot;
            if (selected != null)
            {
                txth.Text = (selected.Height * 304.8).ToString("F2"); // feet to mm
                txtb.Text = (selected.Width * 304.8).ToString("F2");
                txtL.Text = (selected.Depth * 304.8).ToString("F2");
            }
        }

        private double GetParamValue(Element elem, string paramName)
        {
            // Tìm trong instance trước
            Parameter param = elem.LookupParameter(paramName);
            if (param != null && param.StorageType == StorageType.Double)
                return param.AsDouble();

            // Nếu không có, thử tìm trong Symbol (Family Type)
            if (elem is FamilyInstance fi)
            {
                Parameter typeParam = fi.Symbol.LookupParameter(paramName);
                if (typeParam != null && typeParam.StorageType == StorageType.Double)
                    return typeParam.AsDouble();
            }

            return 0;
        }

        private double GetColumnHeight(Element elem)
        {
            BoundingBoxXYZ bbox = elem.get_BoundingBox(null);
            if (bbox == null) return 0;
            return bbox.Max.Z - bbox.Min.Z;
        }

        private string GetColumnPosition(Element elem, Document doc)
        {
            string levelName = doc.GetElement(elem.LevelId)?.Name ?? "Unknown Tầng";

            LocationPoint loc = elem.Location as LocationPoint;
            if (loc == null) return levelName;

            XYZ point = loc.Point;

            // Tìm 2 trục gần nhất (1 theo X, 1 theo Y)
            List<Grid> grids = new FilteredElementCollector(doc)
                .OfClass(typeof(Grid))
                .Cast<Grid>()
                .ToList();

            string gridX = null;
            string gridY = null;
            double minDistX = double.MaxValue;
            double minDistY = double.MaxValue;

            foreach (Grid grid in grids)
            {
                Line line = grid.Curve as Line;
                if (line == null) continue;

                XYZ direction = (line.GetEndPoint(1) - line.GetEndPoint(0)).Normalize();
                XYZ perpX = new XYZ(1, 0, 0);
                XYZ perpY = new XYZ(0, 1, 0);

                double angleToX = Math.Abs(direction.AngleTo(perpX));
                double angleToY = Math.Abs(direction.AngleTo(perpY));

                XYZ projected = grid.Curve.Project(point)?.XYZPoint;
                if (projected == null) continue;

                double distance = projected.DistanceTo(point);

                // Gần trục theo X
                if (angleToX < 0.2 && distance < minDistX)
                {
                    minDistX = distance;
                    gridX = grid.Name;
                }

                // Gần trục theo Y
                if (angleToY < 0.2 && distance < minDistY)
                {
                    minDistY = distance;
                    gridY = grid.Name;
                }
            }

            if (gridX == null) gridX = "?";
            if (gridY == null) gridY = "?";

            return $"{levelName} trục {gridX}-{gridY}";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (cmbCPosition.SelectedItem != null)
            { 
                DanhSachAs.DanhSachCot.Add(cmbCPosition.SelectedItem.ToString());
            }
        }
       
    }
}

using Autodesk.Revit.DB.Structure;

using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;

namespace KtraGiuaKy
{

    public partial class VeThep : System.Windows.Forms.Form
    {
        ExternalCommandData commandData;

        private Document doc;
        private UIDocument uidoc;
        public VeThep(ExternalCommandData commandData)
        {
            InitializeComponent();

            cmbCot.Items.AddRange(DanhSachAs.DanhSachCot.ToArray());
            this.commandData = commandData;

            this.uidoc = commandData.Application.ActiveUIDocument;
            this.doc = uidoc.Document;
        }

        private void cmbCot_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbCot.SelectedIndex;
            if (index >= 0 && index < DanhSachAs.DanhSachDienTich.Count)
            {
                txtAs.Text = DanhSachAs.DanhSachDienTich[index];
            }
            else
            {
                txtAs.Text = "";
            }
        }

        private void TinhToan(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbDuongKinh.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                txtAsef.Text = "";
                txtKiemTra.Text = "";
                return;
            }

            if (!double.TryParse(cmbDuongKinh.Text, out double duongKinh) ||
                !int.TryParse(txtSoLuong.Text, out int soLuong) ||
                !double.TryParse(txtAs.Text, out double ketQuaYeuCau))
            {
                txtAsef.Text = "";
                txtKiemTra.Text = "";
                return;
            }

            double tongDienTich = TinhTongDienTich(duongKinh, soLuong);

            txtAsef.Text = tongDienTich.ToString("N1");
            txtKiemTra.Text = tongDienTich >= ketQuaYeuCau ? "Thỏa mãn" : "Không thỏa mãn";
        }

        private double TinhTongDienTich(double duongKinh, int soLuong)
        {
            double dienTich1Cay = Math.PI * duongKinh * duongKinh / 4.0;
            return dienTich1Cay * soLuong;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            if (!double.TryParse(txtLopBaoVe.Text, out double coverMM) || coverMM < 0)
            {
                MessageBox.Show("Vui lòng nhập lớp bảo vệ hợp lệ (mm).");
                return;
            }

            // Validate số lượng thép
            if (!int.TryParse(txtSoLuong.Text, out int quantity) || quantity < 1)
            {
                MessageBox.Show("Vui lòng nhập số lượng thép hợp lệ (số nguyên dương).");
                return;
            }

            // Chuyển mm sang foot (internal unit)
            double coverFeet = UnitUtils.ConvertToInternalUnits(coverMM, UnitTypeId.Millimeters);

            try
            {
                RebarHelper.DrawColumnRebar(doc, uidoc, coverFeet, quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            this.Enabled = true;
        }

        

    }
}



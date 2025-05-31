using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KtraGiuaKy.KiemTraTHChiuNen;

namespace KtraGiuaKy
{
    public partial class NoiLucTinhToan : Form
    {
        public NoiLucTinhToan()
        {
            InitializeComponent();
        }

              
        private ChonVatLieu t1;
        public void SetChonVatLieu(ChonVatLieu chon)
        {
            t1 = chon;
        }

        private SoLieuTinhToan t2;

        public void SetSoLieuTinhToan(SoLieuTinhToan f)
        {
            t2 = f;
        }

        private void btnTinhNL1_Click(object sender, EventArgs e)
        {
            string groupText = groupBox1.Text;
            var KT = new KiemTraTHChiuNen(this, t1, t2, groupText);

            KT.OpenedFrom = KiemTraTHChiuNen.SourceButton.btnTinhNL1;
            KT.MoTuFormNoiLuc = this;
            KT.Show();
        }

        private void btnTinhNL2_Click(object sender, EventArgs e)
        {
            string groupText = groupBox2.Text;
            var KT = new KiemTraTHChiuNen(this, t1, t2, groupText);

            KT.OpenedFrom = KiemTraTHChiuNen.SourceButton.btnTinhNL2;
            KT.MoTuFormNoiLuc = this;
            KT.Show();
        }

        private void btnTinhNL3_Click(object sender, EventArgs e)
        {
            string groupText = groupBox3.Text;
            var KT = new KiemTraTHChiuNen(this, t1, t2, groupText);

            KT.OpenedFrom = KiemTraTHChiuNen.SourceButton.btnTinhNL3;
            KT.MoTuFormNoiLuc = this;
            KT.Show();
        }

        private void btnLuuTru_Click(object sender, EventArgs e)
        {
            double As1 = double.Parse(txtAs1.Text);
            double As2 = double.Parse(txtAs2.Text);
            double As3 = double.Parse(txtAs3.Text);
            double AsMax = Math.Max(As1, Math.Max(As2, As3));
            DanhSachAs.DanhSachDienTich.Add(AsMax.ToString());

            this.Close();

            var fSoLieuTinhToan = Application.OpenForms["SoLieuTinhToan"];
            fSoLieuTinhToan?.Close();
            
        }
    }
}

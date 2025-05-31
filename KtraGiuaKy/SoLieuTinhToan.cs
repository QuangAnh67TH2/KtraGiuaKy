using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KtraGiuaKy
{
    public partial class SoLieuTinhToan : Form
    {
        public SoLieuTinhToan()
        {

        }
        private LayThongTinCot C1;
        public SoLieuTinhToan(LayThongTinCot c1)
        {
            InitializeComponent();
            C1 = c1;

            txtb.Text = C1.txtb.Text;
            txth.Text = C1.txth.Text;
            txtL.Text = C1.txtL.Text;

        }
        

        //private void SoLieuTinhToan_Load(object sender, EventArgs e)
        //{
        //    txtb.Text = b.ToString();
        //    txth.Text = h.ToString();
        //    txtL.Text = L.ToString();
        //}

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txta.Text) ||
                string.IsNullOrWhiteSpace(txtSi.Text) ||
                string.IsNullOrWhiteSpace(txtMi.Text))
            {
                MessageBox.Show("⚠️ Điền đầy đủ số liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            double b = double.Parse(C1.txtb.Text);
            double h = double.Parse(C1.txth.Text);
            double L = double.Parse(C1.txtL.Text);

            double a = double.Parse(txta.Text);
            double Si = double.Parse(txtSi.Text);
            double Mi = double.Parse(txtMi.Text);

            double h0 = h - a;    txth0.Text = h0.ToString();
            txtza.Text = (h0 - a).ToString();
            txtDelta.Text = (a/h0).ToString("N3");

            txtL0.Text = (L * Si).ToString();

            double ea1 = h / 30;
            double ea2 = L/600;
            double ea3 = 10;

            double max = Math.Max(ea1, Math.Max(ea2, ea3));
            txtea.Text = max.ToString("N2");



        }
        

        private ChonVatLieu chonVatLieu;

        public void SetChonVatLieu(ChonVatLieu chon)
        {
            chonVatLieu = chon;
        }
        private void btn_openNoiLuc_Click(object sender, EventArgs e)
        {
            NoiLucTinhToan NL = new NoiLucTinhToan();
            NL.SetSoLieuTinhToan(this);
            NL.SetChonVatLieu(chonVatLieu);
            NL.Show();
        }




    }
}

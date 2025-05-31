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
    public partial class LechTamLonsp : Form
    {
        
        private NoiLucTinhToan NL4;
        private ChonVatLieu T4;
        private SoLieuTinhToan F4;
        private KiemTraTHChiuNen KT4;
        public LechTamLonsp(NoiLucTinhToan nl4, ChonVatLieu t4, SoLieuTinhToan f4, KiemTraTHChiuNen kt4)
        {
            InitializeComponent();

            NL4 = nl4;
            T4 = t4;
            F4 = f4;
            KT4 = kt4;
        }

        private void LechTamLonsp_Load(object sender, EventArgs e)
        {
            double N1 = double.Parse(NL4.txtN1.Text);

            double Rs = double.Parse(T4.txtRs.Text);

            double b = double.Parse(F4.txtb.Text);
            double h0 = double.Parse(F4.txth0.Text);
            double za = double.Parse(F4.txtza.Text);
            double Mimin = double.Parse(F4.txtMi.Text);

            double e0 = double.Parse(KT4.txte0.Text);
            double Eta = double.Parse(KT4.txtEta.Text);


            double As = (N1 * 1000 * (2 * Eta * e0 - za)) / (2 * Rs * za);
            txtAs.Text = As.ToString("N1");

            double Mi = As * 100 / (b * h0);
            txtMi.Text = Mi.ToString("N2");

            double Mit = 2 * Mi;
            txtMit.Text = Mit.ToString("N2");

            double Mimin2 = 2 * Mimin;
            txt2Mimin.Text = Mimin2.ToString("N2");

            if (Mit >= Mimin2)
            {
                txtss.Text = ">";
                txtketqua.Text = "Thỏa mãn";

                btnOK.Visible = true;
            }
            else
            {
                txtss.Text = "<";
                txtketqua.Text = "Không thỏa mãn";
                btnAsMin.Visible = true;
            }
        }

        private void btnAsMin_Click(object sender, EventArgs e)
        {
            double Mimin = double.Parse(F4.txtMi.Text);

            double Mi = Mimin;
            txtMi.Text = Mi.ToString("N2");

            double Mit = 2 * Mi;
            txtMit.Text = Mit.ToString("N2");

            double Mimin2 = 2 * Mimin;
            txt2Mimin.Text = Mimin2.ToString("N2");

            double b = double.Parse(F4.txtb.Text);
            double h0 = double.Parse(F4.txth0.Text);
            double As = b * h0 * Mimin / 100;
            txtAs.Text = As.ToString();

            if (Mit >= Mimin2)
            {
                txtss.Text = ">";
                txtketqua.Text = "Thỏa mãn";
                btnOK.Visible = true;
                btnAsMin.Visible = false;
            }
            else
            {
                txtss.Text = "<";
                txtketqua.Text = "Không thỏa mãn";
                btnAsMin.Visible = true;
            }
        }


        public KiemTraTHChiuNen MoTuKT { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string As = txtAs.Text;

            if (MoTuKT != null && MoTuKT.MoTuFormNoiLuc != null)
            {
                if (MoTuKT.OpenedFrom == SourceButton.btnTinhNL1)
                {
                    MoTuKT.MoTuFormNoiLuc.txtAs1.Text = As;
                }

                else if (MoTuKT.OpenedFrom == SourceButton.btnTinhNL2)
                {
                    MoTuKT.MoTuFormNoiLuc.txtAs2.Text = As;
                }
                else if (MoTuKT.OpenedFrom == SourceButton.btnTinhNL3)
                {
                    MoTuKT.MoTuFormNoiLuc.txtAs3.Text = As;
                }
            }

            //NL2.NhanDuLieu(As);

            this.Close();
            KT4.Close();
        }

       
    }
}

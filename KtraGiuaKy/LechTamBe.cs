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
    public partial class LechTamBe : Form
    {

        private NoiLucTinhToan NL2;
        private ChonVatLieu T2;
        private SoLieuTinhToan F2;
        private KiemTraTHChiuNen KT2;

        public LechTamBe(NoiLucTinhToan nl2, ChonVatLieu t2, SoLieuTinhToan f2, KiemTraTHChiuNen kt2)
        {
            InitializeComponent();

            NL2 = nl2;
            T2 = t2;
            F2 = f2;
            KT2 = kt2;
        }


        private void LechTamBe_Load(object sender, EventArgs e)
        {
            double XiR = double.Parse(T2.txtXiR.Text);
            double Rb = double.Parse(T2.txtRb.Text);
            double Rs = double.Parse(T2.txtRs.Text);

            double N1 = double.Parse(NL2.txtN1.Text);

            double Alphan = double.Parse(KT2.txtAlphan.Text);
            double Eta = double.Parse(KT2.txtEta.Text);
            double e0 = double.Parse(KT2.txte0.Text);

            double za = double.Parse(F2.txtza.Text);
            double b = double.Parse(F2.txtb.Text);
            double h0 = double.Parse(F2.txth0.Text);
            double Delta = double.Parse(F2.txtDelta.Text);
            double Mimin = double.Parse(F2.txtMi.Text);

            double Xi1 = Math.Min((Alphan + XiR) / 2, 1);
            txtXi1.Text = Xi1.ToString("N3");

            double Alpham1 = (N1 * 1000 * (Eta * e0 + 0.5 * za)) / (Rb * b * Math.Pow(h0, 2));
            txtAlpham1.Text = Alpham1.ToString("N3");

            double Alphas1 = (Alpham1 - Xi1 * (1 - 0.5 * Xi1)) / (1 - Delta);
            txtAlphas1.Text = Alphas1.ToString("N3");

            double Xi = (Alphan * (1 - XiR) + 2 * Alphas1 * XiR) / (1 - XiR + 2 * Alphas1);
            txtXi.Text = Xi.ToString("N3");

            double As = ((Rb * b * h0) / Rs) * ((Alpham1 - Xi * (1 - 0.5 * Xi)) / (1 - Delta));
            txtAs.Text = As.ToString("N1");

            double Mi = (As *100) / (b * h0);
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
            double Mimin = double.Parse(F2.txtMi.Text);

            double Mi = Mimin;
            txtMi.Text = Mi.ToString("N2");

            double Mit = 2 * Mi;
            txtMit.Text = Mit.ToString("N2");

            double Mimin2 = 2 * Mimin;
            txt2Mimin.Text = Mimin2.ToString("N2");

            double b = double.Parse(F2.txtb.Text);
            double h0 = double.Parse(F2.txth0.Text);
            double As = b*h0*Mimin/100;
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


        public KiemTraTHChiuNen MoTuKT {  get; set; }
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
            KT2.Close();
        }

       
    }
}

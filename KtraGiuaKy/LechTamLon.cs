using Autodesk.Revit.DB.Structure;
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
    public partial class LechTamLon : Form
    {
        private NoiLucTinhToan NL3;
        private ChonVatLieu T3;
        private SoLieuTinhToan F3;
        private KiemTraTHChiuNen KT3;
        public LechTamLon(NoiLucTinhToan nl3, ChonVatLieu t3, SoLieuTinhToan f3, KiemTraTHChiuNen kt3)
        {
            InitializeComponent();

            NL3 = nl3;
            T3 = t3;
            F3 = f3;
            KT3 = kt3;
        }

        private void LechTamLon_Load(object sender, EventArgs e)
        {
            double N1 = double.Parse(NL3.txtN1.Text);

            double Rb = double.Parse(T3.txtRb.Text);
            double Rs = double.Parse(T3.txtRs.Text);

            double b = double.Parse(F3.txtb.Text);
            double h0 = double.Parse(F3.txth0.Text);
            double za = double.Parse(F3.txtza.Text);
            double Delta = double.Parse(F3.txtDelta.Text);
            double Mimin = double.Parse(F3.txtMi.Text);

            double e0 = double.Parse(KT3.txte0.Text);
            double Eta = double.Parse(KT3.txtEta.Text);
            double Alphan = double.Parse(KT3.txtAlphan.Text);

            double Alpham1 = (N1 * 1000 * (Eta * e0 + 0.5 * za)) / (Rb * b * Math.Pow(h0, 2));
            txtAlpham1.Text = Alpham1.ToString("N3");

            double As = ((Rb * b * h0) / Rs) * ((Alpham1 - Alphan * (1 - 0.5 * Alphan)) / (1 - Delta));
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
            double Mimin = double.Parse(F3.txtMi.Text);

            double Mi = Mimin;
            txtMi.Text = Mi.ToString("N2");

            double Mit = 2 * Mi;
            txtMit.Text = Mit.ToString("N2");

            double Mimin2 = 2 * Mimin;
            txt2Mimin.Text = Mimin2.ToString("N2");

            double b = double.Parse(F3.txtb.Text);
            double h0 = double.Parse(F3.txth0.Text);
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
            KT3.Close();
        }

        
    }
}

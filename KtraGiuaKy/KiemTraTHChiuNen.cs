using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KtraGiuaKy
{
    public partial class KiemTraTHChiuNen : Form
    {
        private SoLieuTinhToan F1;
        private ChonVatLieu T1;
        private NoiLucTinhToan NL1;


        public KiemTraTHChiuNen(NoiLucTinhToan nl1, ChonVatLieu t1, SoLieuTinhToan f1, string groupTitle)
        {
            InitializeComponent();
            groupBox1.Text = groupTitle;

            NL1 = nl1;
            F1 = f1;
            T1 = t1;

            //txtM1.Text = NL1.txtM1.Text;
            //txtN1.Text = NL1.txtN1.Text;
            
            
        }


        private void KiemTraTHChiuNen_Load(object sender, EventArgs e)
        {
            switch (OpenedFrom)
            {
                case SourceButton.btnTinhNL1:
                    txtM1.Text = NL1.txtM1.Text;
                    txtN1.Text = NL1.txtN1.Text;
                    break;
                case SourceButton.btnTinhNL2:
                    txtM1.Text = NL1.txtM2.Text;
                    txtN1.Text = NL1.txtN2.Text;
                    break;
                case SourceButton.btnTinhNL3:
                    txtM1.Text = NL1.txtM3.Text;
                    txtN1.Text = NL1.txtN3.Text;
                    break;
            }
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtut.Text) ||
                string.IsNullOrWhiteSpace(txtPhiL.Text))
            {
                MessageBox.Show("⚠️ Điền đầy đủ số liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            double M1 = 0;
            double N1 = 0;
            switch (OpenedFrom)
            {
                case SourceButton.btnTinhNL1:
                    M1 = double.Parse(NL1.txtM1.Text);
                    N1 = double.Parse(NL1.txtN1.Text);
                    break;
                case SourceButton.btnTinhNL2:
                    M1 = double.Parse(NL1.txtM2.Text);
                    N1 = double.Parse(NL1.txtN2.Text);
                    break;
                case SourceButton.btnTinhNL3:
                    M1 = double.Parse(NL1.txtM3.Text);
                    N1 = double.Parse(NL1.txtN3.Text);
                    break;
            }

            double ea = double.Parse(F1.txtea.Text); txtea.Text = ea.ToString();

            double ut = double.Parse(txtut.Text);
            double PhiL = double.Parse(txtPhiL.Text);

            txte1.Text = (Math.Abs(M1 / N1) *1000).ToString("N1");

            double e1 = double.Parse(txte1.Text);
            double max = Math.Max(ea,e1);
            txte0.Text = max.ToString(); double e0 = double.Parse(txte0.Text);

            double h = double.Parse(F1.txth.Text);
            double h0 = double.Parse(F1.txth0.Text);
            double b = double.Parse(F1.txtb.Text);
            double a = double.Parse(F1.txta.Text);
            double Is = ut/100 * b * h0 * Math.Pow((0.5 * h - a), 2);
            txtIs.Text = Is.ToString();
            

            txtDeltae.Text = (e0 / h).ToString("N3"); double Deltae = double.Parse(txtDeltae.Text);

            double kb = (0.15 / (PhiL * (0.3 + Deltae)));
            txtkb.Text = kb.ToString("N3");


            double ks = 0.7;
            double Eb = double.Parse(T1.txtEb.Text);
            double Es = double.Parse(T1.txtEs1.Text);
            double I = ((b * Math.Pow(h, 3)) / 12);
            double D = (kb * Eb * I + ks * Es * Is);
            string scientific = D.ToString("0.000E+0");

            string[] parts = scientific.Split('E');
            double baseNum = double.Parse(parts[0]);
            int exponent = int.Parse(parts[1]);

            //baseNum *= 100;
            //exponent -= 2;
            //baseNum = Math.Round(baseNum, 1);
            txtD.Text = $"{baseNum} x 10^{exponent}";

            double pi = 3.14;
            double L0 = double.Parse(F1.txtL0.Text);
            txtNcr.Text = (((Math.Pow(pi, 2) * D) / Math.Pow(L0, 2)) / 1000).ToString("N1");
            double Ncr = double.Parse(txtNcr.Text);

            txtEta.Text = (1 / (1 - (N1 / Ncr))).ToString("N2");

            double Rb = double.Parse(T1.txtRb.Text);
            txtAlphan.Text = ((N1 * 1000) / (Rb * b * h0)).ToString("N3");
            double Alphan = double.Parse(txtAlphan.Text);
            
            double XiR = double.Parse(T1.txtXiR.Text); txtXiR.Text = XiR.ToString();
            double Delta = double.Parse(F1.txtDelta.Text); txt2Delta.Text = (2*Delta).ToString();

            if (Alphan > XiR)
            {
                txtss1.Text = ">";
                txtKetqua.Text = "Lệch tâm bé";
                
            }
            else
            {
                label25.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                txtss2.Visible = true;
                txt2Delta.Visible = true;

                txtss1.Text = "<";

                if (Alphan > 2*Delta)
                {
                    txtss2.Text = ">";
                    txtKetqua.Text = "Lệch tâm lớn";
                }
                else
                {
                    txtss2.Text = "<";
                    txtKetqua.Text = "Lệch tâm lớn đặc biệt";
                }

            }


        }

        private void btnTinhthep_Click(object sender, EventArgs e)
        {
            switch (txtKetqua.Text.Trim())
            {
                case "Lệch tâm bé":
                    var formLechTamBe = new LechTamBe(NL1, T1, F1, this);
                    formLechTamBe.MoTuKT = this;
                    formLechTamBe.Show();
                    break;
                case "Lệch tâm lớn":
                    var formLechTamLon = new LechTamLon(NL1, T1, F1, this);
                    formLechTamLon.MoTuKT = this;
                    formLechTamLon.Show();
                    break;
                case "Lệch tâm lớn đặc biệt":
                    var formLechTamLonsp = new LechTamLonsp(NL1, T1, F1, this);
                    formLechTamLonsp.MoTuKT = this;
                    formLechTamLonsp.Show();
                    break;
                
            }

        }


        //private NoiLucTinhToan tr1;
        //private void Solieu1_load(object sender, EventArgs e)
        //{
        //    tr1 = new NoiLucTinhToan();
        //}

        //private ChonVatLieu tr2;
        //private void Solieu2_load(object sender, EventArgs e)
        //{
        //    tr2 = new ChonVatLieu();
        //}

        //private SoLieuTinhToan tr3;
        //private void Solieu3_load(object sender, EventArgs e)
        //{
        //    tr3 = new SoLieuTinhToan();
        //}


        public enum SourceButton
        {
            btnTinhNL1,
            btnTinhNL2,
            btnTinhNL3,
        }

        public SourceButton OpenedFrom { get; set; }
        public NoiLucTinhToan MoTuFormNoiLuc { get; set; }

        
    }
}

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
    public partial class ChonVatLieu : Form
    {


        private List<BeTong> danhsachBeTong;
        private List<Thep> danhsachThep;
        public ChonVatLieu()
        {
            InitializeComponent();
            ThongSoVatLieu();
            DuLieuComboBox();

        }

        private void ThongSoVatLieu()
        {
            danhsachBeTong = new List<BeTong>()
            {
                new BeTong { Ten = "--Chọn loại--" },
                new BeTong {Ten = "B15", Rb = 8.5, Rbt = 0.75, Eb = 24000},
                new BeTong {Ten = "B20", Rb = 11.5, Rbt = 0.90, Eb = 27500},
                new BeTong {Ten = "B25", Rb = 14.5, Rbt = 1.05, Eb = 30000},
                new BeTong {Ten = "B30", Rb = 17.0, Rbt = 1.15, Eb = 32500},
                new BeTong {Ten = "B35", Rb = 19.5, Rbt = 1.30, Eb = 34500},
                new BeTong {Ten = "B40", Rb = 22.0, Rbt = 1.40, Eb = 36000},
                new BeTong {Ten = "B45", Rb = 25.0, Rbt = 1.50, Eb = 37000},

            };

            danhsachThep = new List<Thep>()
            {
                new Thep { Ten = "--Chọn loại--" },
                new Thep {Ten = "CB240-T", Rs = 210, Rsw = 170, Es = 200000},
                new Thep {Ten = "CB300-T", Rs = 260, Rsw = 210, Es = 200000},
                new Thep {Ten = "CB300-V", Rs = 260, Rsw = 210, Es = 200000},
                new Thep {Ten = "CB400-V", Rs = 350, Rsw = 280, Es = 200000},
                new Thep {Ten = "CB500-V", Rs = 435, Rsw = 300, Es = 200000},


            };

            
        }

        private void DuLieuComboBox()
        {
            cmbBetong.DataSource = danhsachBeTong;
            cmbBetong.DisplayMember = "Ten";

            cmbThepdoc.DataSource = danhsachThep.ToList();
            cmbThepdoc.DisplayMember = "Ten";

            cmbThepdai.DataSource = danhsachThep.ToList();
            cmbThepdai.DisplayMember = "Ten";
        }


        private void cmbBetong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBetong.Text == "--Chọn loại--")
            {
                txtRb.Text = "";
                txtRbt.Text = "";
                txtEb.Text = "";
                txtXiR.Text = "";
                txtAlphaR.Text = "";
                return;

            }

            var Betong = cmbBetong.SelectedItem as BeTong;
            
            if (Betong != null)
            {
                txtRb.Text = Betong.Rb.ToString();
                txtRbt.Text = Betong.Rbt.ToString();
                txtEb.Text = Betong.Eb.ToString();
            }

        }

        private void cmbThepdoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThepdoc.Text == "--Chọn loại--")
            {
                txtRs.Text = "";               
                txtEs1.Text = "";
                txtXiR.Text = "";
                txtAlphaR.Text = "";
                return;

            }

            var Thepdoc = cmbThepdoc.SelectedItem as Thep;
            if (Thepdoc != null)
            {
                txtRs.Text = Thepdoc.Rs.ToString();
                txtEs1.Text = Thepdoc.Es.ToString();

                if (cmbBetong.SelectedItem == null)
                    return;

                if (cmbThepdoc.Text == "CB240-T")
                {
                    txtXiR.Text = "0.615";
                    txtAlphaR.Text = "0.426";

                }
                else if (cmbThepdoc.Text == "CB300-T" || cmbThepdoc.Text == "CB300-V")
                {
                    txtXiR.Text = "0.583";
                    txtAlphaR.Text = "0.413";
                }
                else if (cmbThepdoc.Text == "CB400-V")
                {
                    txtXiR.Text = "0.533";
                    txtAlphaR.Text = "0.391";
                }
                else if (cmbThepdoc.Text == "CB500-V")
                {
                    txtXiR.Text = "0.493";
                    txtAlphaR.Text = "0.372";
                }


            }

        }
        private void cmbThepdai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThepdai.Text == "--Chọn loại--")
            {
                txtRsw.Text = "";
                txtEs2.Text = "";
                return;

            }

            var Thepdai = cmbThepdai.SelectedItem as Thep;
            if (Thepdai != null)
            {
                txtRsw.Text = Thepdai.Rsw.ToString();
                txtEs2.Text = Thepdai.Es.ToString();
                return;
            }

        }

        

    }
}

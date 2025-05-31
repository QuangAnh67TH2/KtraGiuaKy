using Autodesk.Revit.UI;
using System;
using System.Windows.Forms;

namespace KtraGiuaKy
{
    public partial class START : Form
    {
        ExternalCommandData commandData;

        // Khởi tạo các form cần dùng
        private ChonVatLieu vatLieuForm;
        private LayThongTinCot cotForm;
        private SoLieuTinhToan soLieuForm;
        private NoiLucTinhToan noiLucForm;

        public START(ExternalCommandData commandData)
        {
            InitializeComponent();
            this.commandData = commandData;

            // Khởi tạo form một lần duy nhất
            vatLieuForm = new ChonVatLieu();
            cotForm = new LayThongTinCot(commandData);
            soLieuForm = new SoLieuTinhToan(cotForm);
            noiLucForm = new NoiLucTinhToan();

            // Truyền dữ liệu giữa các form
            soLieuForm.SetChonVatLieu(vatLieuForm);
            noiLucForm.SetChonVatLieu(vatLieuForm);
            noiLucForm.SetSoLieuTinhToan(soLieuForm);

        }

        private void btnopen_VatLieu_Click(object sender, EventArgs e)
        {
            ShowForm(vatLieuForm);
        }

        private void btnopen_Cot_Click(object sender, EventArgs e)
        {
            ShowForm(cotForm);
        }

        private void btnopen_SoLieu_Click(object sender, EventArgs e)
        {
            SoLieuTinhToan sl = new SoLieuTinhToan(cotForm);
            sl.SetChonVatLieu(vatLieuForm);
            sl.Show();
        }

        private void btnopen_NoiLuc_Click(object sender, EventArgs e)
        {
            ShowForm(noiLucForm);
        }

        // Hàm dùng chung để show form đã khởi tạo
        private void ShowForm(Form form)
        {
            if (form.IsDisposed)
            {
                MessageBox.Show("Form đã bị đóng. Vui lòng khởi động lại plugin để mở lại form.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!form.Visible)
            {
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
        }

        private void btnVeThep_Click(object sender, EventArgs e)
        {
            VeThep vethep = new VeThep(commandData);
            vethep.Show();
        }
    }
}

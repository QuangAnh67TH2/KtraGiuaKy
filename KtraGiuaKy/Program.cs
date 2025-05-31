using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KtraGiuaKy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var form1 = new LayThongTinCot(null);
            //var form2 = new NoiLucTinhToan();
            //var form3 = new LuuDienTichThepTT();

            //form2.SetForm1(form1);
            //form2.SetForm3(form3);

            //form1.Show();
            //form2.Show();
            //form3.Show();
            Application.Run(new ChonVatLieu());
        }
    }
}

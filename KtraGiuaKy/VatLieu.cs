using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraGiuaKy
{
    public class VatLieu
    {
        public string Ten {  get; set; }
    }

    public class BeTong : VatLieu
    {
        public double Rb { get; set; }
        public double Rbt { get; set; }
        public double Eb { get; set; }
    }

    public class Thep : VatLieu
    {
        public double Rs { get; set; }
        public double Rsw { get; set; }
        public double Es { get; set; }
    }
}

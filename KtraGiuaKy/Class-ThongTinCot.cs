﻿using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraGiuaKy
{
    public class ThongTinCot
    {
        public string Position { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public ElementId ElementId { get; set; }

        public override string ToString()
        {
            return Position; // Sẽ hiển thị trên ComboBox
        }

    }
}

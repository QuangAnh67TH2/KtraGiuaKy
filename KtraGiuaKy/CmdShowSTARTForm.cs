using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;

namespace KtraGiuaKy
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class CmdShowSTARTForm : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {



            try
            {
                // Khởi tạo và hiển thị form
                START form = new START(commandData);


                form.Show();
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }

        }
    }
}


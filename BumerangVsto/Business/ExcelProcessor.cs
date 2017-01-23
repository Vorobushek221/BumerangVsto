using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace BumerangVsto.Business
{
    public class ExcelProcessor
    {
        public ExcelProcessor()
        {

        }

        public void ConvertByrToByn(Excel.Range selection)
        {
            var converter = new CurrencyConverter();
            foreach (Excel.Range cell in selection.Cells)
            {
                if (cell.Value != null)
                {
                    string value = cell.Value.ToString();
                    cell.NumberFormat = "@";
                    cell.Value = (string)converter.ByrToByn(value);
                }
            }
        }
    }
}

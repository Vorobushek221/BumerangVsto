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

        private void ApplyConvertionToRange(Excel.Range selection, Func<string, string> Method)
        {
            foreach (Excel.Range cell in selection.Cells)
            {
                if (cell.Value != null)
                {
                    string value = cell.Value.ToString();
                    cell.NumberFormat = "@";
                    cell.Value = (string)Method(value);
                }
            }
        }

        public void ConvertBynToByr(Excel.Range selection)
        {
            Func<string, string> convertionMethod = new CurrencyConverter().ConvetrBynToByr;
            ApplyConvertionToRange(selection, convertionMethod);
        }

        public void ConvertByrToByn(Excel.Range selection)
        {
            Func<string, string> convertionMethod = new CurrencyConverter().ConvetrByrToByn;
            ApplyConvertionToRange(selection, convertionMethod);
        }
    }
}

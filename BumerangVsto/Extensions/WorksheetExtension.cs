using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace BumerangVsto.Extensions
{
    public static class WorksheetExtension
    {
        public static string GetValue(this Excel.Worksheet ws, string location)//Плохо написано очень!
        {
            if(string.IsNullOrEmpty(location) || string.IsNullOrWhiteSpace(location) || location.Length < 2)
            {
                return null;
            }
            else
            {
                string letter = location.Substring(0, 1);
                string number = location.Substring(1);
                int f = (int)letter[0] - (int)'A' + 1;
                int n = int.Parse(number.ToString());
                try
                {
                    return ws.Cells[int.Parse(number.ToString()), (int)letter[0] - (int)'A' + 1].Value.ToString();
                }
                catch
                {
                    return null;
                }

            }
        }
    }
}

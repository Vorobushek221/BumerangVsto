using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Business
{
    public class CurrencyConverter
    {
        public CurrencyConverter()
        {
        }

        public string ByrToByn(string byrStr)
        {
            decimal byrSum = 0;
            if (decimal.TryParse(byrStr, out byrSum))
            {
                return Math.Round(byrSum / 10000, 2).ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
            else
            {
                return string.Empty;
            }
        }

    }
}

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

        private string ConvetrCurrency(string sumStr, bool byrToBynConvertion)
        {
            decimal sum = 0;
            if (decimal.TryParse(sumStr.Replace('.', ','), out sum))
            {
                if (byrToBynConvertion)
                {
                    return Math.Round(sum / 10000, 2).ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                }
                else
                {
                    return Math.Round(sum * 10000, 0).ToString("0", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                }
            }
            else
            {
                return string.Empty;
            }
        }

        public string ConvetrByrToByn(string sumStr)
        {
            return ConvetrCurrency(sumStr, true);
        }

        public string ConvetrBynToByr(string sumStr)
        {
            return ConvetrCurrency(sumStr, false);
        }

    }
}

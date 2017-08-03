using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BumerangVsto.Model.Global
{
    public static class Constants
    {
        public const string BynRegexPattern = @"^\d+((\.|,)\d+)?$";

        public const string DateFormat = "dd.MM.yyyy";

        public const string PathToTemplates = @"C:\BumerangVstoData\Templates\Templates.xls";
    }
}

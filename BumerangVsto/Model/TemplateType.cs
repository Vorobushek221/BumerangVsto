using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Business.Model
{
    public enum TemplateType
    {
        [Description("")]
        None,

        [Description("по 2 в строке")]
        Template2,

        [Description("по 3 в строке")]
        Template3,

        [Description("по 5 в строке")]
        Template5
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    public class PriceTagList // мб лучше подумать про расширение класса List
    {
        public List<PriceTag> List { get; private set; }

        public PriceTagList()
        {
            List = new List<PriceTag>();
        }

    }
}

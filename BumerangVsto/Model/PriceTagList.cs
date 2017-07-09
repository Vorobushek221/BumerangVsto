using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    public class PriceTagCollection
    {
        public List<PriceTag> List { get; private set; }

        public PriceTagCollection()
        {
            List = new List<PriceTag>();
        }

        public int Length
        {
            get
            {
                return List.Count;
            }
        }

        public PriceTag this[int i]
        {
            get
            {
                return List[i];
            }
            set
            {
                this.List[i] = value;
            }
        }

        public void Remove(PriceTag tag)
        {
            this.List.Remove(tag);
        }

        public void Remove(int i)
        {
            Remove(this[i]);
        }

        public void Add(PriceTag tag)
        {
            this.List.Add(tag);
        }
    }
}

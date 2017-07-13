using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    public class PriceTagCollection : IEnumerable<PriceTag>, IEnumerator<PriceTag>
    {
        public List<PriceTag> List { get; private set; }

        private int position;

        public PriceTag Current
        {
            get
            {
                return List[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public PriceTagCollection()
        {
            List = new List<PriceTag>();
            position = -1;
        }

        public int Count
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
            tag.Id = this.Count;
            this.List.Add(tag);
        }

        public bool MoveNext()
        {
            if(position < List.Count -1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public IEnumerator<PriceTag> GetEnumerator()
        {
            return (IEnumerator<PriceTag>)this;
        }

        public void Dispose()
        {
        }
    }
}

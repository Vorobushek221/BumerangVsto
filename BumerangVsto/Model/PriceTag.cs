using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    class PriceTag
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string Provider { get; set; }

        public string Number { get; set; }

        public string Date { get; set; }

        public PriceTag()
        {
            Id = -1;
            Description = "";
            Price = "";
            Provider = "";
            Number = "";
            Date = "";
        }

        public PriceTag(string description, string price, string provider, string number, string date)
        {
            Id = -1;
            Description = description;
            Price = price;
            Provider = provider;
            Number = number;
            Date = date;
        }

        public static bool operator ==(PriceTag left, PriceTag right)
        {
            if (left.Description == right.Description &&
                left.Price == right.Price &&
                left.Provider == right.Provider &&
                left.Number == right.Number &&
                left.Date == right.Date)
                return true;
            else
                return false;
        }

        public static bool operator !=(PriceTag left, PriceTag right)
        {
            if (left.Description != right.Description &&
                left.Price != right.Price &&
                left.Provider != right.Provider &&
                left.Number != right.Number &&
                left.Date != right.Date)
                return true;
            else
                return false;
        }

    }
}

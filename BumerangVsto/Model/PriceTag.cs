using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    public class PriceTag
    {
        public string Description { get; set; }

        public string Price { get; set; }

        public string Provider { get; set; }

        public string Number { get; set; }

        public string Date { get; set; }

        public PriceTag()
        {
            Description = string.Empty;
            Price = string.Empty;
            Provider = string.Empty;
            Number = string.Empty;
            Date = string.Empty;
        }

        public PriceTag(string description, string price, string provider, string number, string date)
        {
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

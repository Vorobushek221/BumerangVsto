using BumerangVsto.Business.Model;
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

        public TemplateType TemplateType { get; set; }

        public PriceTag()
        {

        }

        public PriceTag(string description, string price, string provider, string number, string date, TemplateType templateType)
        {
            this.Description = description;
            this.Price = price;
            this.Provider = provider;
            this.Number = number;
            this.Date = date;
            this.TemplateType = templateType;
        }

    }
}

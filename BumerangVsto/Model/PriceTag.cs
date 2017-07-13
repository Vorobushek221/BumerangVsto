using BumerangVsto.Business.Model;
using BumerangVsto.Model.Global;
using BumerangVsto.Model.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    public class PriceTag
    {
        public int Id { get; set; }

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

        public PriceTag(Product product)
        {
            this.Description = product.Description;
            this.Price = product.ResultPriceRounded.ToString();
            this.Provider = product.ProducerCountry;
            this.Number = product.ConsignmentNoteNumber;
            this.Date = (product.GettingDate != null) ? product.GettingDate.Value.ToString(Constants.DateFormat) : default(string);
        }

        public PriceTag(Product product, TemplateType templateType)
            : this(product)
        {
            this.TemplateType = templateType;
        }

    }
}

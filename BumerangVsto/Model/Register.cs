using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    public class Register
    {
        public Register()
        {
            Products = new List<Product>();
        }

        public int? RegisterNumber { get; set; } //C5

        public DateTime? DateFrom { get; set; } //E5

        public string CompanyName { get; set; } //G7

        public string CompanyAddress { get; set; } //G8

        public string GetterOrgName { get; set; } //A10
        
        public List<Product> Products { get; set; }

        public DateTime RegisterDate { get; set; } //A.....
    }
}

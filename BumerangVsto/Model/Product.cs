using BumerangVsto.Model.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    public class Product
    {
        /// <summary>
        /// Номер ТТН
        /// </summary>
        public string ConsignmentNoteNumber { get; set; }

        /// <summary>
        /// Дата получения товара
        /// </summary>
        public DateTime? GettingDate { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// Объём партии
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// Отпускная цена за ед. изм., руб.
        /// </summary>
        public Byn SellingPrice { get; set; }

        /// <summary>
        /// Торговая надбавка, %
        /// </summary>
        public decimal? PercentMarkUp { get; set; }

        /// <summary>
        /// Торговая надбавка, сумма, руб.
        /// </summary>
        public Byn SumMarkUp { get; set; }

        /// <summary>
        /// Розничная цена, руб.
        /// </summary>
        public Byn ResultPrice { get; set; }

        /// <summary>
        /// Розничная цена с округлением, руб.
        /// </summary>
        public Byn ResultPriceRounded { get; set; }

        /// <summary>
        /// Страна-производитель
        /// </summary>
        public string ProducerCountry { get; set; }
    }
}

using BumerangVsto.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    public class Docket
    {
        public int DocketNumber { get; set; }

        //public const int template2TagAmount = 10;
        //public const int template3TagAmount = 24;
        //public const int template5TagAmount = 65;

        //public static int GetTagAmount(TagsTemplateType type)
        //{
        //    switch (type)
        //    {
        //        case TagsTemplateType.Tags2:
        //            return template2TagAmount;
        //        case TagsTemplateType.Tags3:
        //            return template2TagAmount;
        //        case TagsTemplateType.Tags5:
        //            return template5TagAmount;
        //        default:
        //            return 0;
        //    }
        //}

        public Docket(int number)
        {
            this.DocketNumber = number;
        }

        public Docket()
        {
            this.DocketNumber = 1;
        }

        public void Reset()
        {
            this.DocketNumber = 1;
        }

        public string Description
        {
            get
            {
                return string.Format("{{Description#{0}}}", DocketNumber);
            }
        }

        public string Price
        {
            get
            {
                return string.Format("{{Price#{0}}}", DocketNumber);
            }
        }

        public string Provider
        {
            get
            {
                return string.Format("{{Provider#{0}}}", DocketNumber);
            }
        }

        public string Number
        {
            get
            {
                return string.Format("{{Number#{0}}}", DocketNumber);
            }
        }

        public string Date
        {
            get
            {
                return string.Format("{{Date#{0}}}", DocketNumber);
            }
        }
    }
}

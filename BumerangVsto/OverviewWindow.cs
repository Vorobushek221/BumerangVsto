using BumerangVsto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BumerangVsto
{
    public partial class OverviewWindow : Form
    {
        public OverviewWindow(PriceTagCollection tagCollection)
        {
            InitializeComponent();
            InitTagViewList(tagCollection);
        }

        public void InitTagViewList(PriceTagCollection tagCollection)
        {
            foreach(var tag in tagCollection)
            {
                var item = new ListViewItem()
                {
                    Tag = tag
                };
                item.SubItems.Add(tag.Description);
                item.SubItems.Add(tag.Description);
            }
            //var item = new ListViewItem();
            //item.Tag
            //this.priceTagViewList.Items.Add()
        }
    }
}

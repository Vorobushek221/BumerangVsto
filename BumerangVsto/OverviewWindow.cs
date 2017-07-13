using BumerangVsto.Model;
using BumerangVsto.Model.Global;
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
        private PriceTagCollection tagCollection;

        public OverviewWindow(PriceTagCollection tags)
        {
            InitializeComponent();
            if(tags != null)
            {
                tagCollection = tags;
            }
            InitPriceTagViewList();
        }

        public void InitPriceTagViewList()
        {
            if(tagCollection == null)
            {
                return;
            }
            priceTagViewList.Items.Clear();
            foreach (var tag in tagCollection)
            {
                var item = new ListViewItem()
                {
                    Tag = tag
                };
                item.Text = (tag.Id + 1).ToString();
                item.SubItems.Add(tag.Description);
                item.SubItems.Add(tag.Provider);
                item.SubItems.Add(tag.Number);
                item.SubItems.Add(tag.Date);
                item.SubItems.Add(tag.TemplateType.ToString());
                priceTagViewList.Items.Add(item);
            }

            ResizeListViewColumns(priceTagViewList);
        }

        private void ResizeListViewColumns(ListView listView)
        {
            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = -2;
            }
        }

        private void PriceTagViewListOnDoubleClick(object sender, EventArgs e)
        {
            if (priceTagViewList.SelectedItems != null)
            {
                if(priceTagViewList.SelectedItems.Count == 1)
                {
                    var item = priceTagViewList.SelectedItems[0].Tag as PriceTag;
                    var priceTagWindow = new PriceTagWindow(item);
                    priceTagWindow.OnTagChange += InitPriceTagViewList;
                    priceTagWindow.Show();
                }
            }
        }
    }
}

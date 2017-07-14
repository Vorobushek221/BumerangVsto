using BumerangVsto.Business.Model;
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
    public partial class PriceTagWindow : Form
    {
        private PriceTag priceTag;

        public event Action OnTagChange;

        public PriceTagWindow(PriceTag tag)
        {
            InitializeComponent();
            if(tag != null)
            {
                priceTag = tag;
                SetUpTemplateCombobox(typeof(TemplateType));
                InitFields();
            }
            
        }

        private void InitFields()
        {
            descriptionTextBox.Text = priceTag.Description;
            priceTextBox.Text = priceTag.Price;
            providerTextBox.Text = priceTag.Provider;
            numberTextBox.Text = priceTag.Number;
            dateTextBox.Text = priceTag.Date;
            templateComboBox.SelectedValue = priceTag.TemplateType;
        }

        private void SetUpTemplateCombobox(Type type) // refactor this later
        {
            templateComboBox.DisplayMember = "Description";
            templateComboBox.ValueMember = "Value";
            templateComboBox.DataSource = Enum.GetValues(type)
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            priceTag.Description = this.descriptionTextBox.Text;
            priceTag.Price = this.priceTextBox.Text;
            priceTag.Provider = this.providerTextBox.Text;
            priceTag.Number = this.numberTextBox.Text;
            priceTag.Date = this.dateTextBox.Text;
            priceTag.TemplateType  = (TemplateType)this.templateComboBox.SelectedValue;
            OnTagChange?.Invoke();
            this.Close();
        }
    }
}

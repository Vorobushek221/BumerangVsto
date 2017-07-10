using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace BumerangVsto
{
    public partial class MainRibbon
    { 
        public event Action CreateTagsTemplate2ButClicked;

        public event Action CreateTagsTemplate3ButClicked;

        public event Action CreateTagsTemplate5ButClicked;

        public event Action OverviewButClicked;

        private void MainRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }


        private void CreateTagsTemplate2Button_Click(object sender, RibbonControlEventArgs e)
        {
            CreateTagsTemplate2ButClicked?.Invoke();
        }

        private void CreateTagsTemplate3Button_Click(object sender, RibbonControlEventArgs e)
        {
            CreateTagsTemplate3ButClicked?.Invoke();
        }

        private void CreateTagsTemplate5Button_Click(object sender, RibbonControlEventArgs e)
        {
            CreateTagsTemplate5ButClicked?.Invoke();
        }

        private void OverviewButton_Click(object sender, RibbonControlEventArgs e)
        {
            OverviewButClicked?.Invoke();
        }
    }
}

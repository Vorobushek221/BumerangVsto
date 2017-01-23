using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace BumerangVsto
{
    public partial class MainRibbon
    {
        public event Action CreateTagsButClicked;

        public event Action ByrToBynButClicked;

        private void MainRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }


        private void createTagsBut_Click(object sender, RibbonControlEventArgs e)
        {
            CreateTagsButClicked?.Invoke();
        }

        private void byrToBynBut_Click(object sender, RibbonControlEventArgs e)
        {
            ByrToBynButClicked?.Invoke();
        }
    }
}

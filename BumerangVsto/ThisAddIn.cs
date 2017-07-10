using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using BumerangVsto.Business;
using BumerangVsto.Model;

namespace BumerangVsto
{
    public partial class ThisAddIn
    {
        public ExcelProcessor excelProcessor;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            excelProcessor = new ExcelProcessor(Globals.ThisAddIn.Application);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            var ribbon = new MainRibbon();
            ribbon.CreateTagsTemplate2ButClicked += AddTagsTemplate2;
            ribbon.CreateTagsTemplate3ButClicked += AddTagsTemplate3;
            ribbon.CreateTagsTemplate5ButClicked += AddTagsTemplate5;
            ribbon.OverviewButClicked += OpenOverviewWindow;

            return Globals.Factory.GetRibbonFactory().CreateRibbonManager(new IRibbonExtension[] { ribbon });
        }

        private void AddTagsTemplate2()
        {
            excelProcessor.AddPriceTagsToListTemplate2(Globals.ThisAddIn.Application.ActiveSheet);
        }

        private void AddTagsTemplate3()
        {
            excelProcessor.AddPriceTagsToListTemplate3(Globals.ThisAddIn.Application.ActiveSheet);
        }

        private void AddTagsTemplate5()
        {
            excelProcessor.AddPriceTagsToListTemplate5(Globals.ThisAddIn.Application.ActiveSheet);
        }

        private void OpenOverviewWindow()
        {
            //new OverviewWindow().ShowDialog();
        }


        #region Код, автоматически созданный VSTO

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}

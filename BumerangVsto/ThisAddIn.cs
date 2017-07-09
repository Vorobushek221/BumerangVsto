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
            ribbon.ByrToBynButClicked += ConvertByrToByn;
            ribbon.BynToByrButClicked += ConvertBynToByr;
            ribbon.CreateTagsButClicked += ParseRegisterInfo;
            ribbon.OverviewButClicked += OpenOverviewWindow;

            return Globals.Factory.GetRibbonFactory().CreateRibbonManager(new IRibbonExtension[] { ribbon });
        }

        private void ConvertByrToByn()
        {
            excelProcessor.ConvertByrToByn(Globals.ThisAddIn.Application.Selection);
        }

        private void ConvertBynToByr()
        {
            excelProcessor.ConvertBynToByr(Globals.ThisAddIn.Application.Selection);
        }

        private void ParseRegisterInfo()
        {
            excelProcessor.DoSomeWork();
        }

        private void OpenOverviewWindow()
        {
            new OverviewWindow().ShowDialog();
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

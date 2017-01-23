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

namespace BumerangVsto
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            var ribbon = new SampleRibbon();
            ribbon.ButtonClicked += ribbon_ButtonClicked;
            return Globals.Factory.GetRibbonFactory().CreateRibbonManager(new IRibbonExtension[] { ribbon });
        }

        private void ribbon_ButtonClicked()
        {
            GenerateTable(Application.ActiveWorkbook.ActiveSheet, 1, 1);
        }

        private void GenerateTable(dynamic wSheet, int row, int column)
        {
            var currentMonth = GetDaysOfCurrentMonth().ToArray();
            for (int i = 0; i < currentMonth.Length; i++)
            {
                wSheet.Cells[row, column + i] = currentMonth[i].Day;
                MarkCell(wSheet.Cells[row, column + i], currentMonth[i]);
            }
        }

        public static void MarkBold(dynamic border)
        {
            border.Weight = Office.XlBorderWeight.xlMedium;
        }

        public enum Border
        {
            Left = 1,
            Right = 2,
            Top = 3,
            Bottom = 4
        }

        private void MarkCell(dynamic cell, DateTime day)
        {
            if (day.DayOfWeek == DayOfWeek.Saturday)
            {
                MarkBold(cell.Borders[Border.Left]);
                MarkBold(cell.Borders[Border.Top]);
                MarkBold(cell.Borders[Border.Bottom]);
            }
            if (day.DayOfWeek == DayOfWeek.Sunday)
            {
                MarkBold(cell.Borders[Border.Right]);
                MarkBold(cell.Borders[Border.Top]);
                MarkBold(cell.Borders[Border.Bottom]);
            }
            cell.Columns[1].ColumnWidth = 4;
        }

        private static IEnumerable<DateTime> GetDaysOfCurrentMonth()
        {
            var today = DateTime.Today;
            var dayIter = new DateTime(today.Year, today.Month, 1);
            while (dayIter.Month == today.Month)
            {
                yield return dayIter;
                dayIter = dayIter.AddDays(1);
            }
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

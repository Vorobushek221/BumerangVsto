using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumerangVsto.Model
{
    public static class Logger
    {
        public static List<LogRow> LogRows { get; set; }

        static Logger()
        {
            LogRows = new List<LogRow>();
        }

        private static void AddLogRow(LogRowType type, string text)
        {
            LogRows.Add(new LogRow { RowType = type, RowText = text });
        }

        private static List<LogRow> GetRows(LogRowType type)
        {
            return LogRows.Where(row => row.RowType == type).ToList();
        }

        public static void AddWarning(string text)
        {
            AddLogRow(LogRowType.Warning, text);
        }

        public static void AddError(string text)
        {
            AddLogRow(LogRowType.Error, text);
        }

        public  static void AddInfo(string text)
        {
            AddLogRow(LogRowType.Info, text);
        }

        public static void AddOther(string text)
        {
            AddLogRow(LogRowType.Other, text);
        }

        public static List<LogRow> GetInfos()
        {
            return GetRows(LogRowType.Info);
        }

        public static List<LogRow> GetWarnings()
        {
            return GetRows(LogRowType.Warning);
        }

        public static List<LogRow> GetErrors()
        {
            return GetRows(LogRowType.Error);
        }

        public static List<LogRow> GetOthers()
        {
            return GetRows(LogRowType.Other);
        }

        public static List<LogRow> GetAll()
        {
            return LogRows;
        }

        public static void Clear()
        {
            LogRows.Clear();
        }
    }
}

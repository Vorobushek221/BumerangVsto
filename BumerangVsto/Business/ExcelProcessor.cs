using BumerangVsto.Business.Model;
using BumerangVsto.Extensions;
using BumerangVsto.Model;
using BumerangVsto.Model.Global;
using BumerangVsto.Model.Money;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace BumerangVsto.Business
{
    public class ExcelProcessor
    {
        private Excel.Application excelApp;

        private PriceTagCollection tagCollection;

        public ExcelProcessor(Excel.Application app)
        {
            excelApp = app;
        }

        private void ApplyConvertionToRange(Excel.Range selection, Func<string, string> Method)
        {
            foreach (Excel.Range cell in selection.Cells)
            {
                if (cell.Value != null)
                {
                    string value = cell.Value.ToString();
                    string result = (string)Method(value);
                    if (!string.IsNullOrEmpty(result))
                    {
                        cell.Value = result;
                        cell.NumberFormat = "@";
                    }
                }
            }
        }

        public void ConvertBynToByr(Excel.Range selection)
        {
            Func<string, string> convertionMethod = new CurrencyConverter().ConvetrBynToByr;
            ApplyConvertionToRange(selection, convertionMethod);
        }

        public void ConvertByrToByn(Excel.Range selection)
        {
            Func<string, string> convertionMethod = new CurrencyConverter().ConvetrByrToByn;
            ApplyConvertionToRange(selection, convertionMethod);
        }

        public Register ParseRegisterData(Excel.Worksheet activeWorksheet)
        {
            var register = new Register();

            #region RegisterNumber parsing
            var registerNumber = activeWorksheet.GetValue("C5");

            if (!(string.IsNullOrEmpty(registerNumber) || string.IsNullOrWhiteSpace(registerNumber)))
            {
                int registerNumberParsed = 0;
                if (int.TryParse(registerNumber, out registerNumberParsed))
                {
                    register.RegisterNumber = registerNumberParsed;
                    Logger.AddInfo("Номер реестра успешно распознан!");
                }
                else
                {
                    register.RegisterNumber = null;
                    Logger.AddError("Номер реестра не удалось распознать!");
                }
            }
            else
            {
                register.RegisterNumber = null;
                Logger.AddError("Номер реестра не найден!");
            }
            #endregion

            #region DateFrom parsing
            var dateFrom = activeWorksheet.GetValue("E5");

            if (!(string.IsNullOrEmpty(dateFrom) || string.IsNullOrWhiteSpace(dateFrom)))
            {
                DateTime dateFromParsed = default(DateTime);
                if (DateTime.TryParse(dateFrom, out dateFromParsed))
                {
                    register.DateFrom = dateFromParsed;
                    Logger.AddInfo("Дата \"ОТ\" реестра успешно распознана!");
                }
                else
                {
                    register.DateFrom = null;
                    Logger.AddError("Дату \"ОТ\" реестра не удалось распознать!");
                }

            }
            else
            {
                register.DateFrom = null;
                Logger.AddError("Дата \"ОТ\" реестра не найдена!");
            }
            #endregion

            #region CompanyName parsing
            var companyName = activeWorksheet.GetValue("G7");

            if (!(string.IsNullOrEmpty(companyName) || string.IsNullOrWhiteSpace(companyName)))
            {

                register.CompanyName = companyName;
                Logger.AddInfo("Название компании успешно распознано!");

            }
            else
            {
                register.CompanyName = null;
                Logger.AddError("Название компании не найдено!");
            }
            #endregion

            #region CompanyAddress parsing
            var companyAddress = activeWorksheet.GetValue("G8");

            if (!(string.IsNullOrEmpty(companyAddress) || string.IsNullOrWhiteSpace(companyAddress)))
            {
                register.CompanyAddress = companyAddress;
                Logger.AddInfo("Адрес компании успешно распознан!");

            }
            else
            {
                register.CompanyAddress = null;
                Logger.AddError("Адрес компании не найден!");
            }
            #endregion

            #region GetterOrgName parsing
            var getterOrgName = activeWorksheet.GetValue("A10");

            if (!(string.IsNullOrEmpty(getterOrgName) || string.IsNullOrWhiteSpace(getterOrgName)))
            {
                register.GetterOrgName = getterOrgName;
                Logger.AddInfo("Адрес компании получателя успешно распознан!");

            }
            else
            {
                register.GetterOrgName = null;
                Logger.AddError("Адрес компании получателя не найден!");
            }
            #endregion

            #region Products parsing
            char locationLetter = 'B';
            int locationNumber = 14;
            int productNumber = 1;
            while (!string.IsNullOrEmpty(activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString())))
            {
                var product = new Product();

                #region ConsignmentNoteNumber parsing
                string consignmentNoteNumber = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(consignmentNoteNumber) || string.IsNullOrWhiteSpace(consignmentNoteNumber)))
                {
                    product.ConsignmentNoteNumber = consignmentNoteNumber;
                    Logger.AddInfo("Номер ТТН товара " + productNumber + " успешно распознан!");

                }
                else
                {
                    product.ConsignmentNoteNumber = null;
                    Logger.AddError("Номер ТТН товара " + productNumber + " не найден!");
                }
                #endregion

                locationLetter++;

                #region GettingDate parsing
                var gettingDate = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());

                if (!(string.IsNullOrEmpty(gettingDate) || string.IsNullOrWhiteSpace(gettingDate)))
                {
                    DateTime gettingDateParsed = default(DateTime);
                    if (DateTime.TryParse(gettingDate, out gettingDateParsed))
                    {
                        product.GettingDate = gettingDateParsed;
                        Logger.AddInfo("Дата получения товара " + productNumber + " успешно распознана!");
                    }
                    else
                    {
                        product.GettingDate = null;
                        Logger.AddError("Дата получения товара " + productNumber + " не распознана!");
                    }

                }
                else
                {
                    product.GettingDate = null;
                    Logger.AddError("Дата получения товара " + productNumber + " не найдена!");
                }
                #endregion

                locationLetter++;

                #region Name parsing
                string name = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)))
                {
                    product.Description = name;
                    Logger.AddInfo("Наименование товара " + productNumber + " успешно распознано!");

                }
                else
                {
                    product.Description = null;
                    Logger.AddError("Наименование товара " + productNumber + " не найдено!");
                }
                #endregion

                locationLetter++;

                #region UnitName parsing
                string unitName = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(unitName) || string.IsNullOrWhiteSpace(unitName)))
                {
                    product.UnitName = unitName;
                    Logger.AddInfo("Единица измерения товара " + productNumber + " успешно распознана!");

                }
                else
                {
                    product.UnitName = null;
                    Logger.AddError("Единица измерения товара " + productNumber + " не найдена!");
                }
                #endregion

                locationLetter++;

                #region Amount parsing
                string amount = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(amount) || string.IsNullOrWhiteSpace(amount)))
                {
                    int amountParsed = 0;
                    if (int.TryParse(amount, out amountParsed))
                    {
                        product.Amount = amountParsed;
                        Logger.AddInfo("Количество товара " + productNumber + " успешно распознано!");
                    }
                    else
                    {
                        product.Amount = null;
                        Logger.AddError("Количество товара " + productNumber + " не удалось распознать!");
                    }
                }
                else
                {
                    product.Amount = null;
                    Logger.AddError("Количество товара " + productNumber + " не найдено!");
                }
                #endregion

                locationLetter++;

                #region SellingPrice parsing
                string sellingPrice = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(sellingPrice) || string.IsNullOrWhiteSpace(sellingPrice)))
                {
                    var sellingPriiceObject = Byn.GetInstance(sellingPrice);
                    if (sellingPriiceObject != null)
                    {
                        product.SellingPrice = sellingPriiceObject;
                        Logger.AddError("Отпускная цена товара " + productNumber + " успешно распознана!");
                    }
                    else
                    {
                        product.SellingPrice = null;
                        Logger.AddError("Отпускную цена товара " + productNumber + " не удалось распознать!");
                    }
                }
                else
                {
                    product.SellingPrice = null;
                    Logger.AddError("Отпускная цена товара " + productNumber + " не найдена!");
                }
                #endregion

                locationLetter++;

                #region PercentMarkUp parsing
                string percentMarkUp = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(percentMarkUp) || string.IsNullOrWhiteSpace(percentMarkUp)))
                {
                    decimal percentMarkUpParsed = 0m;

                    if (decimal.TryParse(percentMarkUp
                        .Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out percentMarkUpParsed))
                    {
                        product.PercentMarkUp = percentMarkUpParsed;
                        Logger.AddError("Торговая надбавка % товара " + productNumber + " успешно распознана!");
                    }
                    else
                    {
                        product.PercentMarkUp = null;
                        Logger.AddError("Торговую надбавку % товара " + productNumber + " не удалось распознать!");
                    }
                }
                else
                {
                    product.PercentMarkUp = null;
                    Logger.AddError("Торговая надбавка % товара " + productNumber + " не найдена!");
                }
                #endregion

                locationLetter++;

                #region SumMarkUp parsing
                string sumMarkUp = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(sumMarkUp) || string.IsNullOrWhiteSpace(sumMarkUp)))
                {
                    var sumMarkUpObject = Byn.GetInstance(sumMarkUp);
                    if (sumMarkUpObject != null)
                    {
                        product.SumMarkUp = sumMarkUpObject;
                        Logger.AddError("Торговая надбавка товара " + productNumber + " успешно распознана!");
                    }
                    else
                    {
                        product.SumMarkUp = null;
                        Logger.AddError("Торговую надбавку товара " + productNumber + " не удалось распознать");
                    }
                }
                else
                {
                    product.SumMarkUp = null;
                    Logger.AddError("Торговая надбавка товара " + productNumber + " не найдена!");
                }
                #endregion

                locationLetter++;

                #region ResultPrice parsing
                string resultPrice = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(resultPrice) || string.IsNullOrWhiteSpace(resultPrice)))
                {
                    var resultPriceObject = Byn.GetInstance(resultPrice);
                    if (resultPriceObject != null)
                    {
                        product.ResultPrice = resultPriceObject;
                        Logger.AddError("Розничная цена товара " + productNumber + " успешно распознана!");
                    }
                    else
                    {
                        product.ResultPrice = null;
                        Logger.AddError("Розничную цену товара " + productNumber + " не удалось распознать!");
                    }
                }
                else
                {
                    product.ResultPrice = null;
                    Logger.AddError("Розничная цена товара " + productNumber + " не найдена!");
                }
                #endregion

                locationLetter++;

                #region ResultPriceRounded parsing
                string resultPriceRounded = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(resultPriceRounded) || string.IsNullOrWhiteSpace(resultPriceRounded)))
                {
                    var resultPriceRoundedObject = Byn.GetInstance(resultPrice);
                    if (resultPriceRoundedObject != null)
                    {
                        product.ResultPriceRounded = resultPriceRoundedObject;
                        Logger.AddError("Розничная цена с округлением товара " + productNumber + " успешно распознана!");
                    }
                    else
                    {
                        product.ResultPriceRounded = null;
                        Logger.AddError("Розничную цену с округлением товара " + productNumber + " не удалось распознать!");
                    }
                }
                else
                {
                    product.ResultPriceRounded = null;
                    Logger.AddError("Розничная цена с округлением товара " + productNumber + " не найдена!");
                }
                #endregion

                locationLetter++;

                #region ProducerCountry parsing
                string producerCountry = activeWorksheet.GetValue(locationLetter.ToString() + locationNumber.ToString());
                if (!(string.IsNullOrEmpty(producerCountry) || string.IsNullOrWhiteSpace(producerCountry)))
                {
                    product.ProducerCountry = producerCountry;
                    Logger.AddInfo("Страна-производитель товара " + productNumber + " успешно распознана!");

                }
                else
                {
                    product.ProducerCountry = null;
                    Logger.AddError("Страна-производитель товара " + productNumber + " не найдена!");
                }
                #endregion

                register.Products.Add(product);
                locationNumber++;
                locationLetter = 'B';
                productNumber++;
            }
            #endregion

            return register;
        }

        public void DoSomeWork()
        {
            AddTemplateWorksheet(TemplateType.Template3);
        }

        private Excel.Workbook OpenTemplatesFile(string path)
        {
            var workbook = excelApp.Workbooks.Open(path);
            excelApp.Workbooks["Templates"].Windows[1].Visible = false;
            return workbook;
        }

        private void AddTemplateWorksheet(TemplateType templateType)
        {
            Excel.Workbook templatesWorkbook = OpenTemplatesFile(Constants.PathToTemplates);

            Excel.Worksheet templateWorksheet = templatesWorkbook.Worksheets[templateType.ToString()];

            var worksheetsCount = excelApp.Workbooks[1].Worksheets.Count;
            templateWorksheet.Copy(After: (Excel.Worksheet)excelApp.Workbooks[1].Worksheets[worksheetsCount]); 

            templatesWorkbook.Close(SaveChanges: false);
        }

        private void AddPriceTagsToList(Excel.Worksheet activeWorksheet, TemplateType templateType)
        {
            var register = ParseRegisterData(activeWorksheet);
            tagCollection = new PriceTagCollection();
            register.Products.ForEach(product => tagCollection.Add(new PriceTag(product, templateType)));
        }

        public void AddPriceTagsToListTemplate2(Excel.Worksheet activeWorksheet)
        {
            AddPriceTagsToList(activeWorksheet, TemplateType.Template2);
        }

        public void AddPriceTagsToListTemplate3(Excel.Worksheet activeWorksheet)
        {
            AddPriceTagsToList(activeWorksheet, TemplateType.Template3);
        }

        public void AddPriceTagsToListTemplate5(Excel.Worksheet activeWorksheet)
        {
            AddPriceTagsToList(activeWorksheet, TemplateType.Template5);
        }

    }
}

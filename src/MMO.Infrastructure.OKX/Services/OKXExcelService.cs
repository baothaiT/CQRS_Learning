
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using CQRS.Contract.Share.Static;
using MMO.Application.Abstractions;
using CQRS.Contract.Models.OKX;
using OfficeOpenXml;
using CQRS.Contract.Models.OKX.Builder;
using CQRS.Contract.Enums;

namespace MMO.Infrastructure.OKX.Services;

public class OKXExcelService : IOKXExcelSerivce, IOKXFileService
{
    public string GetFilePath() 
        => Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, "MMO.Infrastructure.OKX", "excelFile");

    public List<OKXExcelModel> Read(string filePath)
    {
        filePath = Path.Combine(filePath, "trading.xlsx");
        // Ensure EPPlus supports non-commercial use
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        // List to store the objects
        List<OKXExcelModel> records = new List<OKXExcelModel>();

        // Load the Excel file
        using (var package = new ExcelPackage(new FileInfo(filePath)))
        {
            // Get the first worksheet in the workbook
            var worksheet = package.Workbook.Worksheets[0];
            int rows = worksheet.Dimension.Rows;    // Total rows
            int cols = worksheet.Dimension.Columns; // Total columns

            // Loop through rows (assuming first row is headers)
            for (int row = 2; row <= rows; row++) // Start at row 2 for data (skip headers)
            {
                string oderTime_Input = worksheet.Cells[row, 2].Text.Replace("\n", " ");
                var oderTime = DateTime.ParseExact(oderTime_Input, Common.DateTimeFormatExcel, CultureInfo.InvariantCulture);

                OKXExcelModel excelModelBuilder = new OKXExcelModelBuilder()
                .SetSymbol(worksheet.Cells[row, 1].Text)
                .SetOrderTime(oderTime)
                .SetSide(worksheet.Cells[row, 3].Text)
                .SetFillAndOrderPrice(worksheet.Cells[row, 4].Text)
                .SetFilledAndTotal(worksheet.Cells[row, 5].Text)
                .SetFilledAndOrderValue(worksheet.Cells[row, 6].Text)
                .SetFee(worksheet.Cells[row, 7].Text)
                .SetTPAndSL(worksheet.Cells[row, 8].Text)
                .Build();

                records.Add(excelModelBuilder); // Add the object to the list
            }
        }
        return records;
    }
    public void Write(List<OKXExcelModel> orders, string filePath)
    {
        filePath = Path.Combine(filePath, "tradingWrite.xlsx");
        // Ensure EPPlus license context is set for non-commercial use
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        // Create a new Excel package
        using (var package = new ExcelPackage())
        {
            // Add a worksheet
            var worksheet = package.Workbook.Worksheets.Add("Orders");

            // Add header row
            worksheet.Cells[1, 1].Value = "Symbol_Prefix";
            worksheet.Cells[1, 2].Value = "Symbol_Suffix";
            worksheet.Cells[1, 3].Value = "Order Time";
            worksheet.Cells[1, 4].Value = "Side";
            worksheet.Cells[1, 5].Value = "FillAndOrderPrice_Prefix";
            worksheet.Cells[1, 6].Value = "FillAndOrderPrice_Suffix";
            worksheet.Cells[1, 7].Value = "Filled and Total Prefix Value";
            worksheet.Cells[1, 8].Value = "Filled and Total Prefix Symbol ";
            worksheet.Cells[1, 9].Value = "Filled and Total Suffix Value";
            worksheet.Cells[1, 10].Value = "Filled and Total Suffix Symbol ";
            worksheet.Cells[1, 11].Value = "Filled and Order Value Prefix";
            worksheet.Cells[1, 12].Value = "Fee";
            worksheet.Cells[1, 13].Value = "TP and SL";

            // Add data rows
            for (int i = 0; i < orders.Count; i++)
            {
                var order = orders[i];
                worksheet.Cells[i + 2, 1].Value = order.Symbol_Prefix;
                worksheet.Cells[i + 2, 2].Value = order.Symbol_Suffix;
                worksheet.Cells[i + 2, 3].Value = order.OrderTime.ToString("dd/MM/yyyy HH:mm:ss");
                worksheet.Cells[i + 2, 4].Value = order.Side;
                worksheet.Cells[i + 2, 5].Value = order.FillAndOrderPrice_Prefix;
                worksheet.Cells[i + 2, 6].Value = order.FillAndOrderPrice_Suffix.ToString();
                worksheet.Cells[i + 2, 7].Value = order.FilledAndTotal_Prefix_Value;
                worksheet.Cells[i + 2, 8].Value = order.FilledAndTotal_Prefix_Symbol;
                worksheet.Cells[i + 2, 9].Value = order.FilledAndTotal_Suffix_Value;
                worksheet.Cells[i + 2, 10].Value = order.FilledAndTotal_Suffix_Symbol;
                worksheet.Cells[i + 2, 11].Value = order.FilledAndOrderValue_Prefix;
                worksheet.Cells[i + 2, 12].Value = order.Fee;
                worksheet.Cells[i + 2, 13].Value = order.TPAndSL;
            }
            worksheet.Cells.AutoFitColumns();
            // Save the Excel file
            package.SaveAs(new FileInfo(filePath));
        }
    }

    public void ReadAndWriteNewExcel()
    {
        var targetDirectory = GetFilePath();

        var excelData = Read(targetDirectory);

        Write(excelData.Where(x => x.Symbol_Prefix == SymbolCoinEnums.DOGE).ToList(), targetDirectory);

        //var profit = _tradingService.CaculatorProfit(
        //    excelData.Where(x => x.Side == TypeSideEnum.BUY && x.Symbol_Prefix == SymbolCoinEnums.DOGE).ToList(),
        //    excelData.Where(x => x.Side == TypeSideEnum.SELL && x.Symbol_Prefix == SymbolCoinEnums.DOGE).ToList()
        //);

        var buyExcel = excelData.Where(x => x.Side == TypeSideEnum.BUY && x.Symbol_Prefix == SymbolCoinEnums.DOGE).ToList();

        foreach (var itemBuy in buyExcel)
        {
            Console.WriteLine($"Symbol_Prefix {itemBuy.Symbol_Prefix};");
            Console.WriteLine($"Symbol_Suffix {itemBuy.Symbol_Suffix};");
            Console.WriteLine($"Order Time {itemBuy.OrderTime};");
            Console.WriteLine($"Side {itemBuy.Side};");
            Console.WriteLine($"FillAndOrderPrice_Prefix {itemBuy.FillAndOrderPrice_Prefix};");
            Console.WriteLine($"FillAndOrderPrice_Suffix {itemBuy.FillAndOrderPrice_Suffix};");
            Console.WriteLine($"Filled and Total Prefix Value {itemBuy.FilledAndTotal_Prefix_Value};");
            Console.WriteLine($"Filled and Total Prefix Symbol  {itemBuy.FilledAndTotal_Prefix_Symbol};");
            Console.WriteLine($"Filled and Total Suffix Value  {itemBuy.FilledAndTotal_Suffix_Value};");
            Console.WriteLine($"Filled and Total Suffix Symbol   {itemBuy.FilledAndTotal_Suffix_Symbol};");
            Console.WriteLine($"Filled and Order Value Prefix   {itemBuy.FilledAndOrderValue_Prefix};");
            Console.WriteLine($"Fee   {itemBuy.Fee};");
            Console.WriteLine("--------------------------");
        }

        Console.WriteLine("--------------------------");
        Console.WriteLine("--------------------------");
    }
}
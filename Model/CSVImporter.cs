using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.OData.Edm;

namespace LINQStockPrice.Model
{
    class CSVImporter
    {
        static void Import(string[] args)
        {
            var stocks = ProcessCSV("ATX.csv");

            static List<Stock> ProcessCSV(string path)
            {
                return File.ReadAllLines(path)
                    .Skip(1)
                    .Where(row => row.Length > 0)
                    .Select(Stock.ParseRow).ToList();
            };
        }
    }
}

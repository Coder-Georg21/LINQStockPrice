using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace LINQStockPrice.Model
{
    class CSVImporter
    {

        var cs = from l in File.ReadAllLines(ATX).Skip(1)
                 let x = l.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(s => s)
                 select new ListOfStocks
                 {
                     Date = x.ElementAt(0),
                     Open = double.Parse(x.ElementAt(1), System.Globalization.CultureInfo.InvariantCulture),
                     High = x.ElementAt(2),
                     Low = x.ElementAt(3),
                     ChgP = x.ElementAt(4),
                 };

    }
}

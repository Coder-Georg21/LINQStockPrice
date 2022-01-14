using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStockPrice.Model
{
    class Stock
    { 
        public DateTime Date { get; set; }  
        public int Open { get; set; }
        public int High { get; set;}
        public int Low { get; set;}

        internal static Stock ParseRow(string row)
        {
            var columns = row.Split(';');
            return new Stock()
            {
                Date = DateTime.Parse(columns[0]),
                Open = int.Parse(columns[1]),
                High = int.Parse(columns[2]),
                Low = int.Parse(columns[3])
            };
        }

    }
}

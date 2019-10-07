using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.DataModel
{
    public class StockData
    {
        public string StockID { get; set; }
        public string Currency { get; set; }
        public double OpenPrice { get; set; }
        public double ClosePrice { get; set; }
    }
}
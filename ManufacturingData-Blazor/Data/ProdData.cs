using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ManufacturingData_Blazor.Data
{
    public class ProdData
    {
        public int SFCID { get; set; }
        public string SFC { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public double Quantity { get; set; }
        public string OrderType { get; set; }
    }
}

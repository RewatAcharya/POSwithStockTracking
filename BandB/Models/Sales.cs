using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandB.Models
{
    internal class Sales
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PartName { get; set; }
        public string PartNo { get; set; }
        public int Stock { get; set; }
        public decimal TotaPrice { get; set;}
        public decimal PricePerPiece { get; set; }
        public decimal Price { get; set;}
        public decimal Discount { get;set;}
    }
}

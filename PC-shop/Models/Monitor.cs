using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC_shop.Models
{
    public class Monitor: IProduct
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Size { get; set; } //
        public int Frequency { get; set; } //
        public string Resolution { get; set; } //
        public string MatrixType { get; set; } //
        public string AspectRatio { get; set; } //
        public int Price { get; set; }
        public string Make { get; set; }
        public string Images { get; set; }
    }
}

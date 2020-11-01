using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC_shop.Models
{
    public class Ssd : IProduct
    {
        public int Id { get; set; }//
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Make { get; set; } // intel or samsung
        public int ReadSpeed { get; set; }
        public int WriteSpeed { get; set; }
        public int Capacity { get; set; }
        public string Images { get; set; }//
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace PC_shop.Models
{
    public class Cpu : IProduct
    {
        public int Id { get; set; }//
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Make { get; set; } // intel or amd
        public int CountOfCores { get; set; }//
        public int CountOfThreads { get; set; }//
        public string Graphics { get; set; }//
        public int TechProcess { get; set; }//
        public string Images { get; set; }//
    }
}

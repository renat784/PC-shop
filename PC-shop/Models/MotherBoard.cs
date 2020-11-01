using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC_shop.Models
{
    public class MotherBoard: IProduct
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public string Socket { get; set; }
        public string FormFactor { get; set; }
        public string MemorySupport { get; set; }

        public bool IntegratedVideoCard { get; set; }
        public string VideoExit { get; set; }
        public int Price { get; set; }
        public string Make { get; set; }
        public string Images { get; set; }
    }
}

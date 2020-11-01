using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC_shop.Models
{
    public class Keyboard : IProduct
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Interface { get; set; }
        public string ConnectionType { get; set; }
        public int Price { get; set; }
        public string Make { get; set; }
        public string Images { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC_shop.Models
{
    public class VideoCard: IProduct
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int MemorySize { get; set; }
        public string MemoryType { get; set; }
        public string Purpose { get; set; }
        public int Price { get; set; }
        public string Make { get; set; }
        public string Images { get; set; }
    }
}

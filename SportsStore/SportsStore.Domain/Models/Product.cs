using System;
using System.Collections.Generic;

namespace SportsStore.Domain.Models
{
    public partial class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}

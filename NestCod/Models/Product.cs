using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestCod.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Descirption { get; set; }
        public int Rating { get; set; }
        public int CategoryId { get; set; }
        public Catecori Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}

using NestCod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestCod.ViewModels
{
    public class HomeVm
    {
        public List<Sliders> Sliders { get; set; }
        public List<Catecori> Catecori { get; set; }
        public List<Product> Product { get; set; }
        public List<ProductImage> ProductImage { get; set; }
    }
}

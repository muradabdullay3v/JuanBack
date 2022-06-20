using JuanFronttoEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.ViewModels
{
    public class ShopViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Color> Colors { get; set; }
        public List<Size> Sizes { get; set; }
    }
}

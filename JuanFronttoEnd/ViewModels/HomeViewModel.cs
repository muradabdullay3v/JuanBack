using JuanFronttoEnd.Models;
using System.Collections.Generic;

namespace JuanFronttoEnd.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Setting> Settings { get; set; }
    }
}

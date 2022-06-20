using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public int Count{ get; set; }
        public bool inStock { get; set; }
        public bool isNew { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        [NotMapped]
        public ICollection<Category> Categories { get; set; }
    }
}

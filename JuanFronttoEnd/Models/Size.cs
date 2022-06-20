using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuanFronttoEnd.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }
        public int ProductCount { get; set; }
        [NotMapped]
        public ICollection<Product> Products { get; set; }
    }
}

﻿namespace JuanFronttoEnd.Models
{
    public class ColorProduct
    {
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

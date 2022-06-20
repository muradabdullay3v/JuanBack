using JuanFronttoEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.DAL
{
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<ProductImage> ProductImages { get; set; }
            public DbSet<CategoryProduct> CategoryProducts { get; set; }
            public DbSet<Color> Colors { get; set; }
            public DbSet<ColorProduct> ColorProducts { get; set; }
            public DbSet<Size> Sizes { get; set; }
            public DbSet<SizeProduct> SizeProducts { get; set; }
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryProduct>(builder =>
               {
                builder.HasNoKey();
                builder.ToTable("CategoryProducts");
                 });
            modelBuilder.Entity<ColorProduct>(builder =>
            {
                builder.HasNoKey();
                builder.ToTable("ColorProducts");
            });
            modelBuilder.Entity<SizeProduct>(builder =>
            {
                builder.HasNoKey();
                builder.ToTable("SizeProducts");
            });
        }
    }

}

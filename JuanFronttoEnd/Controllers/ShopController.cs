using JuanFronttoEnd.DAL;
using JuanFronttoEnd.Models;
using JuanFronttoEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.Controllers
{
    public class ShopController : Controller
    {
        public AppDbContext _context { get; }
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int pending=1)
        {
            List <Product> ShopProducts = _context.Products.Where(c => !c.isDeleted).Where(c => !c.isNew).ToList();
            const int pages = 8;
            if (pending < 1)
            {
                pending = 1;
            }
            int productCount = ShopProducts.Count();
            Pagination pagination = new Pagination(productCount, pending, pages);
            int skip = pages * (pending - 1);
            List<Product> shopProducts = ShopProducts.Skip(skip).Take(pagination.PageSize).ToList();
            this.ViewBag.Pagination = pagination;
            ShopViewModel shop = new ShopViewModel
            {
                Products = shopProducts,
                Categories = _context.Categories.Where(c => !c.isDeleted).ToList(),
                ProductImages = _context.ProductImages.ToList(),
                Colors = _context.Colors.Where(c => !c.isDeleted).ToList(),
                Sizes = _context.Sizes.Where(c => !c.isDeleted).ToList(),
            };
            return View(shop);
        }
        public IActionResult Load()
        {
            List<Product> ShopProducts = _context.Products.OrderByDescending(pr => pr.Id).Skip(4).Take(4).ToList();
            return PartialView("_ProductPartial",ShopProducts);
        }

    }
}

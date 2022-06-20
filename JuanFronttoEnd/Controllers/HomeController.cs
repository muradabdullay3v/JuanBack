using JuanFronttoEnd.DAL;
using JuanFronttoEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                Products = _context.Products.Where(c => !c.isDeleted).Where(c => !c.isNew).ToList(),
                ProductImages = _context.ProductImages.ToList(),
                Blogs = _context.Blogs.ToList(),
                Brands = _context.Brands.Where(c => c.IsActive).ToList(),
                Settings = _context.Settings.ToList(),
            };
            return View(home);
        }
    }
}

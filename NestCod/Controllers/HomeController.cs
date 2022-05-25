using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestCod.DAL;
using NestCod.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestCod.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVm homeVM = new HomeVm()
            {

                Sliders = await _context.Sliders.ToListAsync(),
                Catecori = await _context.Categories.ToListAsync(),
                Product = await _context.Products.Include(p => p.ProductImages).Include(p => p.Category).Take(10).ToListAsync()
            };

            return View(homeVM);
        }
    }
}

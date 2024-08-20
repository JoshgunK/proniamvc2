﻿using Microsoft.AspNetCore.Mvc;
using ProniaMVC.DAL;

namespace ProniaMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

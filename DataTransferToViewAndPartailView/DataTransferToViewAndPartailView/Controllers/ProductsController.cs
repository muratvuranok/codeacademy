﻿using Microsoft.AspNetCore.Mvc;

namespace DataTransferToViewAndPartailView.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

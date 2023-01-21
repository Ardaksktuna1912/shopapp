using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
using shopapp.webui.Models;
using shopapp.webui.WievModels;
using System;
using System.Collections.Generic;

namespace shopapp.webui.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
         
            var ProductvievModels = new ProductWievModels()
            {
                
                Products =ProductRepository.Products
            };


            return View(ProductvievModels);

        }
        public IActionResult About() { return View(); }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shopapp.webui.Data;
using shopapp.webui.Models;
using shopapp.webui.WievModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
       
        public IActionResult Listcs(int? id, string q)
        {
            Console.WriteLine(q);
           var products = ProductRepository.Products;
            if (id!=null)
            {
                products=products.Where(p=>p.CategoryID==id).ToList();
            }
            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i=>i.Name.ToLower().Contains(q.ToLower())).ToList();
            }

            var ProductvievModels = new ProductWievModels()
            {

                Products = products
            };


            return View(ProductvievModels); 
        }
        public IActionResult Details(int id) 
        {
          
            return View(ProductRepository.GetProductByID(id));

        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = new SelectList(CategoryRepository.Categories, "CatId", "Name");
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product p) 
        {

            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(p);
                return RedirectToAction("listcs"); 
            }
            return View(p);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Category = new SelectList(CategoryRepository.Categories, "CatId", "Name");
            return View(ProductRepository.GetProductByID(id));
        }

        [HttpPost]
        public IActionResult Edit(Product p) 
        {
            ProductRepository.EditProduct(p);
            return RedirectToAction("listcs");
        }




        [HttpPost]
        public IActionResult Delete(int ProductID) 
        {
            ProductRepository.Deleteproduct(ProductID);
            return RedirectToAction("listcs");
        }
    }
}

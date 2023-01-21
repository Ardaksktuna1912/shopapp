using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;
using System.Collections.Generic;
using System.Linq;

namespace shopapp.webui.Data
{
    public class ProductRepository
    {
        private static List<Product> _product = null;

        static ProductRepository()
        {
            _product = new List<Product>()
            {
                new Product{ProductID=1,Name="Samsung S7",Price=29823,Description="Sağlam Telefon",IsApproved=true,ImageUrl="2.jpg",CategoryID=1},
                new Product{ProductID=2,Name="Iphone X",Price=16523,Description="Ayrıcalıklı Telefon",IsApproved=true,ImageUrl="1.jpg",CategoryID=1},
                new Product{ProductID=3,Name="Nokia 3310",Price=2982365,Description="Telefon",IsApproved=true,ImageUrl="3.jpg", CategoryID = 1},
                new Product{ProductID=4,Name="Xiaomi",Price=2955,Description="Düz Telefon",IsApproved=true,ImageUrl="4.jpg", CategoryID = 1},
                new Product{ProductID=5,Name="Dell Inspiron",Price=29823,Description="Sağlam Bilgisayar",IsApproved=true,ImageUrl="5.jpg",CategoryID=2},
                new Product{ProductID=6,Name="Lenovo J9",Price=16523,Description="Ayrıcalıklı Bilgisayar",IsApproved=true,ImageUrl="6.jpg",CategoryID=2},
                new Product{ProductID=7,Name="MacBook M2",Price=2982365,Description="Bilgisayar",IsApproved=true,ImageUrl="7.jpg", CategoryID = 2},
               
            };
        }
        public static List<Product> Products
        {
            get { return _product; }
        }
        public static void AddProduct(Product pro)
        {
            _product.Add(pro);
        }

        public static Product GetProductByID(int id)
        {
            return _product.FirstOrDefault(p => p.ProductID == id);
        }

        public static void EditProduct(Product pro) 
        {
            foreach (var p in _product)
            {
                if (p.ProductID==pro.ProductID)
                {
                    p.Name = pro.Name;
                    p.Price = pro.Price;
                    p.ImageUrl = pro.ImageUrl;
                    p.IsApproved = pro.IsApproved;
                    p.CategoryID = pro.CategoryID;
                }
            }
        }

        
        public static void Deleteproduct(int id) 
        {
            var product = GetProductByID(id);
            if (product!=null)
            {
                _product.Remove(product);
            }
        }
    }
}

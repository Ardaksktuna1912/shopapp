using shopapp.webui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace shopapp.webui.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {

                new Category {CatId=1,Name="Telefon",Description="Telefon Kategorisi" },
                new Category {CatId=2,Name="Bilgisayar",Description="Bilgisayar Kategorisi" },
                new Category {CatId=3,Name="Elektronik",Description="Elektronik Kategorisi" },
                new Category {CatId=4,Name="Kitap",Description="Kitap Kategorisi" }



            };
        }

        public static List<Category> Categories
        {
            get { return _categories; }
        }
        public static void AddCatgory(Category cat)
        {
            _categories.Add(cat);
        }

        public static Category GetCatgoryByID(int id)
        {
            return _categories.FirstOrDefault(c => c.CatId == id);
        }
    }
}   


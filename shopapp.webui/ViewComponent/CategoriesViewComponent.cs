using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
using shopapp.webui.Models;
using System.Collections.Generic;

namespace shopapp.webui.WievCompenent
{
   
    public class CategoriesViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
		
			ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.WebApp.Models.Entity;

namespace Task.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        
        TaskEntities db = new TaskEntities();
        // GET: Category
        public ActionResult GetCategory()
        {            
                var categories = db.Category.ToList();

                return View(categories);           
        }
        
    }
}

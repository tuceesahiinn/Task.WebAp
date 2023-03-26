using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.WebApp.Models.Entity;

namespace Task.WebApp.Controllers
{
    public class ProductController : Controller
    {
       TaskEntities db = new TaskEntities();

        // GET: Product
        public ActionResult GetProduct()
        {
            var products = db.Product.ToList();

            return View(products);
        }
        //GET: Product details
        public ActionResult GetProductDetail(int id)
        {
            var productDetail = db.Product.Where(x => x.Id == id).FirstOrDefault();

            return View("GetProductDetail", productDetail);
        }
        // GET: New Products
        public ActionResult GetNewProduct()
        {
            List<Product> newProducts = db.Product.Where(p => p.IsNew == true).ToList();

            return PartialView("_NewProductList", newProducts);
        }
    }
}
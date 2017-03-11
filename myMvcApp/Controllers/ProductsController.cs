using myMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
namespace myMvcApp.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Products
        public ActionResult Index(string search,int? page)
        {
            int pageNumber = page ?? 1;
            var products = _db.Products.ToList();
            if (!String.IsNullOrWhiteSpace(search))
            {
                 products = _db.Products.Where(p => p.Name.Contains(search)).ToPagedList(pageNumber, 2).ToList();
            }
            
            return View(products.ToPagedList(pageNumber,2));
        }

        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(new Product {Name= product.Name,Descrption=product.Descrption,Price=product.Price,DateAdded=DateTime.Now});
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        // edit
        //details
        //delete
    }
}
using CoffeeOnlineSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeOnlineSystem.Controllers
{
    public class SearchController : Controller
    {
        COFFEEEntitiesss db = new COFFEEEntitiesss();
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SearchResult(FormCollection f, int? page)
        {
            searchdao searchDao = new searchdao();
            ViewBag.Products = db.Products.ToList();
            ViewBag.Categories = db.Categories.Take(5).ToList();
            string searchString = f["txtSearch"].ToString();
            if (searchString == "")
            {
                return RedirectToAction("Home", "Home");
            }
            string lbgroup = f["lbgroup"].ToString();
            List<Product> lstProduct = new List<Product>();
            if (lbgroup == "0")
            {
                lstProduct = searchDao.searchAll(searchString);
            }
            else if (lbgroup == "1")
            {
                lstProduct = searchDao.searchProduct(searchString);
            }
            else if (lbgroup == "3")
            {
                lstProduct = searchDao.searchCategory(searchString);
            }
            else
            {
                return RedirectToAction("searchNull");
            }

            ViewBag.searchString = searchString;

            if (lstProduct.Count() == 0)
            {
                return RedirectToAction("searchNull");
            }

            ViewBag.result = lstProduct.Count() + " items matched your search for " + searchString;

            return View(lstProduct.OrderBy(p => p.price));
        }

        public ViewResult searchNull()
        {
            ViewBag.Products = db.Products.ToList();
            ViewBag.Categories = db.Categories.Take(5).ToList();
            return View();
        }
    }
}
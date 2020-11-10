using CoffeeOnlineSystem.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASM_C.Controllers
{
    public class HomePageController : Controller
    {
        public ActionResult Home()
        {
            /* using (SINH_VIENEntities diemSV = new SINH_VIENEntities())
             {
                 return View(diemSV.DiemSVs.ToList());
             }*/
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

    }
}
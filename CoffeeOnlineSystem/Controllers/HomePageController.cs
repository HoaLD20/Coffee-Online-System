using CoffeeOnlineSystem.DAO;
using CoffeeOnlineSystem.Models;
using System;
using System.Text;
using System.Web.Mvc;
namespace ASM_C.Controllers
{

    public class HomePageController : Controller
    {
        private object f;

        public ActionResult Home()
        {
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
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult ChangeInfor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account account)
        {
            CustomerDao customerDao = new CustomerDao();
            string acc = customerDao.LoginCustomer(account.username, account.password);
            if (acc != null)
            {
                Session["login"] = "check";
                return RedirectToAction("Home", "HomePage");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is not correct.");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Register(AccountandCustomer accountandCustomer,FormCollection f)
        {
            CustomerDao customerDao = new CustomerDao();
            Account acc = accountandCustomer.Account;
            Customer customer = accountandCustomer.Customer;
            customer.DOBCus = DateTime.ParseExact(f["DOB"], "yyyy-MM-dd", null); ;
            customer.usernameCus = acc.username;
            customer.genderCus = f["gender"].ToString();
            customer.statusCus = 1;
            int i = customerDao.Register(customer, acc);

            return RedirectToAction("Login", "HomePage");
        }
        public ActionResult Menu()
        {
            ProductDao productDaoDao = new ProductDao();

            var Products = productDaoDao.GetProducts();
            return View(Products);
        }

        
    }
}
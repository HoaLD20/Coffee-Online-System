using CoffeeOnlineSystem.DAO;
using CoffeeOnlineSystem.Models;
using System;
using System.Collections;
using System.Text;
using System.Web.Mvc;
namespace ASM_C.Controllers
{

    public class HomePageController : Controller
    {
        Hashtable ShoppingCart = new Hashtable();
        private object f;

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Productinfo()
        {
            return View();
        }
        public ActionResult Checkout()
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
            acc.password = f["txtpassword"].ToString();
            string txtconfpassword = f["txtconpassword"].ToString();
            if (acc.password.CompareTo(txtconfpassword) == 0)
            {
                customer.genderCus = f["txtgender"].ToString();
                customer.emailCus = f["txtemail"].ToString();
                customer.statusCus = 1;
                int i = customerDao.Register(customer, acc);
                Console.WriteLine(i);
                if (i != 0)
                {
                    return RedirectToAction("Login", "HomePage");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is not correct.");
                }
            }
            else ModelState.AddModelError("", "Password and Confirm Password not match");
            return View();
        }
        public ActionResult Menu()
        {

            ProductDao productDaoDao = new ProductDao();

            var Products = productDaoDao.GetProducts();
            return View(Products);
        }

        
    }
}
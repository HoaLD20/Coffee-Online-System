using CoffeeOnlineSystem.DAO;
using CoffeeOnlineSystem.Models;
using System.Text;
using System.Web.Mvc;
namespace ASM_C.Controllers
{

    public class HomePageController : Controller
    {
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
        public ActionResult Register(AccountandCustomer accountandCustomer)
        {
            CustomerDao customerDao = new CustomerDao();
            Account acc = accountandCustomer.Account;
            Customer customer = accountandCustomer.Customer;
            customer.usernameCus = acc.username;
            customer.statusCus = 1;
            int i = customerDao.Register(customer, acc);

            return RedirectToAction("Login", "HomePage");
        }
        public ActionResult Menu()
        {
            return View();
        }

        
    }
}
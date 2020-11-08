using CoffeeOnlineSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeOnlineSystem.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult IndexEmp(string strSearch)
        {
            employeeList stu = new employeeList();
            List<account> obj = stu.getEmployee(null);
            if (!string.IsNullOrEmpty(strSearch))
            {
                obj = obj.Where(x => x.Fullname.Contains(strSearch)).ToList();
            }
            ViewBag.StrSearch = strSearch;
            return View(obj);
        }

        // GET: products/Details/5
        public ActionResult Detail(int id)
        {
            employeeList stu = new employeeList();
            List<account> obj = stu.getEmployee(id);
            return View(obj.FirstOrDefault());
        }

        // GET: products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: products/Create
        [HttpPost]
        public ActionResult Create(account emp)
        {
            if (ModelState.IsValid)
            {
                employeeList empList = new employeeList();
                empList.addEmp(emp);
                return RedirectToAction("IndexEmp");
            }
            return View();
        }

        // GET: products/Edit/5
        public ActionResult Edit(int id)
        {
            employeeList stu = new employeeList();
            List<account> obj = stu.getEmployee(id);
            return View(obj.FirstOrDefault());//chi laay 1 san pham thoi
        }

        // POST: products/Edit/5
        [HttpPost]
        public ActionResult Edit(account emp)
        {
            if (ModelState.IsValid)
            {
                employeeList empList = new employeeList();
                empList.update(emp);
                return RedirectToAction("IndexEmp");
            }

            return View();
        }
        // GET: products/Delete/5
        public ActionResult Delete(int id)
        {
            customertList proList = new customertList();
            proList.delete(id);
            return RedirectToAction("IndexEmp");
        }


    }
}
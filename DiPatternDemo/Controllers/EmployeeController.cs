using DiPatternDemo.Models;
using DiPatternDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiPatternDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices service;
        public EmployeeController(IEmployeeServices service)
        {
            this.service = service;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var model = service.GetEmployees();
            return View(model);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var employee = service.GetEmployee(id);
            return View(employee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {
                var result = service.AddEmployee(emp);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "Something went wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }

        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var employee=service.GetEmployee(id);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            try
            {
                var result = service.UpdateEmployee(emp);
                if (result >= 1)
                {

                return RedirectToAction(nameof(Index));
                }
                else
                {

                    ViewBag.Error = "Something went wrong";
                    return View();
                }
            }
            catch(Exception ex)
            {
                ViewBag.Error=ex.Message;
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var employee=service.GetEmployee(id);
            return View(employee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                var result=service.DeleteEmployee(id);
                if (result >= 1)
                {

                return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "Something went wrong";
                    return View();
                }
            }
            catch(Exception ex)
            {
                ViewBag.Error=ex.Message;
                return View();
            }
        }
    }
}

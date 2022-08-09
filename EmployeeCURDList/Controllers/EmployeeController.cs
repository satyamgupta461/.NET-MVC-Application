using EmployeeCURDList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Concurrent;
using System.Linq;


namespace EmployeeCURDList.Controllers
{
    public class EmployeeController : Controller
    {
        private MyDbContext myDbContext;

        public EmployeeController(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }
         





        //private static List<Employee> employees = new List<Employee>
        //{
        //    new Employee{Id=1,Name="Satyam",Email="satyam@gmail.com",Dob=new DateTime(1999,02,17),Address="Civil Lines",PhoneNumber=9889390036,City="Gorakhpur"},
        //    new Employee{Id=2,Name="Anshuman",Email="anshuman@gmail.com",Dob=new DateTime(2000,12,16),Address="Golghar",PhoneNumber=9839162289,City="Kanpur"},
        //    new Employee{Id=3,Name="Chirag",Email="chirag@gmail.com",Dob=new DateTime(2000,08,29),Address="Airport Colony",PhoneNumber=7007674560,City="Allahabad"},
        //    new Employee{Id=4,Name="Abhijeet",Email="abhijeet@gmail.com",Dob=new DateTime(2000,02,12),Address="Awaas Vikas Colony",PhoneNumber=8852158488,City="Banaras"},
        //    new Employee{Id=5,Name="Arpit",Email="arpit@gmail.com",Dob=new DateTime(2001,04,14),Address="Hindalco Colony",PhoneNumber=9852234874,City="Renukut"}
        //};
        public IActionResult List()
        {
            return View(myDbContext.Employee.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            myDbContext.Employee.Add(employee);
            myDbContext.SaveChanges();
            return RedirectToAction("List",myDbContext.Employee);
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var employee = myDbContext.Employee.Where(e => e.Id == id).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]

        //public IActionResult Edit(Employee employee)
        //{
        //    var employeeToEdit = employees.Find(e => e.Id == employee.Id);
        //    employeeToEdit.
        //    return RedirectToAction("List");
        //}

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            myDbContext.Employee.Update(employee);
            myDbContext.SaveChanges();
            //return View("List",myDbContext.Employee);


            //var employeeToUpdate = employees.Find(e => e.Id == employee.Id);
            //employeeToUpdate.Name = employee.Name;
            //employeeToUpdate.Email = employee.Email;
            //employeeToUpdate.Dob = employee.Dob;
            //employeeToUpdate.Address = employee.Address;
            //employeeToUpdate.PhoneNumber = employee.PhoneNumber;
            //employeeToUpdate.City = employee.City;

            return RedirectToAction("List");
        }
        [HttpGet]

        public IActionResult Delete(int id)
        {
            var employee = myDbContext.Employee.Where(e => e.Id == id).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]

        public ActionResult Delete(Employee employee)
        {
            //var employeeToDelete = myDbContext.Employee.Where(e => e.Id == employee.Id);
            myDbContext.Employee.Remove(employee);
            myDbContext.SaveChanges();
            return View("List", myDbContext.Employee);
        }
    }   
}

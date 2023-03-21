using Microsoft.AspNetCore.Mvc;
using Database;
using MongoDB.Bson.IO;
using System;

namespace CompanyPage.Controllers
{
    public class EmployeeController : Controller
    {
        public async Task<IActionResult> Index()
        {


           MongoDb db = new MongoDb();

           
            var employees = await db.GetEmployees();
            return View(employees);
          
        }

        public async Task<IActionResult> Details()
        {
        
            return View();
        }

      

     

    }
}

using Microsoft.AspNetCore.Mvc;
using Database;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;
using CompanyPage.Models;

namespace CompanyPage.Controllers
{
    public class ContactController : Controller
    {
        public async Task<IActionResult> Index()

        {
            MongoDb db = new MongoDb();
            ViewBag.ContactSuccess = Request.Query["contact"] == "success";
          
            var contacts = await db.GetContacts();
         return View(contacts);  

        }
    
        public ActionResult Map() { 
            return View();  
        }



        public async Task<IActionResult> PostContactAsync(Contact contact)
        {
            var db = new MongoDb();
            await db.SaveContact(contact);
            return Redirect("/Contact?contact=success");
        }
       
    }
}

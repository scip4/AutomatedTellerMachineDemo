using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;


namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //Get Home/Index
        public IActionResult Index()
        {
            return View();
        }
        //Get Home/About
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your Contact page";
            ViewBag.TheMessage = "Having trouble? Send us a Message.";
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string Message)
        {
            ViewData["Message"] =  Message;
            ViewBag.TheMessage = "Message recivied";
            return View();
        }
        public IActionResult Foo()
        {
            return View("Foo");
        }
        /*public JsonResult Jt()
        {
            return JSON(new {name"test", value="jump"}, JsonRequestBehavior.AllowGet)
        }*/
        public IActionResult Serial(string lettercase)
        {
             var serial = "TESTING OUT MY FIRST EDIT OF A CONTROLLER";
                if (lettercase == "lower") {
                    return Content(serial.ToLower() + " " + lettercase);
                } 
                //return new JsonResult({name="serial", value=serial}, JsonRequestBehavior.AllowGet);
                return Content(serial + " "+ "dfvfv");
                //Microsoft.AspNet.Mvc.JsonRequestBehavior.AllowGet;
                //return JSON(new {name="serial", value=serial}, JsonRequestBehavior.AllowGet);
        
        //return JSON(new {name="serial", value=serial}, JsonRequestBehavior.AllowGet);
        //return Content(serial);
        }

        

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}

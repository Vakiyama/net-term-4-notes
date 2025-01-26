using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class HomeController : Controller
    {       
        

        // GET: Home
        public ViewResult Index()
        {
            //string name = "Sweet Home";
            ViewData["name"] = "Sweet Home";

            ViewData["furnitures"]= new List<string>()
            {
                "Couch",
                "TV",
                "Fridge",
                "Diswasher"
            };

            return View();
        }
    }
}
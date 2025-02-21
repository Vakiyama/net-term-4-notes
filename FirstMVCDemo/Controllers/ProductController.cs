using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCDemo.Models;

namespace FirstMVCDemo.Controllers
{
    public class ProductController : Controller
    {
              private readonly AppDbContext _context;
               // Inject the DbContext via constructor
        public ProductController(AppDbContext context)
        {
            _context = context;
        }


        // GET: Product
        public JsonResult ProductData()
        {
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}

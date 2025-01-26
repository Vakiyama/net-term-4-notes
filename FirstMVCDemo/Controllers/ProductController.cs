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
        List<Products> products = new List<Products>()
        {
            new Products{Id= 1, Name="Samsung", Description="TV"},
            new Products{Id=2, Name="Nike", Description="Shoe"},
            new Products{Id=3, Name="Cat", Description="Jacket"}
        };

        // GET: Product
        public JsonResult ProductData()
        {
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}
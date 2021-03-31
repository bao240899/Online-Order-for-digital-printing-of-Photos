using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Order_for_digital_printing_of_Photos.Areas.Cart.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart/
        public ActionResult Cart()
        {
            return View();
        }

        //cart/checkout
        public ActionResult Checkout()
        {
            return View();
        }
    }
}
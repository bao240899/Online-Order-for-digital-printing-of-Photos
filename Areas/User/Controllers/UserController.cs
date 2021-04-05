using Online_Order_for_digital_printing_of_Photos.Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Order_for_digital_printing_of_Photos.Areas.User.Controllers
{
    public class UserController : Controller
    {
        // GET: User/User
        
        public new ActionResult Profile(int id)
        {
            var model = new UserDao().GetById(id);
            return View(model);
        }
    }
}
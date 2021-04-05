using Online_Order_for_digital_printing_of_Photos.Models.Dao;
using Online_Order_for_digital_printing_of_Photos.Common;
using Online_Order_for_digital_printing_of_Photos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Order_for_digital_printing_of_Photos.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        // GET: User/Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var res = dao.Login(model.userName, model.userPwd);
                if (res == 1)
                {
                    var user = dao.GetByUser(model.userName);
                    //var stt = dao.GetByIdd(user.userID);
                    if (user.role == "user")
                    {
                        var userSession = new UserLogin();
                        userSession.userID = user.userID;
                        userSession.userName = user.userName;
                        userSession.userPwd = user.userPwd;
                        userSession.role = user.role;
                        userSession.name = user.name;
                        Session.Add(CommonConstant.USER_SESSION, userSession);
                        return RedirectToAction("Index", "Home");
                    }
                    else if (user.role == "admin")
                    {
                        var userSession = new UserLogin();
                        userSession.userID = user.userID;
                        userSession.userName = user.userName;
                        userSession.userPwd = user.userPwd;
                        userSession.role = user.role;
                        userSession.name = user.name;
                        Session.Add(CommonConstant.USER_SESSION, userSession);
                        return RedirectToAction("", "Admin");
                    }

                }
                else if (res == 0)
                {
                    ModelState.AddModelError("", "Not Available!");
                }
                else if (res == -1)
                {
                    ModelState.AddModelError("", "You Are blocking!");
                }
                else if (res == -2)
                {
                    ModelState.AddModelError("", "passwrod isvalid!");
                }
                else
                {
                    ModelState.AddModelError("", "Login False!");
                }

            }
            return View("Login");
        }

        public ActionResult Logout()
        {
            Session[CommonConstant.USER_SESSION] = null;
            return Redirect("/");
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
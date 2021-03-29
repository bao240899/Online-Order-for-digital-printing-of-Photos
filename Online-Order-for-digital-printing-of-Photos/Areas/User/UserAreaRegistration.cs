using System.Web.Mvc;

namespace Online_Order_for_digital_printing_of_Photos.Areas.User
{
    public class UserAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "User";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "User_default",
            //    "User/{controller}/{action}/{id}",
            //    new { Controller = "Register", action = "Register", id = UrlParameter.Optional }
            //);
        }
    }
}
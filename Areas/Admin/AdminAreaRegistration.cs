using System.Web.Mvc;

namespace Online_Order_for_digital_printing_of_Photos.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{Area}/{controller}/{action}/{id}",
                new { Area="Admin", Controller="Dashboard",  action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
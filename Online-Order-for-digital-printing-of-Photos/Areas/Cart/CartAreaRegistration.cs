using System.Web.Mvc;

namespace Online_Order_for_digital_printing_of_Photos.Areas.Cart
{
    public class CartAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Cart";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Cart_default",
                "Cart/{Area}/{controller}/{action}/{id}",
                new { Area="Cart", Controller ="Cart", action = "Cart", id = UrlParameter.Optional }
            );
        }
    }
}
using System.Web.Mvc;

namespace Online_Order_for_digital_printing_of_Photos.Areas.Image
{
    public class ImageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Image";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Image_default",
                "Image/{controller}/{action}/{id}",
                new { area="Image", Controller = "Image", action = "ImgList", id = UrlParameter.Optional }
            );
        }
    }
}
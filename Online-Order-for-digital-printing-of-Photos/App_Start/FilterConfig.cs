using System.Web;
using System.Web.Mvc;

namespace Online_Order_for_digital_printing_of_Photos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

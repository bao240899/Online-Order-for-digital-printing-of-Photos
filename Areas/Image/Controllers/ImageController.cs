using Online_Order_for_digital_printing_of_Photos.Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Order_for_digital_printing_of_Photos.Areas.Image.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image/Image
        public ActionResult ImgList()
        {
            var model = new PhotoDao().ImgList();
            return View(model);
        }
    }
}
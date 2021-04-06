using Online_Order_for_digital_printing_of_Photos.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Order_for_digital_printing_of_Photos.Models.Dao
{
    public class PhotoDao
    {
        OnlineOrderEntities db = null;
        public PhotoDao()
        {
            db = new OnlineOrderEntities();
        }

        public List<Photos> ImgList()
        {
            return db.Photos.ToList();
        }

        public Photos GetById(int userid)
        {
            return db.Photos.SingleOrDefault(x => x.userID == userid);
        }
    }
}
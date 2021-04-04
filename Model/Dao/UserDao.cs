using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.Dao
{
    public class UserDao
    {
        OnlineOrderEntities db = null;
        public UserDao()
        {
            db = new OnlineOrderEntities();
        }

        public Users GetById(string username)
        {
            return db.Users.SingleOrDefault(x => x.userName == username);
        }

        //public Users GetByIdd(int userid)
        //{
        //    return db.Users.SingleOrDefault(x => x.userID == userid);
        //}

        public int Login(string username, string password)
        {
            var res = db.Users.SingleOrDefault(x => x.userName == username);
            if (res == null)
            {
                return 0;
            }
            else
            {
                if (res.status == 0)
                {
                    return -1;
                }
                else
                {
                    if (res.userPwd == password)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }


                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Classes
{
    public class SiteSee
    {
        public static void See()
        {

            using (MyShop.Models.MyEshopEntities db =new Models.MyEshopEntities())
            {
                DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                var state = db.StateSite.FirstOrDefault(s => s.Date == dt);
           

                if (state !=null)
                {
                    state.Count += 1;

                }else
               

                {

                    db.StateSite.Add(new Models.StateSite() {
                        Date=dt,
                        Count=1,



                    });
                }
                db.SaveChanges();
            }
        }
    }
}
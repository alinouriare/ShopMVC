using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace MyShop.Controllers
{
    public class ShopController : ApiController
    {
        // GET: api/Shop
        public string Get()
        {
            int Count = 0;
            var sessions = HttpContext.Current.Session;
            List<ShopCartItem> shopcart = new List<ShopCartItem>();
            if (sessions["ShoppingCart"] != null)
            {
                shopcart = sessions["ShoppingCart"] as List<ShopCartItem>;
                Count = shopcart.Sum(s => s.ProductCount);

            }

                return "سبد خرید شما:" + Count + " " + "کالا";
        }

        // GET: api/Shop/5
        public string Get(int productid)
        {
            var sessions = HttpContext.Current.Session;
            List<ShopCartItem> shopcart = new List<ShopCartItem>();
            if (sessions["ShoppingCart"] !=null)
            {
                shopcart = sessions["ShoppingCart"] as List<ShopCartItem>;
                if (shopcart.Any(s=>s.ProductId==productid))
                {
                    int index = shopcart.FindIndex(s => s.ProductId == productid);
                    shopcart[index].ProductCount += 1;

                }
                else
                {

                    shopcart.Add(new ShopCartItem()
                    {
                        ProductId = productid,
                        ProductCount = 1


                    });
                }
            }
            else
            {

                shopcart.Add(new ShopCartItem()
                {
                    ProductId = productid,
                    ProductCount=1
                

                });
            }
            sessions["ShoppingCart"] = shopcart;
            return Get();
        }

        // POST: api/Shop
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Shop/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shop/5
        public void Delete(int id)
        {
        }
    }
}

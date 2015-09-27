using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusStore.Models;

namespace MusStore.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        StoreContext db = new StoreContext();
        const string PromoCode = "Free";
        // GET: Checkout
        public ActionResult AddressAndPayment()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new Ord();
            TryUpdateModel(order);

            try
            {
                if (string.Equals(values["PromoCode"], PromoCode,
                    StringComparison.OrdinalIgnoreCase) == false)
                {
                    return View(order);
                }
                else
                {
                    order.Username = User.Identity.Name;
                    order.OrderDate = Convert.ToString(DateTime.Now);

                    //Save Order
                    db.Ords.Add(order);
                    db.SaveChanges();
                    //Process the order
                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    cart.CreateOrder(order);

                    return RedirectToAction("Complete",
                        new { id = order.OrdId });
                }
            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }

        public ActionResult Complete()
        { 
                return View();
        }

    }
}
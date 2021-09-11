using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParcialPA1.Models;

namespace ParcialPA1.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "monto")] Monto m)
        {

            if (ModelState.IsValid)
            {

                if (m.monto % 5 == 0) return RedirectToAction("./retiro");
                return RedirectToAction("./error");



            }

            return View(m);
        }

        /*[HttpPost]
        //public ActionResult Index([Bind(Include ="monto")]Monto monto)
        public ActionResult Index(int monto, FormCollection collection)
        {   //usar el operador % para saber el residuo de una division, si este es 0 se puede dividir entre este
            if (monto % 5==0) return RedirectToAction("./retiro");
            return HttpNotFound();

        }
        */
        public ActionResult retiro()
        {
            

            return View();
        }

        public ActionResult Error()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
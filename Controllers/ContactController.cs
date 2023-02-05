using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje2.Models.Siniflar;

namespace WebProje2.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        //Iletisim iletisim = new Iletisim();
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult MesajYolla()
        {
            //ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MesajYolla(Iletisim y)
        {
            c.Iletisims.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }

}
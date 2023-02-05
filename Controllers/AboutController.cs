using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje2.Models.Siniflar;
namespace WebProje2.Controllers
{
    public class AboutController : Controller
    {
        
        Context  c = new Context();

        public ActionResult Index()
        {
            var degerler =c.Hakkimizdas.ToList() ;
            return View(degerler);
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje2.Models.Siniflar;
namespace WebProje2.Controllers
{
    public class BlogController : Controller
    {
        BlogYorum blogYorum = new BlogYorum();
        // GET: Blog
        Context c = new Context(); 
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            blogYorum.Deger1 = c.Blogs.ToList();
            blogYorum.Deger3= c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            blogYorum.Deger4 = c.Yorumlars.OrderByDescending(x=>x.ID).Take(3).ToList();
            return View(blogYorum);
        }
        
        public ActionResult BlogDetay(int id)  /*int id yazılacak*/
        { 
            //var blogbul = c.Blogs.Where(x=>x.ID== id).ToList();
            blogYorum.Deger1 = c.Blogs.Where(x=>x.ID== id).ToList();
            blogYorum.Deger2=c.Yorumlars.Where(x=>x.BlogId== id).ToList();
            return View(blogYorum);
        }

        


        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger=id;
            return PartialView();
        }
        
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }



    }
}
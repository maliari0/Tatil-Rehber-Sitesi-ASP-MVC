using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje2.Models.Siniflar;
namespace WebProje2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var b = c.Blogs.Find(id);
            return View("BlogGetir", b);
        }
        public ActionResult BlogGuncelle(Blog blg)
        {
            var b = c.Blogs.Find(blg.ID);
            b.Aciklama = blg.Aciklama;
            b.Baslik = blg.Baslik;
            b.BlogImage = blg.BlogImage;
            b.Tarih = blg.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var y = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(y);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var y = c.Yorumlars.Find(id);
            return View("YorumGetir", y);
        }
        public ActionResult YorumGuncelle(Yorumlar yrm)
        {
            var y = c.Yorumlars.Find(yrm.ID);
            y.KullaniciAdi = yrm.KullaniciAdi;
            y.Mail = yrm.Mail;
            y.Yorum = yrm.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult ContactListesi()
        {
            var contacts = c.Iletisims.ToList();
            return View(contacts);
        }
        public ActionResult ContactSil(int id)
        {
            var contact = c.Iletisims.Find(id);
            c.Iletisims.Remove(contact);
            c.SaveChanges();
            return RedirectToAction("ContactListesi");
        }
        //public ActionResult AboutGetir(int id)
        //{
        //    var b = c.Blogs.Find(id);
        //    return View("BlogGetir", b);
        //}
        //public ActionResult AboutGuncelle(Hakkimizda hk)
        //{
        //    var b = c.Hakkimizdas.First();
        //    b.FotoUrl = hk.FotoUrl;
        //    b.Aciklama = hk.Aciklama;
        //    c.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
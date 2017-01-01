using CMart_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using CMart_Website.Models;
using System.Net.Mail;

namespace CMart_Website.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        CMART1Entities db = new CMART1Entities();

        public ActionResult Index(int? page = 1)
        {
            int pageSize = 9;

            var p = db.Products.ToList();

            return View(p.ToPagedList(page.Value, pageSize));
        }

        public PartialViewResult MenuPartial()
        {
            return PartialView(db.ProductTypes);
        }

        public ActionResult Search(string searchstring, int? page = 1)
        {
            var p = db.Products.Where(x => x.Name.Contains(searchstring)).ToList();

            int pageSize = 9;
           
            return View("Index" ,p.ToPagedList(page.Value, pageSize));            
        }

        public ActionResult Category(string IDType, int? page = 1)
        {
            var result = db.Products.Where(x => x.ProductType.IDType == IDType).ToList();

            int pageSize = 9;

            return View(result.ToPagedList(page.Value, pageSize));
        }

        public ActionResult Promotions() {
            var promotionpath = db.Promotions.ToList().Where(x => x.Image != null);
            return View(promotionpath);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact ct)
        {


            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("cmartvanlanguni@gmail.com");
                mail.From = new MailAddress(ct.Email);
                mail.Subject = ct.Subject;
                string Body = "From:" + ct.Email + " || Name:" + ct.Name + " || Message: " + ct.Message;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("cmartvanlanguni@gmail.com", "dridrachoc");// Enter seders User name and password
                smtp.EnableSsl = true;
                smtp.Send(mail);
                ViewBag.s = "Send successful.";
                return View();    
            }
            else
            {
                return View();
            }

         
        }
    }
}

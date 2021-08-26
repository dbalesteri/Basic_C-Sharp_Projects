using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using EmailMVCApplication.Models;
using Hangfire;
using System.Net.Mail;
using EmailSender;

namespace EmailMVCApplication.Controllers
{
    public class NewEmailController : Controller
    {
        private NewEmailDBContext db = new NewEmailDBContext();

        // GET: NewEmail
        public ActionResult Index()
        {
            return View(db.NewEmails.ToList());
        }

        // GET: NewEmail/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewEmail newEmail = db.NewEmails.Find(id);
            if (newEmail == null)
            {
                return HttpNotFound();
            }
            return View(newEmail);
        }

        // GET: NewEmail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewEmail/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Sender,Recipient,Subject,Body,SentDateTime,SentStatus")] NewEmail newEmail)
        {

            if (ModelState.IsValid)
            {
                newEmail.Sender = "EmailMVCApplication@gmail.com";
                newEmail.SentDateTime = DateTime.Now;

                newEmail = (NewEmail)Email.SendEmail(newEmail);

                db.NewEmails.Add(newEmail);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(newEmail);
        }

        // GET: NewEmail/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewEmail newEmail = db.NewEmails.Find(id);
            if (newEmail == null)
            {
                return HttpNotFound();
            }
            return View(newEmail);
        }

        // POST: NewEmail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewEmail newEmail = db.NewEmails.Find(id);
            db.NewEmails.Remove(newEmail);
            db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}

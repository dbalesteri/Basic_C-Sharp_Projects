using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmailMVCApplication.Models;

namespace EmailMVCApplication.Controllers
{
    public class AdminController : Controller
    {
        private NewEmailDBContext db = new NewEmailDBContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.NewEmails.ToList());
        }

    }
}

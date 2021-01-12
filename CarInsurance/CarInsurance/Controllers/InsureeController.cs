using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            insuree.Quote = 50; //starting value
            double age = (DateTime.Today - insuree.DateOfBirth).TotalDays / 365.2425; //365.2425 is average days per year from wikipedia
            if (age <= 18) // if 18 or under, add 100
            {
                insuree.Quote += 100;
            }
            else if (age > 18 && age < 26) // if between 19 and 25, add 50
            {
                insuree.Quote += 50;
            }
            else // else they are over 25, add 25
            {
                insuree.Quote += 25;
            }
            if (insuree.CarYear < 2000) //if car was made before 2000, add 25
            {
                insuree.Quote += 25;
            }
            else if (insuree.CarYear > 2015) //if car was made newer than 2015, add 25
            {
                insuree.Quote += 25;
            }
            if (insuree.CarMake.ToLower() == "porsche") //add 25 if Porsche
            {
                insuree.Quote += 25;
                if (insuree.CarModel.ToLower() == "911 carrera") //add extra 25 if model of Porsche is 911 Carrera
                {
                    insuree.Quote += 25;
                }
            }
            insuree.Quote += (insuree.SpeedingTickets * 10); // add 10 per speeding ticket
            if (insuree.DUI) //if had DUI, add 25%
            {
                insuree.Quote *= (decimal)1.25;
            }
            if (insuree.CoverageType) //if Full Coverage, add 50%
            {
                insuree.Quote *= (decimal)1.50;
            }

            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Confirmation", new {insuree.Id});
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            insuree.Quote = 50;
            double age =  (DateTime.Today - insuree.DateOfBirth).TotalDays / 365.2425; //365.2425 is average days per year from wikipedia
            if (age <= 18) // if 18 or under, add 100
            {
                insuree.Quote += 100;
            }
            else if (age > 18 && age < 26 ) // if between 19 and 25, add 50
            {
                insuree.Quote += 50;
            }
            else // else they are over 25, add 25
            {
                insuree.Quote += 25;
            }
            if (insuree.CarYear < 2000) //if car was made before 2000, add 25
            {
                insuree.Quote += 25;
            }
            else if (insuree.CarYear > 2015) //if car was made newer than 2015, add 25
            {
                insuree.Quote += 25;
            }
            if (insuree.CarMake.ToLower() == "porsche") //add 25 if Porsche
            {
                insuree.Quote += 25;
                if (insuree.CarModel.ToLower() == "911 carrera") //add extra 25 if model of Porsche is 911 Carrera
                {
                    insuree.Quote += 25;
                }
            }
            insuree.Quote += (insuree.SpeedingTickets * 10); // add 10 per speeding ticket
            if (insuree.DUI) //if had DUI, add 25%
            {
                insuree.Quote *= (decimal)1.25;
            }
            if (insuree.CoverageType) //if Full Coverage, add 50%
            {
                insuree.Quote *= (decimal)1.50;
            }

            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Admin");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        public ActionResult Confirmation(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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

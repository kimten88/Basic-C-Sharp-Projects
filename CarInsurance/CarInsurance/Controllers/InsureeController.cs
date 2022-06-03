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
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
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
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
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
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [HttpPost]
        public ActionResult QuoteCal(int Id)
        {
            Insuree insuree = db.Insurees.Find(Id);
            decimal quote = 50.00m;
            var ageInfo = DateTime.Today.Year - insuree.DateOfBirth.Year;
            int age = Convert.ToInt32(ageInfo);
            if (age <= 18)
            {
                quote += 100;
            }
            else if (19 <= age && age <= 25)
            {
                quote += 50;
            }
            else
            {
                quote += 25;
            }
            int carYearInfo = insuree.CarYear;
            if (carYearInfo < 2000 || carYearInfo > 2015)
            {
                quote += 25;
            }
            string carMakeInfo = insuree.CarMake;
            if (carMakeInfo == "Porche")
            {
                quote += 25;
            }
            string carModelInfo = insuree.CarModel;
            if (carMakeInfo == "Porche" && carModelInfo == "911 Carrera")
            {
                quote += 25;
            }
            int ticketsNum = insuree.SpeedingTickets;
            if (ticketsNum < 0)
            {
                int ticketPrice = ticketsNum * 10;
                quote += ticketPrice;
            }          
            bool DUIInstance = insuree.DUI;
            if (DUIInstance is true)
            {
                decimal DUIExpense = quote * .25m;
                quote += DUIExpense;
            }
            bool fullCoverage = insuree.CoverageType;
            if (fullCoverage is true)
            {
                decimal fullCoverageExpense = quote * .50m;
                quote = (int)(quote + fullCoverageExpense);
            }
            decimal quoteAdd = Convert.ToDecimal(quote);
            db.Insurees.Quote.Add(quoteAdd);
            return View("Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WaletzkoPortfolio.Models;

namespace WaletzkoPortfolio.Controllers
{
    public class ContactController : Controller
    {
        private PortfolioContext db = new PortfolioContext();

        // GET: /Contact/
        public ActionResult Index()
        {
            return View(db.ContactInfo.ToList());
        }

        // GET: /Contact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactInfo contactinfo = db.ContactInfo.Find(id);
            if (contactinfo == null)
            {
                return HttpNotFound();
            }
            return View(contactinfo);
        }

        // GET: /Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Name,value")] ContactInfo contactinfo)
        {
            if (ModelState.IsValid)
            {
                db.ContactInfo.Add(contactinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactinfo);
        }

        // GET: /Contact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactInfo contactinfo = db.ContactInfo.Find(id);
            if (contactinfo == null)
            {
                return HttpNotFound();
            }
            return View(contactinfo);
        }

        // POST: /Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Name,value")] ContactInfo contactinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactinfo);
        }

        // GET: /Contact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactInfo contactinfo = db.ContactInfo.Find(id);
            if (contactinfo == null)
            {
                return HttpNotFound();
            }
            return View(contactinfo);
        }

        // POST: /Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactInfo contactinfo = db.ContactInfo.Find(id);
            db.ContactInfo.Remove(contactinfo);
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
    }
}

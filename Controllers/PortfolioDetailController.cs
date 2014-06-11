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
    public class PortfolioDetailController : Controller
    {
        private PortfolioContext db = new PortfolioContext();

        // GET: /PortfolioDetail/
        public ActionResult Index()
        {
            return View(db.PortfolioDetails.ToList());
        }

        // GET: /PortfolioDetail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PortfolioDetail portfoliodetail = db.PortfolioDetails.Find(id);
            if (portfoliodetail == null)
            {
                return HttpNotFound();
            }
            return View(portfoliodetail);
        }

        // GET: /PortfolioDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /PortfolioDetail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Description,PictureID")] PortfolioDetail portfoliodetail)
        {
            if (ModelState.IsValid)
            {
                db.PortfolioDetails.Add(portfoliodetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(portfoliodetail);
        }

        // GET: /PortfolioDetail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PortfolioDetail portfoliodetail = db.PortfolioDetails.Find(id);
            if (portfoliodetail == null)
            {
                return HttpNotFound();
            }
            return View(portfoliodetail);
        }

        // POST: /PortfolioDetail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Description,PictureID")] PortfolioDetail portfoliodetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(portfoliodetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(portfoliodetail);
        }

        // GET: /PortfolioDetail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PortfolioDetail portfoliodetail = db.PortfolioDetails.Find(id);
            if (portfoliodetail == null)
            {
                return HttpNotFound();
            }
            return View(portfoliodetail);
        }

        // POST: /PortfolioDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PortfolioDetail portfoliodetail = db.PortfolioDetails.Find(id);
            db.PortfolioDetails.Remove(portfoliodetail);
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

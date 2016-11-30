using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AI_Lib.Models;

namespace AI_Lib.Controllers
{
    public class publishersController : Controller
    {
        private Lib_AIEntities db = new Lib_AIEntities();

        // GET: publishers
        public ActionResult Index()
        {
            return View(db.publisher.ToList());
        }

        // GET: publishers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            publisher publisher = db.publisher.Find(id);
            if (publisher == null)
            {
                return HttpNotFound();
            }
            return View(publisher);
        }

        // GET: publishers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: publishers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "publisher_id,publisher_name")] publisher publisher)
        {
            if (ModelState.IsValid)
            {
                db.publisher.Add(publisher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publisher);
        }

        // GET: publishers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            publisher publisher = db.publisher.Find(id);
            if (publisher == null)
            {
                return HttpNotFound();
            }
            return View(publisher);
        }

        // POST: publishers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "publisher_id,publisher_name")] publisher publisher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publisher).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publisher);
        }

        // GET: publishers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            publisher publisher = db.publisher.Find(id);
            if (publisher == null)
            {
                return HttpNotFound();
            }
            return View(publisher);
        }

        // POST: publishers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            publisher publisher = db.publisher.Find(id);
            db.publisher.Remove(publisher);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AI_Lib.Models;
using PagedList;

namespace AI_Lib.Controllers
{
    public class booksController : Controller
    {
        private Lib_AIEntities db = new Lib_AIEntities();

        // GET: books
        public ActionResult Index(int page =1 , int pageSize = 10)
        {

            var book = db.book.Include(b => b.author).Include(b => b.category).Include(b => b.publisher);
            
            //PagedList<book> model = new PagedList<book>(book, page, pageSize);

            return View(book.OrderBy(t=>t.book_id).ToPagedList(page,pageSize));
        }

        // GET: books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            book book = db.book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: books/Create
        public ActionResult Create()
        {
            ViewBag.author_id = new SelectList(db.author, "author_id", "author_first_name");
            ViewBag.category_id = new SelectList(db.category, "category_id", "category_name");
            ViewBag.publisher_id = new SelectList(db.publisher, "publisher_id", "publisher_name");
            return View();
        }

        // POST: books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "book_id,publisher_id,author_id,book_title,book_original_title,book_release_date,book_isbn_no,book_page_no,category_id,book_rate,book_cover_url")] book book)
        {
            if (ModelState.IsValid)
            {
                db.book.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.author_id = new SelectList(db.author, "author_id", "author_first_name", book.author_id);
            ViewBag.category_id = new SelectList(db.category, "category_id", "category_name", book.category_id);
            ViewBag.publisher_id = new SelectList(db.publisher, "publisher_id", "publisher_name", book.publisher_id);
            return View(book);
        }

        // GET: books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            book book = db.book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.author_id = new SelectList(db.author, "author_id", "author_first_name", book.author_id);
            ViewBag.category_id = new SelectList(db.category, "category_id", "category_name", book.category_id);
            ViewBag.publisher_id = new SelectList(db.publisher, "publisher_id", "publisher_name", book.publisher_id);
            return View(book);
        }

        // POST: books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "book_id,publisher_id,author_id,book_title,book_original_title,book_release_date,book_isbn_no,book_page_no,category_id,book_rate,book_cover_url")] book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.author_id = new SelectList(db.author, "author_id", "author_first_name", book.author_id);
            ViewBag.category_id = new SelectList(db.category, "category_id", "category_name", book.category_id);
            ViewBag.publisher_id = new SelectList(db.publisher, "publisher_id", "publisher_name", book.publisher_id);
            return View(book);
        }

        // GET: books/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            book book = db.book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            book book = db.book.Find(id);
            db.book.Remove(book);
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

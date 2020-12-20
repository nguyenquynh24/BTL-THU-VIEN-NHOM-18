using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL_THU_VIEN_NHOM_18.Models;

namespace BTL_THU_VIEN_NHOM_18.Controllers
{
    public class DOCGIAsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: DOCGIAs
        public ActionResult Index()
        {
            return View(db.dOCGIAs.ToList());
        }

        // GET: DOCGIAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOCGIA dOCGIA = db.dOCGIAs.Find(id);
            if (dOCGIA == null)
            {
                return HttpNotFound();
            }
            return View(dOCGIA);
        }

        // GET: DOCGIAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DOCGIAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "docgiaid,msdocgia,tendocgia,diachidocgia,ngaysinhdocgia,emaildocgia,gioitinhdocgia,sodienthoaidocgia")] DOCGIA dOCGIA)
        {
            if (ModelState.IsValid)
            {
                db.dOCGIAs.Add(dOCGIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dOCGIA);
        }

        // GET: DOCGIAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOCGIA dOCGIA = db.dOCGIAs.Find(id);
            if (dOCGIA == null)
            {
                return HttpNotFound();
            }
            return View(dOCGIA);
        }

        // POST: DOCGIAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "docgiaid,msdocgia,tendocgia,diachidocgia,ngaysinhdocgia,emaildocgia,gioitinhdocgia,sodienthoaidocgia")] DOCGIA dOCGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dOCGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dOCGIA);
        }

        // GET: DOCGIAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOCGIA dOCGIA = db.dOCGIAs.Find(id);
            if (dOCGIA == null)
            {
                return HttpNotFound();
            }
            return View(dOCGIA);
        }

        // POST: DOCGIAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DOCGIA dOCGIA = db.dOCGIAs.Find(id);
            db.dOCGIAs.Remove(dOCGIA);
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

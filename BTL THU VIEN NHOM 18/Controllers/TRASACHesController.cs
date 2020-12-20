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
    public class TRASACHesController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: TRASACHes
        public ActionResult Index()
        {
            return View(db.tRASACHes.ToList());
        }

        // GET: TRASACHes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRASACH tRASACH = db.tRASACHes.Find(id);
            if (tRASACH == null)
            {
                return HttpNotFound();
            }
            return View(tRASACH);
        }

        // GET: TRASACHes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRASACHes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "sophieumuonid,mssach,msnhanvien,ngaytra")] TRASACH tRASACH)
        {
            if (ModelState.IsValid)
            {
                db.tRASACHes.Add(tRASACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRASACH);
        }

        // GET: TRASACHes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRASACH tRASACH = db.tRASACHes.Find(id);
            if (tRASACH == null)
            {
                return HttpNotFound();
            }
            return View(tRASACH);
        }

        // POST: TRASACHes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "sophieumuonid,mssach,msnhanvien,ngaytra")] TRASACH tRASACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRASACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRASACH);
        }

        // GET: TRASACHes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRASACH tRASACH = db.tRASACHes.Find(id);
            if (tRASACH == null)
            {
                return HttpNotFound();
            }
            return View(tRASACH);
        }

        // POST: TRASACHes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRASACH tRASACH = db.tRASACHes.Find(id);
            db.tRASACHes.Remove(tRASACH);
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

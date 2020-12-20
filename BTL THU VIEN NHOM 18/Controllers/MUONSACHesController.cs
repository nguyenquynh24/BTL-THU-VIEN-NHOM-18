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
    public class MUONSACHesController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: MUONSACHes
        public ActionResult Index()
        {
            return View(db.mUONSACHes.ToList());
        }

        // GET: MUONSACHes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUONSACH mUONSACH = db.mUONSACHes.Find(id);
            if (mUONSACH == null)
            {
                return HttpNotFound();
            }
            return View(mUONSACH);
        }

        // GET: MUONSACHes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MUONSACHes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "sophieumuonid,sophieumuon,msdocgia,msnhanvien,ngaymuon,ngaytra")] MUONSACH mUONSACH)
        {
            if (ModelState.IsValid)
            {
                db.mUONSACHes.Add(mUONSACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mUONSACH);
        }

        // GET: MUONSACHes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUONSACH mUONSACH = db.mUONSACHes.Find(id);
            if (mUONSACH == null)
            {
                return HttpNotFound();
            }
            return View(mUONSACH);
        }

        // POST: MUONSACHes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "sophieumuonid,sophieumuon,msdocgia,msnhanvien,ngaymuon,ngaytra")] MUONSACH mUONSACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mUONSACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mUONSACH);
        }

        // GET: MUONSACHes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUONSACH mUONSACH = db.mUONSACHes.Find(id);
            if (mUONSACH == null)
            {
                return HttpNotFound();
            }
            return View(mUONSACH);
        }

        // POST: MUONSACHes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MUONSACH mUONSACH = db.mUONSACHes.Find(id);
            db.mUONSACHes.Remove(mUONSACH);
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

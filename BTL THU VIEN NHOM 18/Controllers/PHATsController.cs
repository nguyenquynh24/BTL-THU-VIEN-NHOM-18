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
    public class PHATsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: PHATs
        public ActionResult Index()
        {
            return View(db.pHATs.ToList());
        }

        // GET: PHATs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHAT pHAT = db.pHATs.Find(id);
            if (pHAT == null)
            {
                return HttpNotFound();
            }
            return View(pHAT);
        }

        // GET: PHATs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PHATs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,mssach,msdocgia,msnhanvien,lydophat")] PHAT pHAT)
        {
            if (ModelState.IsValid)
            {
                db.pHATs.Add(pHAT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pHAT);
        }

        // GET: PHATs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHAT pHAT = db.pHATs.Find(id);
            if (pHAT == null)
            {
                return HttpNotFound();
            }
            return View(pHAT);
        }

        // POST: PHATs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,mssach,msdocgia,msnhanvien,lydophat")] PHAT pHAT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHAT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pHAT);
        }

        // GET: PHATs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHAT pHAT = db.pHATs.Find(id);
            if (pHAT == null)
            {
                return HttpNotFound();
            }
            return View(pHAT);
        }

        // POST: PHATs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PHAT pHAT = db.pHATs.Find(id);
            db.pHATs.Remove(pHAT);
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

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
    public class CHITIETPHIEUMUONsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: CHITIETPHIEUMUONs
        public ActionResult Index()
        {
            return View(db.cHITIETPHIEUMUONs.ToList());
        }

        // GET: CHITIETPHIEUMUONs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETPHIEUMUON cHITIETPHIEUMUON = db.cHITIETPHIEUMUONs.Find(id);
            if (cHITIETPHIEUMUON == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETPHIEUMUON);
        }

        // GET: CHITIETPHIEUMUONs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CHITIETPHIEUMUONs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "sophieumuonid,msdocgia,sophieumuon,mssach,hantra")] CHITIETPHIEUMUON cHITIETPHIEUMUON)
        {
            if (ModelState.IsValid)
            {
                db.cHITIETPHIEUMUONs.Add(cHITIETPHIEUMUON);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cHITIETPHIEUMUON);
        }

        // GET: CHITIETPHIEUMUONs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETPHIEUMUON cHITIETPHIEUMUON = db.cHITIETPHIEUMUONs.Find(id);
            if (cHITIETPHIEUMUON == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETPHIEUMUON);
        }

        // POST: CHITIETPHIEUMUONs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "sophieumuonid,msdocgia,sophieumuon,mssach,hantra")] CHITIETPHIEUMUON cHITIETPHIEUMUON)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHITIETPHIEUMUON).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cHITIETPHIEUMUON);
        }

        // GET: CHITIETPHIEUMUONs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETPHIEUMUON cHITIETPHIEUMUON = db.cHITIETPHIEUMUONs.Find(id);
            if (cHITIETPHIEUMUON == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETPHIEUMUON);
        }

        // POST: CHITIETPHIEUMUONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CHITIETPHIEUMUON cHITIETPHIEUMUON = db.cHITIETPHIEUMUONs.Find(id);
            db.cHITIETPHIEUMUONs.Remove(cHITIETPHIEUMUON);
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

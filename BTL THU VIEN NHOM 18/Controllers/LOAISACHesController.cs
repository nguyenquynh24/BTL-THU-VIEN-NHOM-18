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
    public class LOAISACHesController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: LOAISACHes
        public ActionResult Index()
        {
            return View(db.lOAISACHes.ToList());
        }

        // GET: LOAISACHes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAISACH lOAISACH = db.lOAISACHes.Find(id);
            if (lOAISACH == null)
            {
                return HttpNotFound();
            }
            return View(lOAISACH);
        }

        // GET: LOAISACHes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LOAISACHes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tensach,maloaisach")] LOAISACH lOAISACH)
        {
            if (ModelState.IsValid)
            {
                db.lOAISACHes.Add(lOAISACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lOAISACH);
        }

        // GET: LOAISACHes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAISACH lOAISACH = db.lOAISACHes.Find(id);
            if (lOAISACH == null)
            {
                return HttpNotFound();
            }
            return View(lOAISACH);
        }

        // POST: LOAISACHes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tensach,maloaisach")] LOAISACH lOAISACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lOAISACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lOAISACH);
        }

        // GET: LOAISACHes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAISACH lOAISACH = db.lOAISACHes.Find(id);
            if (lOAISACH == null)
            {
                return HttpNotFound();
            }
            return View(lOAISACH);
        }

        // POST: LOAISACHes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LOAISACH lOAISACH = db.lOAISACHes.Find(id);
            db.lOAISACHes.Remove(lOAISACH);
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

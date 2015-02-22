using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using tomstahl.DAL;
using tomstahl.Models;

namespace tomstahl.Controllers
{
    public class ResumeContentsController : Controller
    {
        private ResumeContext db = new ResumeContext();

        // GET: ResumeContents
        public ActionResult Index()
        {
            return View(db.ResumeContents.ToList());
        }

        // GET: ResumeContents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResumeContent resumeContent = db.ResumeContents.Find(id);
            if (resumeContent == null)
            {
                return HttpNotFound();
            }
            return View(resumeContent);
        }

        // GET: ResumeContents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResumeContents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Content")] ResumeContent resumeContent)
        {
            if (ModelState.IsValid)
            {
                db.ResumeContents.Add(resumeContent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resumeContent);
        }

        // GET: ResumeContents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResumeContent resumeContent = db.ResumeContents.Find(id);
            if (resumeContent == null)
            {
                return HttpNotFound();
            }
            return View(resumeContent);
        }

        // POST: ResumeContents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Content")] ResumeContent resumeContent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resumeContent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resumeContent);
        }

        // GET: ResumeContents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResumeContent resumeContent = db.ResumeContents.Find(id);
            if (resumeContent == null)
            {
                return HttpNotFound();
            }
            return View(resumeContent);
        }

        // POST: ResumeContents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResumeContent resumeContent = db.ResumeContents.Find(id);
            db.ResumeContents.Remove(resumeContent);
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

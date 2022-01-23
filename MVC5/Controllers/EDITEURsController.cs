using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5;

namespace MVC5.Controllers
{
    public class EDITEURsController : Controller
    {
        private librairieEntities db = new librairieEntities();



        public ActionResult Action1(string a, string b)
        {

            return Content(a + b);
        }

        public ActionResult calculer(string x, string y)
        {

            return Content(x + y);
        }


        public ActionResult chercher(string id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EDITEUR eDITEUR = db.EDITEUR.Find(id);
            if (eDITEUR == null)
            {
                return HttpNotFound();
            }
            return PartialView ("~/Views/EDITEURs/unEditeur.cshtml", eDITEUR);



        }




        // GET: EDITEURs
        public ActionResult Index(string rech = "")
        {
            var ed = db.EDITEUR.Where(o => o.NOMED.Contains(rech));
            return View(ed.ToList());
        }

        // GET: EDITEURs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EDITEUR eDITEUR = db.EDITEUR.Find(id);
            if (eDITEUR == null)
            {
                return HttpNotFound();
            }
            return View(eDITEUR);
        }

        // GET: EDITEURs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EDITEURs/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NOMED,ADRED,CPED,VILLEED,TELED")] EDITEUR eDITEUR)
        {
            if (ModelState.IsValid)
            {
                db.EDITEUR.Add(eDITEUR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eDITEUR);
        }

        // GET: EDITEURs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EDITEUR eDITEUR = db.EDITEUR.Find(id);
            if (eDITEUR == null)
            {
                return HttpNotFound();
            }
            return View(eDITEUR);
        }

        // POST: EDITEURs/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NOMED,ADRED,CPED,VILLEED,TELED")] EDITEUR eDITEUR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eDITEUR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eDITEUR);
        }

        // GET: EDITEURs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EDITEUR eDITEUR = db.EDITEUR.Find(id);
            if (eDITEUR == null)
            {
                return HttpNotFound();
            }
            return View(eDITEUR);
        }

        // POST: EDITEURs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            EDITEUR eDITEUR = db.EDITEUR.Find(id);
            db.EDITEUR.Remove(eDITEUR);
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

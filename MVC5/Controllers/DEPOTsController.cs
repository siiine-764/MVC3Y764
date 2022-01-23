using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5;

namespace MVC5.Controllers
{
    public class DEPOTsController : Controller
    {
        private librairieEntities db = new librairieEntities();

        // GET: DEPOTs
        public async Task<ActionResult> Index()
        {
            return View(await db.DEPOT.ToListAsync());
        }

        // GET: DEPOTs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DEPOT dEPOT = await db.DEPOT.FindAsync(id);
            if (dEPOT == null)
            {
                return HttpNotFound();
            }
            return View(dEPOT);
        }

        // GET: DEPOTs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DEPOTs/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "NUMDEP,NOMDEP,ADRDEP,CPDEP,VILLEDEP")] DEPOT dEPOT)
        {
            if (ModelState.IsValid)
            {
                db.DEPOT.Add(dEPOT);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(dEPOT);
        }

        // GET: DEPOTs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DEPOT dEPOT = await db.DEPOT.FindAsync(id);
            if (dEPOT == null)
            {
                return HttpNotFound();
            }
            return View(dEPOT);
        }

        // POST: DEPOTs/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "NUMDEP,NOMDEP,ADRDEP,CPDEP,VILLEDEP")] DEPOT dEPOT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dEPOT).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dEPOT);
        }

        // GET: DEPOTs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DEPOT dEPOT = await db.DEPOT.FindAsync(id);
            if (dEPOT == null)
            {
                return HttpNotFound();
            }
            return View(dEPOT);
        }

        // POST: DEPOTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DEPOT dEPOT = await db.DEPOT.FindAsync(id);
            db.DEPOT.Remove(dEPOT);
            await db.SaveChangesAsync();
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

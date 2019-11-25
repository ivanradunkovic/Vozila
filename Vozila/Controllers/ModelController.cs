using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vozila.DAL;
using Vozila.Models;
using PagedList;

namespace Vozila.Controllers
{
    public class ModelController : Controller
    {
        private VehicleContext db = new VehicleContext();

        // GET: Model
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.MakeIdSortParm = String.IsNullOrEmpty(sortOrder) ? "makeId_desc" : "";
            ViewBag.NameSortParm = sortOrder == "Name" ? "name_desc" : "Name";
            ViewBag.AbrvSortParm = sortOrder == "Abrv" ? "abrv_desc" : "Abrv";
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;
            var models = from s in db.Models
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                models = models.Where(s => s.Name.Contains(searchString)
                                       || s.Abrv.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "makeId_desc":
                    models = models.OrderByDescending(s => s.MakeId);
                    break;
                case "name_desc":
                    models = models.OrderByDescending(s => s.Name);
                    break;
                case "abrv_desc":
                    models = models.OrderByDescending(s => s.Abrv);
                    break;
                default:
                    models = models.OrderBy(s => s.Id);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(models.ToPagedList(pageNumber, pageSize));
        }

        // GET: Model/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Model model = db.Models.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: Model/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Model/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MakeId,Name,Abrv")] Model model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Models.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(model);
        }

        // GET: Model/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Model model = db.Models.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Model/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MakeId,Name,Abrv")] Model model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Model/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Model model = db.Models.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Model/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Model model = db.Models.Find(id);
            db.Models.Remove(model);
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

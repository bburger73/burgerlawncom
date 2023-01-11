using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace burgerlawncom.Models
{
    public class client_servicesController : Controller
    {
        private burgerlawnClientServiceEntities db = new burgerlawnClientServiceEntities();

        // GET: client_services
        public ActionResult Index()
        {
            return View(db.client_services.ToList());
        }

        // GET: client_services/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client_services client_services = db.client_services.Find(id);
            if (client_services == null)
            {
                return HttpNotFound();
            }
            return View(client_services);
        }

        // GET: client_services/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: client_services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,client_id,services_id,bid_price,due_date,completion_date,paid")] client_services client_services)
        {
            if (ModelState.IsValid)
            {
                db.client_services.Add(client_services);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(client_services);
        }

        // GET: client_services/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client_services client_services = db.client_services.Find(id);
            if (client_services == null)
            {
                return HttpNotFound();
            }
            return View(client_services);
        }

        // POST: client_services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,client_id,services_id,bid_price,due_date,completion_date,paid")] client_services client_services)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client_services).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(client_services);
        }

        // GET: client_services/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client_services client_services = db.client_services.Find(id);
            if (client_services == null)
            {
                return HttpNotFound();
            }
            return View(client_services);
        }

        // POST: client_services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            client_services client_services = db.client_services.Find(id);
            db.client_services.Remove(client_services);
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

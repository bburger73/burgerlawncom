using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace burgerlawncom.Models
{
    public class TimekeepingController : Controller
    {
        // GET: Timekeeping
        public ActionResult Index()
        {
            return View();
        }

        // GET: Timekeeping/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Timekeeping/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Timekeeping/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Timekeeping/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Timekeeping/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Timekeeping/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Timekeeping/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

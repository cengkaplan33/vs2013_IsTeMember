using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Membership.Site.Controllers
{
    public class derrController : Controller
    {
        // GET: derr
        public ActionResult Index()
        {
            return View();
        }

        // GET: derr/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: derr/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: derr/Create
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

        // GET: derr/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: derr/Edit/5
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

        // GET: derr/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: derr/Delete/5
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

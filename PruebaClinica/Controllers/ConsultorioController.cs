using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaClinica.Controllers
{
    public class ConsultorioController : Controller
    {
        // GET: Consultorio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Consultorio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Consultorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consultorio/Create
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

        // GET: Consultorio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Consultorio/Edit/5
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

        // GET: Consultorio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Consultorio/Delete/5
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

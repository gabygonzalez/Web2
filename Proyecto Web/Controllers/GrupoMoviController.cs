using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Controllers
{
    public class GrupoMoviController : Controller
    {
        // GET: GrupoMovi
        public ActionResult Index()
        {
            return View();
        }

        // GET: GrupoMovi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GrupoMovi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GrupoMovi/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GrupoMovi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GrupoMovi/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GrupoMovi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GrupoMovi/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
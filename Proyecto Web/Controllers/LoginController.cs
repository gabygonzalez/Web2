using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string ReturnURL)
        {
            if (User.Identity.IsAuthenticated == false)
            {
                if (ReturnURL != null)
                    ViewData.Add("ReturnURL", ReturnURL);
                else
                    ViewData.Add("ReturnURL", "");
                return View();
            }
            else
            {
                return RedirectToAction("Inicio", "Principal"); //Action,Controller
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logeo(ProyectoWeb.Models.Usuarios usu)
        {
            using (rodlpContext context = new rodlpContext())
            {
                Usuarios user = new Usuarios();
                var x = context.Usuarios.ToList();
                user = context.Usuarios.Where(s => s.NomUsuario.Equals(usu.NomUsuario) && s.Contrasena.Equals(usu.Contrasena)).SingleOrDefault();
                if (user != null)
                {
                    return RedirectToAction("Principal");
                }
            }
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        public IActionResult Principal()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
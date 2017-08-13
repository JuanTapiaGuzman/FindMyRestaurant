using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMyRestaurant.Models;
using FindMyRestaurant.Models.ViewModels;


namespace FindMyRestaurant.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult New()
        {
            var Transporte = new Transporte().SelectTransportes();
            List<SelectListItem> Transportes = new List<SelectListItem>();
            foreach (var item in Transporte)
            {
                Transportes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
            }

            ViewBag.Transportes = Transportes;

            return View();
        }

        [HttpPost]
        public ActionResult New(UsuarioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var Transporte = new Transporte().SelectTransportes();
                List<SelectListItem> Transportes = new List<SelectListItem>();
                foreach (var item in Transporte)
                {
                    Transportes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
                }

                ViewBag.Transportes = Transportes;

                return View(model);
            }

            var Usuario = new Usuario();

            Usuario.InsertUsuario(model.User, model.Contraseña, model.Nombre, model.Email, model.IdTransporte);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {
            var Usuario = new Usuario();
            var model = new UsuarioViewModel();

            Usuario = Usuario.SelectUsuario(int.Parse(Id));

            model.Id = Usuario.Id;
            model.User = Usuario.User;
            model.Nombre = Usuario.Nombre;
            model.Contraseña = Usuario.Contraseña;
            model.Email = Usuario.Email;

            var Transporte = new Transporte().SelectTransportes();
            List<SelectListItem> Transportes = new List<SelectListItem>();

            foreach (var item in Transporte)
            {
                if(Usuario.IdTransporte == item.Id)
                {
                    Transportes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString(), Selected = true });
                }
                else
                {
                    Transportes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
                }
            }

            ViewBag.Transportes = Transportes;

            model.IdTransporte = Usuario.IdTransporte;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(UsuarioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var Transporte = new Transporte().SelectTransportes();
                List<SelectListItem> Transportes = new List<SelectListItem>();
                foreach (var item in Transporte)
                {
                    if (item.SelectTransporte(model.Id).Id == item.Id)
                    {
                        Transportes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString(), Selected = true });
                    }
                    else
                    {
                        Transportes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
                    }
                }

                ViewBag.Transportes = Transportes;

                return View(model);
            }

            var Usuario = new Usuario();

            Usuario.UpdateUsuario(model.Id, model.User, model.Contraseña, model.Nombre, model.Email, model.IdTransporte);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string Id)
        {
            var Usuario = new Usuario();
            Usuario.DeleteUsuario(int.Parse(Id));

            return RedirectToAction("Index");
        }
    }
}
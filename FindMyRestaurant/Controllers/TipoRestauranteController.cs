using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMyRestaurant.Models;
using FindMyRestaurant.Models.ViewModels;

namespace FindMyRestaurant.Controllers
{
    public class TipoRestauranteController : Controller
    {
        // GET: TipoRestaurante
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(TipoRestauranteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var TipoRestaurante = new TipoRestaurante();

            TipoRestaurante.InsertTipoRestaurante(model.Nombre, model.Especialidad);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {
            var TipoRestaurante = new TipoRestaurante();
            var model = new TipoRestauranteViewModel();

            TipoRestaurante = TipoRestaurante.SelectTipoRestaurante(int.Parse(Id));

            model.Id = TipoRestaurante.Id;
            model.Nombre = TipoRestaurante.Nombre;
            model.Especialidad = TipoRestaurante.Especialidad;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(TipoRestauranteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var TipoRestaurante = new TipoRestaurante();

            TipoRestaurante.UpdateTipoRestaurante(model.Id, model.Nombre, model.Especialidad);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public void Delete(string Id)
        {
            var TipoRestaurante = new TipoRestaurante();
            TipoRestaurante.DeleteTipoRestaurante(int.Parse(Id));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMyRestaurant.Models;
using FindMyRestaurant.Models.ViewModels;

namespace FindMyRestaurant.Controllers
{
    public class TransporteController : Controller
    {
        // GET: Transporte
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
        public ActionResult New(TransporteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var Transporte = new Transporte();

            Transporte.InsertTransporte(model.Nombre);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {
            var Transporte = new Transporte();
            var model = new TransporteViewModel();

            Transporte = Transporte.SelectTransporte(int.Parse(Id));

            model.Id = Transporte.Id;
            model.Nombre = Transporte.Nombre;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(TransporteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var Transporte = new Transporte();

            Transporte.UpdateTransporte(model.Id, model.Nombre);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string Id)
        {
            var Transporte = new Transporte();
            Transporte.DeleteTransporte(int.Parse(Id));

            return RedirectToAction("Index");
        }
    }
}
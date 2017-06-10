using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMyRestaurant.Models;
using FindMyRestaurant.Models.ViewModels;

namespace FindMyRestaurant.Controllers
{
    public class CiudadController : Controller
    {
        // GET: Ciudad
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
        public ActionResult New(CiudadViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var Ciudad = new Ciudad();

            Ciudad.InsertCiudad(model.Nombre);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {
            var Ciudad = new Ciudad();
            var model = new CiudadViewModel();

            Ciudad = Ciudad.SelectCiudad(int.Parse(Id));

            model.Id = Ciudad.Id;
            model.Nombre = Ciudad.Nombre;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CiudadViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var Ciudad = new Ciudad();

            Ciudad.UpdateCiudad(model.Id, model.Nombre);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public void Delete(string Id)
        {
            var Ciudad = new Ciudad();
            Ciudad.DeleteCiudad(int.Parse(Id));
        }
    }
}
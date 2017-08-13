using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMyRestaurant.Models;
using FindMyRestaurant.Models.ViewModels;

namespace FindMyRestaurant.Controllers
{
    public class RangoPrecioController : Controller
    {
        // GET: RangoPrecio
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
        public ActionResult New(RangoPrecioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var RangoPrecio = new RangoPrecio();

            RangoPrecio.InsertRangoPrecio(model.Nombre, model.PrecioMayor, model.PrecioMenor, model.PrecioMedio);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {
            var RangoPrecio = new RangoPrecio();
            var model = new RangoPrecioViewModel();

            RangoPrecio = RangoPrecio.SelectRangoPrecio(int.Parse(Id));

            model.Id = RangoPrecio.Id;
            model.Nombre = RangoPrecio.Nombre;
            model.PrecioMayor = RangoPrecio.PrecioMayor;
            model.PrecioMedio = RangoPrecio.PrecioMedio;
            model.PrecioMenor = RangoPrecio.PrecioMenor;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(RangoPrecioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var RangoPrecio = new RangoPrecio();

            RangoPrecio.UpdateRangoPrecio(model.Id, model.Nombre, model.PrecioMayor, model.PrecioMenor, model.PrecioMedio);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string Id)
        {
            var RangoPrecio = new RangoPrecio();
            RangoPrecio.DeleteRangoPrecio(int.Parse(Id));

            return RedirectToAction("Index");
        }


    }
}
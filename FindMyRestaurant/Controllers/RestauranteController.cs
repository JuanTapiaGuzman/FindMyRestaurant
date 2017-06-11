using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMyRestaurant.Models;
using FindMyRestaurant.Models.ViewModels;

namespace FindMyRestaurant.Controllers
{
    public class RestauranteController : Controller
    {
        // GET: Restaurante
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult New()
        {
            var TipoRestaurante = new TipoRestaurante().SelectTipoRestaurantes();
            var RangoPrecio = new RangoPrecio().SelectRangoPrecios();
            var Ciudad = new Ciudad().SelectCiudades();

            List<SelectListItem> TipoRestaurantes = new List<SelectListItem>();
            foreach (var item in TipoRestaurante)
            {
                TipoRestaurantes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
            }

            List<SelectListItem> RangoPrecios = new List<SelectListItem>();
            foreach (var item in RangoPrecio)
            {
                RangoPrecios.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
            }

            List<SelectListItem> Ciudades = new List<SelectListItem>();
            foreach (var item in Ciudad)
            {
                Ciudades.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
            }

            ViewBag.TipoRestaurantes = TipoRestaurantes;
            ViewBag.RangoPrecios = RangoPrecios;
            ViewBag.Ciudades = Ciudades;

            return View();
        }

        [HttpPost]
        public ActionResult New(RestauranteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var TipoRestaurante = new TipoRestaurante().SelectTipoRestaurantes();
                var RangoPrecio = new RangoPrecio().SelectRangoPrecios();
                var Ciudad = new Ciudad().SelectCiudades();

                List<SelectListItem> TipoRestaurantes = new List<SelectListItem>();
                foreach (var item in TipoRestaurante)
                {
                    TipoRestaurantes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
                }

                List<SelectListItem> RangoPrecios = new List<SelectListItem>();
                foreach (var item in RangoPrecio)
                {
                    RangoPrecios.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
                }

                List<SelectListItem> Ciudades = new List<SelectListItem>();
                foreach (var item in Ciudad)
                {
                    Ciudades.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
                }

                ViewBag.TipoRestaurantes = TipoRestaurantes;
                ViewBag.RangoPrecios = RangoPrecios;
                ViewBag.Ciudades = Ciudades;

                return View(model);
            }

            var Restaurante = new Restaurante();

            Restaurante.InsertRestaurante(model.Nombre, model.IdTipoRestaurante, model.Valoracion, model.IdRangoPrecio, model.Direccion, model.IdCiudad, model.Telefono, model.LatitudGps, model.LongitudGps);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {
            var Restaurante = new Restaurante();
            var model = new RestauranteViewModel();

            var TipoRestaurante = new TipoRestaurante().SelectTipoRestaurantes();
            var RangoPrecio = new RangoPrecio().SelectRangoPrecios();
            var Ciudad = new Ciudad().SelectCiudades();

            List<SelectListItem> TipoRestaurantes = new List<SelectListItem>();
            foreach (var item in TipoRestaurante)
            {
                TipoRestaurantes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
            }

            List<SelectListItem> RangoPrecios = new List<SelectListItem>();
            foreach (var item in RangoPrecio)
            {
                RangoPrecios.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
            }

            List<SelectListItem> Ciudades = new List<SelectListItem>();
            foreach (var item in Ciudad)
            {
                Ciudades.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
            }

            ViewBag.TipoRestaurantes = TipoRestaurantes;
            ViewBag.RangoPrecios = RangoPrecios;
            ViewBag.Ciudades = Ciudades;

            Restaurante = Restaurante.SelectRestaurante(int.Parse(Id));

            model.Id = Restaurante.Id;
            model.Nombre = Restaurante.Nombre;
            model.IdTipoRestaurante = Restaurante.IdTipoRestaurante;
            model.Valoracion = Restaurante.Valoracion;
            model.IdRangoPrecio = Restaurante.IdRangoPrecio;
            model.Direccion = Restaurante.Direccion;
            model.IdCiudad = Restaurante.IdCiudad;
            model.Telefono = Restaurante.Telefono;
            model.LatitudGps = Restaurante.LatitudGps;
            model.LongitudGps = Restaurante.LongitudGps;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(RestauranteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var TipoRestaurante = new TipoRestaurante().SelectTipoRestaurantes();
                var RangoPrecio = new RangoPrecio().SelectRangoPrecios();
                var Ciudad = new Ciudad().SelectCiudades();

                List<SelectListItem> TipoRestaurantes = new List<SelectListItem>();
                foreach (var item in TipoRestaurante)
                {
                    TipoRestaurantes.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
                }

                List<SelectListItem> RangoPrecios = new List<SelectListItem>();
                foreach (var item in RangoPrecio)
                {
                    RangoPrecios.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
                }

                List<SelectListItem> Ciudades = new List<SelectListItem>();
                foreach (var item in Ciudad)
                {
                    Ciudades.Add(new SelectListItem { Text = item.Nombre, Value = item.Id.ToString() });
                }

                ViewBag.TipoRestaurantes = TipoRestaurantes;
                ViewBag.RangoPrecios = RangoPrecios;
                ViewBag.Ciudades = Ciudades;

                return View(model);
            }

            var Restaurante = new Restaurante();

            Restaurante.UpdateRestaurante(model.Id, model.Nombre, model.IdTipoRestaurante, model.Valoracion, model.IdRangoPrecio, model.Direccion, model.IdCiudad, model.Telefono, model.LatitudGps, model.LongitudGps);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string Id)
        {
            var Restaurante = new Restaurante();
            Restaurante.DeleteRestaurante(int.Parse(Id));

            return RedirectToAction("Index");
        }
    }
}
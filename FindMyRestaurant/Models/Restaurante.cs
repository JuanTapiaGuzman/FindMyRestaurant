using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Models
{
    public class Restaurante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdTipoRestaurante { get; set; }
        public int IdRangoPrecio { get; set; }
        public string Direccion { get; set; }
        public int IdCiudad { get; set; }
        public string Telefono { get; set; }
        public string LatitudGps { get; set; }
        public string LongitudGps { get; set; }

        public List<Restaurante> SelectRestaurantes()
        {
            Data.dsRestauranteTableAdapters.RestaurantesTableAdapter adapter = new Data.dsRestauranteTableAdapters.RestaurantesTableAdapter();
            Data.dsRestaurante.RestaurantesDataTable dt = adapter.SelectRestaurantes();

            var Restaurantes = new List<Restaurante>();
            if (dt.Rows.Count == 0)
                return Restaurantes;

            foreach (Data.dsRestaurante.RestaurantesRow data in dt)
            {
                var Restaurante = new Restaurante();

                Restaurante.Id = data.IdRestaurante;
                Restaurante.Nombre = data.Nombre;
                Restaurante.IdTipoRestaurante = data.IdTipoRestaurante;
                Restaurante.IdRangoPrecio = data.IdRangoPrecio;
                Restaurante.Direccion = data.Direccion;
                Restaurante.IdCiudad = data.IdCiudad;
                Restaurante.Telefono = data.Telefono;
                Restaurante.LatitudGps = data.LatitudGps;
                Restaurante.LongitudGps = data.LongitudGps;

                Restaurantes.Add(Restaurante);
            }

            return Restaurantes;
        }

        public Restaurante SelectRestaurante(int? Id)
        {
            Data.dsRestauranteTableAdapters.RestauranteTableAdapter adapter = new Data.dsRestauranteTableAdapters.RestauranteTableAdapter();
            Data.dsRestaurante.RestauranteDataTable dt = adapter.SelectRestaurante(Id);

            var Restaurante = new Restaurante();
            if (dt.Rows.Count == 0)
                return Restaurante;

            foreach (Data.dsRestaurante.RestauranteRow data in dt)
            {

                Restaurante.Id = data.IdRestaurante;
                Restaurante.Nombre = data.Nombre;
                Restaurante.IdTipoRestaurante = data.IdTipoRestaurante;
                Restaurante.IdRangoPrecio = data.IdRangoPrecio;
                Restaurante.Direccion = data.Direccion;
                Restaurante.IdCiudad = data.IdCiudad;
                Restaurante.Telefono = data.Telefono;
                Restaurante.LatitudGps = data.LatitudGps;
                Restaurante.LongitudGps = data.LongitudGps;

            }

            return Restaurante;
        }

        public void InsertRestaurante(string nombre, int idTipoRestaurante, double valoracion, int idRangoPrecio, string direccion, int idCiudad, string telefono, string latitudGps, string longitudGps)
        {
            Data.dsRestauranteTableAdapters.RestaurantesTableAdapter adapter = new Data.dsRestauranteTableAdapters.RestaurantesTableAdapter();
            adapter.InsertRestaurante(nombre, idTipoRestaurante, valoracion, idRangoPrecio, direccion, idCiudad, telefono, latitudGps, longitudGps);
        }

        public void UpdateRestaurante(int? id, string nombre, int idTipoRestaurante, double valoracion, int idRangoPrecio, string direccion, int idCiudad, string telefono, string latitudGps, string longitudGps)
        {
            Data.dsRestauranteTableAdapters.RestaurantesTableAdapter adapter = new Data.dsRestauranteTableAdapters.RestaurantesTableAdapter();
            adapter.UpdateRestaurante(id, nombre, idTipoRestaurante, valoracion, idRangoPrecio, direccion, idCiudad, telefono, latitudGps, longitudGps);
        }

        public void DeleteRestaurante(int? id)
        {
            Data.dsRestauranteTableAdapters.RestaurantesTableAdapter adapter = new Data.dsRestauranteTableAdapters.RestaurantesTableAdapter();
            adapter.DeleteRestaurante(id);
        }
    }
}
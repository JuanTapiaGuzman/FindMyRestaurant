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
        public double Valoracion { get; set; }
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
                Restaurante.Valoracion = data.Valoracion;
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
                Restaurante.Valoracion = data.Valoracion;
                Restaurante.IdRangoPrecio = data.IdRangoPrecio;
                Restaurante.Direccion = data.Direccion;
                Restaurante.IdCiudad = data.IdCiudad;
                Restaurante.Telefono = data.Telefono;
                Restaurante.LatitudGps = data.LatitudGps;
                Restaurante.LongitudGps = data.LongitudGps;

            }

            return Restaurante;
        }

        public void InsertRestaurante(string Nombre, int IdTipoRestaurante, double Valoracion, int IdRangoPrecio, string Direccion, int IdCiudad, string Telefono, string LatitudGps, string LongitudGps)
        {
            Data.dsRestauranteTableAdapters.RestaurantesTableAdapter adapter = new Data.dsRestauranteTableAdapters.RestaurantesTableAdapter();
            adapter.InsertRestaurante(Nombre, IdTipoRestaurante, Valoracion, IdRangoPrecio, Direccion, IdCiudad, Telefono, LatitudGps, LongitudGps);
        }

        public void UpdateRestaurante(int? Id, string Nombre, int IdTipoRestaurante, double Valoracion, int IdRangoPrecio, string Direccion, int IdCiudad, string Telefono, string LatitudGps, string LongitudGps)
        {
            Data.dsRestauranteTableAdapters.RestaurantesTableAdapter adapter = new Data.dsRestauranteTableAdapters.RestaurantesTableAdapter();
            adapter.UpdateRestaurante(Id, Nombre, IdTipoRestaurante, Valoracion, IdRangoPrecio, Direccion, IdCiudad, Telefono, LatitudGps, LongitudGps);
        }

        public void DeleteRestaurante(int? Id)
        {
            Data.dsRestauranteTableAdapters.RestaurantesTableAdapter adapter = new Data.dsRestauranteTableAdapters.RestaurantesTableAdapter();
            adapter.DeleteRestaurante(Id);
        }
    }
}
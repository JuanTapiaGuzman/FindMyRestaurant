using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Models
{
    public class TipoRestaurante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public List<TipoRestaurante> SelectTipoRestaurantes()
        {
            Data.dsTipoRestauranteTableAdapters.TipoRestaurantesTableAdapter adapter = new Data.dsTipoRestauranteTableAdapters.TipoRestaurantesTableAdapter();
            Data.dsTipoRestaurante.TipoRestaurantesDataTable dt = adapter.SelectTipoRestaurantes();

            var TipoRestaurantes = new List<TipoRestaurante>();
            if (dt.Rows.Count == 0)
                return TipoRestaurantes;

            foreach (Data.dsTipoRestaurante.TipoRestaurantesRow data in dt)
            {
                var TipoRestaurante = new TipoRestaurante();

                TipoRestaurante.Id = data.IdTipoRestaurante;
                TipoRestaurante.Nombre = data.Nombre;
                TipoRestaurante.Especialidad = data.Especialidad;

                TipoRestaurantes.Add(TipoRestaurante);
            }

            return TipoRestaurantes;
        }

        public TipoRestaurante SelectTipoRestaurante(int? Id)
        {
            Data.dsTipoRestauranteTableAdapters.TipoRestauranteTableAdapter adapter = new Data.dsTipoRestauranteTableAdapters.TipoRestauranteTableAdapter();
            Data.dsTipoRestaurante.TipoRestauranteDataTable dt = adapter.SelectTipoRestaurante(Id);

            var TipoRestaurante = new TipoRestaurante();
            if (dt.Rows.Count == 0)
                return TipoRestaurante;

            foreach (Data.dsTipoRestaurante.TipoRestauranteRow data in dt)
            {

                TipoRestaurante.Id = data.IdTipoRestaurante;
                TipoRestaurante.Nombre = data.Nombre;
                TipoRestaurante.Especialidad = data.Especialidad;
            }

            return TipoRestaurante;
        }

        public void InsertTipoRestaurante(string Nombre, string Especialidad)
        {
            Data.dsTipoRestauranteTableAdapters.TipoRestaurantesTableAdapter adapter = new Data.dsTipoRestauranteTableAdapters.TipoRestaurantesTableAdapter();
            adapter.InsertTipoRestaurante(Nombre, Especialidad);
        }

        public void UpdateTipoRestaurante(int? Id, string Nombre, string Especialidad)
        {
            Data.dsTipoRestauranteTableAdapters.TipoRestaurantesTableAdapter adapter = new Data.dsTipoRestauranteTableAdapters.TipoRestaurantesTableAdapter();
            adapter.UpdateTipoRestaurante(Id, Nombre, Especialidad);
        }

        public void DeleteTipoRestaurante(int? Id)
        {
            Data.dsTipoRestauranteTableAdapters.TipoRestaurantesTableAdapter adapter = new Data.dsTipoRestauranteTableAdapters.TipoRestaurantesTableAdapter();
            adapter.DeleteTipoRestaurante(Id);
        }
    }
}
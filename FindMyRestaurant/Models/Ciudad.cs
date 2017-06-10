using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Ciudad> SelectCiudades()
        {
            Data.dsCiudadTableAdapters.CiudadesTableAdapter adapter = new Data.dsCiudadTableAdapters.CiudadesTableAdapter();
            Data.dsCiudad.CiudadesDataTable dt = adapter.SelectCiudades();

            var Ciudades = new List<Ciudad>();
            if (dt.Rows.Count == 0)
                return Ciudades;

            foreach(Data.dsCiudad.CiudadesRow data in dt)
            {
                var Ciudad = new Ciudad();

                Ciudad.Id = data.IdCiudad;
                Ciudad.Nombre = data.Nombre;

                Ciudades.Add(Ciudad);
            }

            return Ciudades;
        }

        public Ciudad SelectCiudad(int? Id)
        {
            Data.dsCiudadTableAdapters.CiudadTableAdapter adapter = new Data.dsCiudadTableAdapters.CiudadTableAdapter();
            Data.dsCiudad.CiudadDataTable dt = adapter.SelectCiudad(Id);

            var Ciudad = new Ciudad();
            if (dt.Rows.Count == 0)
                return Ciudad;

            foreach (Data.dsCiudad.CiudadRow data in dt)
            {

                Ciudad.Id = data.IdCiudad;
                Ciudad.Nombre = data.Nombre;

            }

            return Ciudad;
        }

        public void InsertCiudad(string Nombre)
        {
            Data.dsCiudadTableAdapters.CiudadesTableAdapter adapter = new Data.dsCiudadTableAdapters.CiudadesTableAdapter();
            adapter.InsertCiudad(Nombre);
        }

        public void UpdateCiudad(int? Id, string Nombre)
        {
            Data.dsCiudadTableAdapters.CiudadesTableAdapter adapter = new Data.dsCiudadTableAdapters.CiudadesTableAdapter();
            adapter.UpdateCiudad(Id, Nombre);
        }

        public void DeleteCiudad(int? Id)
        {
            Data.dsCiudadTableAdapters.CiudadesTableAdapter adapter = new Data.dsCiudadTableAdapters.CiudadesTableAdapter();
            adapter.DeleteCiudad(Id);
        }
    }
}
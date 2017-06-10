using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Models
{
    public class Transporte
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Transporte> SelectTransportes()
        {
            Data.dsTransporteTableAdapters.TransportesTableAdapter adapter = new Data.dsTransporteTableAdapters.TransportesTableAdapter();
            Data.dsTransporte.TransportesDataTable dt = adapter.SelectTransportes();

            var Transportes = new List<Transporte>();
            if (dt.Rows.Count == 0)
                return Transportes;

            foreach (Data.dsTransporte.TransportesRow data in dt)
            {
                var Transporte = new Transporte();

                Transporte.Id = data.IdTransporte;
                Transporte.Nombre = data.Nombre;

                Transportes.Add(Transporte);
            }

            return Transportes;
        }

        public Transporte SelectTransporte(int? Id)
        {
            Data.dsTransporteTableAdapters.TransporteTableAdapter adapter = new Data.dsTransporteTableAdapters.TransporteTableAdapter();
            Data.dsTransporte.TransporteDataTable dt = adapter.SelectTransporte(Id);

            var Transporte = new Transporte();
            if (dt.Rows.Count == 0)
                return Transporte;

            foreach (Data.dsTransporte.TransporteRow data in dt)
            {

                Transporte.Id = data.IdTransporte;
                Transporte.Nombre = data.Nombre;

            }

            return Transporte;
        }

        public void InsertTransporte(string Nombre)
        {
            Data.dsTransporteTableAdapters.TransportesTableAdapter adapter = new Data.dsTransporteTableAdapters.TransportesTableAdapter();
            adapter.InsertTransporte(Nombre);
        }

        public void UpdateTransporte(int? Id, string Nombre)
        {
            Data.dsTransporteTableAdapters.TransportesTableAdapter adapter = new Data.dsTransporteTableAdapters.TransportesTableAdapter();
            adapter.UpdateTransporte(Id, Nombre);
        }

        public void DeleteTransporte(int? Id)
        {
            Data.dsTransporteTableAdapters.TransportesTableAdapter adapter = new Data.dsTransporteTableAdapters.TransportesTableAdapter();
            adapter.DeleteTransporte(Id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; } 
        public string Contraseña { get; set; } 
        public string Nombre { get; set; } 
        public string Email { get; set; } 
        public int IdTransporte { get; set; }

        public List<Usuario> SelectUsuarios()
        {
            Data.dsUsuarioTableAdapters.UsuariosTableAdapter adapter = new Data.dsUsuarioTableAdapters.UsuariosTableAdapter();
            Data.dsUsuario.UsuariosDataTable dt = adapter.SelectUsuarios();

            var Usuarios = new List<Usuario>();
            if (dt.Rows.Count == 0)
                return Usuarios;

            foreach (Data.dsUsuario.UsuariosRow data in dt)
            {
                var Usuario = new Usuario();

                Usuario.Id = data.IdUsuario;
                Usuario.User = data.Usuario;
                Usuario.Nombre = data.Nombre;
                Usuario.Contraseña = data.Contraseña;
                Usuario.Email = data.Email;
                Usuario.IdTransporte = data.IdTransporte;

                Usuarios.Add(Usuario);
            }

            return Usuarios;
        }

        public Usuario SelectUsuario(int? id)
        {
            Data.dsUsuarioTableAdapters.UsuarioTableAdapter adapter = new Data.dsUsuarioTableAdapters.UsuarioTableAdapter();
            Data.dsUsuario.UsuarioDataTable dt = adapter.SelectUsuario(id);

            var Usuario = new Usuario();
            if (dt.Rows.Count == 0)
                return Usuario;

            foreach (Data.dsUsuario.UsuarioRow data in dt)
            {

                Usuario.Id = data.IdUsuario;
                Usuario.User = data.Usuario;
                Usuario.Nombre = data.Nombre;
                Usuario.Contraseña = data.Contraseña;
                Usuario.Email = data.Email;
                Usuario.IdTransporte = data.IdTransporte;

            }

            return Usuario;
        }

        public void InsertUsuario(string user, string contraseña, string nombre, string email, int idTransporte)
        {
            Data.dsUsuarioTableAdapters.UsuariosTableAdapter adapter = new Data.dsUsuarioTableAdapters.UsuariosTableAdapter();
            adapter.InsertUsuario(Nombre, User, Contraseña, Email, IdTransporte);
        }

        public void UpdateUsuario(int id, string user, string contraseña, string nombre, string email, int idTransporte)
        {
            Data.dsUsuarioTableAdapters.UsuariosTableAdapter adapter = new Data.dsUsuarioTableAdapters.UsuariosTableAdapter();
            adapter.UpdateUsuario(id, nombre, user, contraseña, email, idTransporte);
        }

        public void DeleteUsuario(int? id)
        {
            Data.dsUsuarioTableAdapters.UsuariosTableAdapter adapter = new Data.dsUsuarioTableAdapters.UsuariosTableAdapter();
            adapter.DeleteUsuario(Id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class UsuariosBL
    {
        public BindingList<Usuario> ListadeUsuarios { get; set; }

        public UsuariosBL()
        {
            ListadeUsuarios = new BindingList<Usuario>();
            CargarDatosdePrueba();
        }

        private void CargarDatosdePrueba()
        {
            var usuarioAdmin = new Usuario(1, "admin", "123");
            usuarioAdmin.PuedeVerClientes = true;
            usuarioAdmin.PuedeVerFacturas = true;
            usuarioAdmin.PuedeVerProductos = true;
            usuarioAdmin.PuedeVerProveedores = true;
            usuarioAdmin.PuedeVerCompras = true;
            usuarioAdmin.PuedeVerReportes = true;

            var usuarioCaja = new Usuario(2, "caja", "456");
            usuarioCaja.PuedeVerFacturas = true;

            ListadeUsuarios.Add(usuarioAdmin);
            ListadeUsuarios.Add(usuarioCaja);

        }

        public Usuario Autenticar(string nombre, string contrasena)
        {
            foreach (var usuario in ListadeUsuarios)
            {
                if (usuario.Nombre == nombre && usuario.Contrasena == contrasena)
                    return usuario;
            }
            return null;
        }
    }
}

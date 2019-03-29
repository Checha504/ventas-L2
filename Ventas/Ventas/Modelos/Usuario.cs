using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }

        public bool PuedeVerProductos { get; set; }
        public bool PuedeVerFacturas { get; set; }
        public bool PuedeVerClientes { get; set; }

        public bool PuedeVerProveedores { get; set; }
        public bool PuedeVerCompras { get; set; }

        public bool PuedeVerReportes { get; set; }

        public Usuario(int id, string nombre, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Contrasena = contrasena;
        }
    }
}

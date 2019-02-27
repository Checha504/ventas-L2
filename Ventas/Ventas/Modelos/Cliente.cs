using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Ciudad Ciudad { get; set; }
        public int CiudadId { get; set; }
        public string Direccion { get; set; }

        public Cliente(int id, string nombre, string telefono, Ciudad ciudad, string direccion)
        {

            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Ciudad = ciudad;
            Direccion = direccion;
            CiudadId = Ciudad.Id;

        }

    }
}

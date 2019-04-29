using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class CiudadesBL
    {
        public BindingList<Ciudad> Listadeciudades { get; set; }

        public CiudadesBL()
        {
            Listadeciudades = new BindingList<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {

            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");
            var ciudad3 = new Ciudad(3, "La Ceiba");
            var ciudad4 = new Ciudad(4, "Choloma");
            var ciudad5 = new Ciudad(5, "El Progreso");

            Listadeciudades.Add(ciudad1);
            Listadeciudades.Add(ciudad2);
            Listadeciudades.Add(ciudad3);
            Listadeciudades.Add(ciudad4);
            Listadeciudades.Add(ciudad5);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class CiudadesBL
    {
        public List<Ciudad> Listadeciudades { get; set; }

        public CiudadesBL()
        {
            Listadeciudades = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {

            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");

            Listadeciudades.Add(ciudad1);
            Listadeciudades.Add(ciudad2);

        }
    }
}

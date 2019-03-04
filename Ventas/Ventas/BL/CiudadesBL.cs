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

            Listadeciudades.Add(ciudad1);
            Listadeciudades.Add(ciudad2);

        }
    }
}

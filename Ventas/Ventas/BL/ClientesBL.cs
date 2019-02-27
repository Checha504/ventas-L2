﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public List<Cliente> Listadeclientes  { get; set; }

        public ClientesBL()
        {
            Listadeclientes = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");

            var cliente1 = new Cliente(1401, "Juan", "87878787", ciudad1, "Villas del Sol");
            var cliente2 = new Cliente(1402, "Pedro", "99887788", ciudad2, "Colonia Kennedy");
            var cliente3 = new Cliente(1403, "Oscar", "33224585", ciudad1, "Jardines del Valle");

            Listadeclientes.Add(cliente1);
            Listadeclientes.Add(cliente2);
            Listadeclientes.Add(cliente3);
        }
    }
}

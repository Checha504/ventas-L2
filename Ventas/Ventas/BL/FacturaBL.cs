﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class FacturaBL
    {
        public BindingList<Factura> ListadeFacturas { get; set; }

        public FacturaBL()
        {
            ListadeFacturas = new BindingList<Factura>();
        }
    }
}

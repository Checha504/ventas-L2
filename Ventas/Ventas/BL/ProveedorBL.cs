using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ProveedorBL
    {
        public BindingList<Proveedor> Listadeproveedores { get; set; }

        public ProveedorBL()
        {
            Listadeproveedores = new BindingList<Proveedor>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var proveedor1 = new Proveedor(1, "Dell S.A", "22557766");
            var proveedor2 = new Proveedor(2, "Asus Laptops", "22456532");
            var proveedor3 = new Proveedor(3, "Logitech", "22887766");

            Listadeproveedores.Add(proveedor1);
            Listadeproveedores.Add(proveedor2);
            Listadeproveedores.Add(proveedor3);
            
        }

    }
}

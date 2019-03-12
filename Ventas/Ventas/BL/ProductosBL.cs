using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ProductosBL
    {
        public BindingList<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new BindingList<Producto>();
            CrearDatosdePrueba();
        }
        public double ObtenerPrecio(int id)
        {
            double precio =0 ;
            foreach (var Producto in ListadeProductos)
            {
                if (Producto.Id == id)
                    precio = Producto.Precio;
            }
            return precio;
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Producto(1, "Laptop DELL", 15000, categoria1);
            var producto2 = new Producto(2, "Laptop ASUS", 20000, categoria1);
            var producto3 = new Producto(3, "Mouse Logitech", 200, categoria2);

            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);
        }

    }
}

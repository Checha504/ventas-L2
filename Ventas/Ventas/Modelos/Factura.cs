using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.BL;

namespace Ventas.Modelos
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool Activo { get; set; }

        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }


        public Factura()
        {
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalle = new BindingList<FacturaDetalle>();
        }

        public void CalcularTotalFactura()
        {
            var productosBL = new ProductosBL();

            double subtotal = 0;
            foreach (var detalle in FacturaDetalle)
            {
                var precio = productosBL.ObtenerPrecio(detalle.ProductoId);
     
                subtotal = subtotal + detalle.CalcularTotalDetalle(precio);
            }

            Subtotal = subtotal;
            Impuesto = subtotal * 0.15;
            Total = Subtotal + Impuesto;
        }
    }


    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public FacturaDetalle()
        {
            Cantidad = 1;
            ProductoId = 1;
        }

        public double CalcularTotalDetalle(double precio)
        {
            Precio = precio;
            Total = Cantidad * Precio;
            return Total;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;
using Ventas.Modelos;

namespace Ventas
{
    public partial class FormCompras : Form
    {
        ComprasBL _comprasBL;

        public FormCompras()
        {
            InitializeComponent();
        }

        public void CargarDatos(ComprasBL comprasBL, ProveedorBL proveedoresBL, ProductosBL productosBL)
        {
            _comprasBL = comprasBL;
            listadeComprasBindingSource.DataSource = comprasBL.ListadeCompras;
            listadeproveedoresBindingSource.DataSource = proveedoresBL.Listadeproveedores;
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;
        }

        private void compraDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var compras = (Compras)listadeComprasBindingSource.Current;
            compras.CalcularTotalCompra();
            listadeComprasBindingSource.ResetBindings(false);
        }
    }
}

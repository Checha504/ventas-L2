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

namespace Ventas
{
    public partial class Menu : Form
    {
        ClientesBL _clientesBL;
        CiudadesBL _ciudadesBL;
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;
        FacturaBL _facturaBL;
        ProveedorBL _proveedoresBL;
        ComprasBL _comprasBL;

        public Menu()
        {
            InitializeComponent();
            _clientesBL = new ClientesBL();
            _ciudadesBL = new CiudadesBL();
            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
            _facturaBL = new FacturaBL();
            _proveedoresBL = new ProveedorBL();
            _comprasBL = new ComprasBL();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;

            formClientes.cargarDatos(_clientesBL, _ciudadesBL);
            formClientes.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new Form1();
            formProductos.MdiParent = this;

            formProductos.cargarDatos(_productosBL, _categoriasBL);
            formProductos.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new Form3();
            formFactura.MdiParent = this;

            formFactura.cargarDatos(_facturaBL, _clientesBL, _productosBL);
            formFactura.Show();

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProveedor = new FormProveedor();
            formProveedor.MdiParent = this;

            formProveedor.cargarDatos(_proveedoresBL);
            formProveedor.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formCompras = new FormCompras();
            formCompras.MdiParent = this;

            formCompras.CargarDatos(_comprasBL, _proveedoresBL, _productosBL);
            formCompras.Show();
        }
    }
}

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
        UsuariosBL _usuariosBL;

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
            _usuariosBL = new UsuariosBL();
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

        private void Menu_Load(object sender, EventArgs e)
        {
            var login = new Login();
            login.CargarDatos(_usuariosBL);

            login.ShowDialog();

            productosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProductos;
            facturaToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerFacturas;
            clientesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerClientes;

            proveedoresToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProveedores;
            comprasToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerCompras;

            reportesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReportes;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.CargarDatos(_productosBL);
            formReporteProductos.MdiParent = this;

            formReporteProductos.Show();

        }

        private void totalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteVentas = new FormReportedeVentas();
            formReporteVentas.CargarDatos(_facturaBL, _clientesBL);
            formReporteVentas.MdiParent = this;

            formReporteVentas.Show();
        }
    }
}

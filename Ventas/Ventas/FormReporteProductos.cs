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
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();
        }
        public void CargarDatos(ProductosBL productosBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = from p in productosBL.ListadeProductos
                                       select new
                                       {
                                           Foto = p.Foto,
                                           Id = p.Id,
                                           Descripcion = p.Descripcion,
                                           Categoria = p.Categoria.Descripcion,
                                           Precio = p.Precio,
                                           Existencia = p.Existencia                                 
                                       };

            var reporte = new ReportedeProductos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}

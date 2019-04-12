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
    public partial class FormReportedeVentas : Form
    {
        public FormReportedeVentas()
        {
            InitializeComponent();
        }

        public void CargarDatos(FacturaBL facturaBL, ClientesBL clientesBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = from f in facturaBL.ListadeFacturas
                                       select new
                                       {
                                           Id = f.Id,
                                           Fecha = f.Fecha,
                                           Cliente = clientesBL.Listadeclientes.FirstOrDefault(r => r.Id == f.ClienteId).Nombre,
                                           Subtotal = f.Subtotal,
                                           Impuesto = f.Impuesto,
                                           Total = f.Total,
                                           Activo = f.Activo
                                       };

            var reporte = new ReportedeFacturas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}

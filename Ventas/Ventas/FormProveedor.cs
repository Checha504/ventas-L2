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
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();      
            
        }

        public void cargarDatos(ProveedorBL proveedorBL)
        {
            listadeproveedoresBindingSource.DataSource = proveedorBL.Listadeproveedores;
        }
    }
}

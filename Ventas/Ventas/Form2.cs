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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
        }

        public void cargarDatos(ClientesBL clientesBL, CiudadesBL ciudadesBL)
        {
            listadeclientesBindingSource.DataSource = clientesBL.Listadeclientes;
            listadeciudadesBindingSource.DataSource = ciudadesBL.Listadeciudades;
        }
    }
}

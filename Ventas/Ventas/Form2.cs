using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ciudades
            var ciudad1 = new Ciudad();

            ciudad1.Id = 1;
            ciudad1.Descripcion = "San Pedro Sula";

             
            var ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "Tegucigalpa";


            // Clientes
            var cliente1 = new Cliente();

            cliente1.Id = 1401;
            cliente1.Nombre = "Juan";
            cliente1.Telefono = "48984040";
            cliente1.Direccion = "Res. Villas del sol";
            cliente1.Ciudad = ciudad1;

            Cliente cliente2 = new Cliente();
            cliente2.Id = 1402;
            cliente2.Nombre = "Pedro";
            cliente2.Telefono = "83836645";
            cliente2.Direccion = "Colonia Kennedy";
            cliente2.Ciudad = ciudad2;

            Cliente cliente3 = new Cliente();
            cliente3.Id = 1403;
            cliente3.Nombre = "Oscar";
            cliente3.Telefono = "55886978";
            cliente3.Direccion = "Colonia Zeron";
            cliente3.Ciudad = ciudad1;

            var Clientes = new List<Cliente>();
            Clientes.Add(cliente1);
            Clientes.Add(cliente2);
            Clientes.Add(cliente3);

            foreach (var c in Clientes)
            {

                MessageBox.Show(c.Id + "\n" + c.Nombre + "\n " + c.Telefono + "\n " + c.Direccion + "\n" + c.Ciudad.Id + "  " + c.Ciudad.Descripcion);
            }




        }
    }
}

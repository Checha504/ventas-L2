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
    public partial class Login : Form
    {
        UsuariosBL _usuariosBL;
        public Usuario UsuarioAutenticado { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = textBox1.Text;
            var contrasena = textBox2.Text;

            var usuarioAutenticado = _usuariosBL.Autenticar(nombre, contrasena);

            if(usuarioAutenticado != null)
            {
                UsuarioAutenticado = usuarioAutenticado;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña erronea");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CargarDatos(UsuariosBL usuariosBL)
        {
            _usuariosBL = usuariosBL;
        }
    }
}

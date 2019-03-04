using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class CategoriasBL
    {
        public BindingList<Categoria> ListadeCategorias { get; set; }

        public CategoriasBL()
        {
            ListadeCategorias = new BindingList<Categoria>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1 ,"Laptops");
            var categoria2 = new Categoria(2 , "Accesorios");

            ListadeCategorias.Add(categoria1);
            ListadeCategorias.Add(categoria2);

        }
    }
}

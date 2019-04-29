using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public BindingList<Cliente> Listadeclientes  { get; set; }

        public ClientesBL()
        {
            Listadeclientes = new BindingList<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");
            var ciudad3 = new Ciudad(3, "La Ceiba");
            var ciudad4 = new Ciudad(4, "Choloma");
            var ciudad5 = new Ciudad(5, "El Progreso");

            var cliente1 = new Cliente(1401, "Juan Perez", "8874-6978", ciudad1, "Villas del Sol");
            var cliente2 = new Cliente(1402, "Pedro Martinez", "9988-7788", ciudad2, "Colonia Kennedy");
            var cliente3 = new Cliente(1403, "Oscar Lopez", "3322-4585", ciudad1, "Jardines del Valle");
            var cliente4 = new Cliente(1404, "Luis Hernandez", "3354-4598", ciudad1, "Barrio Morazan");
            var cliente5 = new Cliente(1405, "Francisco Rosa", "9943-7301", ciudad5, "La Fragua");
            var cliente6 = new Cliente(1406, "Beatriz Garcia", "9490-4879", ciudad1, "Colonia Universidad");
            var cliente7 = new Cliente(1407, "Carmen Gonzalez", "3345-8009", ciudad4, "Colonia La Mora");
            var cliente8 = new Cliente(1408, "David Morales", "9578-6621", ciudad2, "Colonia Miramontes");
            var cliente9 = new Cliente(1409, "Maria Isabel Muñoz", "8845-2101", ciudad2, "Los Molinos");
            var cliente10 = new Cliente(1410, "Juan Jose Molina", "9962-0379", ciudad3, "Colonia El Eden");
            var cliente11 = new Cliente(1411, "Carlos Navarro", "9478-3358", ciudad1, "Colonia Zeron");
            var cliente12 = new Cliente(1412, "Jesus Torres", "3366-4310", ciudad2, "Las Palmas");
            var cliente13 = new Cliente(1413, "Javier Maldonado", "9974-1590", ciudad4, "Barrio La Primavera");
            var cliente14 = new Cliente(1414, "Olga Roblez", "8845-3650", ciudad1, "Residencial Andalucia");
            var cliente15 = new Cliente(1415, "Cristian Lara", "9532-2052", ciudad5, "Colonia Alameda");
            var cliente16 = new Cliente(1416, "Adonis Pineda", "9610-4570", ciudad5, "Barrio San Antonio");
            var cliente17 = new Cliente(1417, "Maria Isabel Alarcon", "9582-3306", ciudad1, "Colonia Valle de Sula");
            var cliente18 = new Cliente(1418, "Ana Ortega", "9478-9600", ciudad4, "Colonia Las Torres");
            var cliente19 = new Cliente(1419, "Geovany Castillo", "3320-1508", ciudad4, "Barrio San Antonio");
            var cliente20 = new Cliente(1420, "Erick Rodriguez", "9977-3720", ciudad1, "Colonia Smith");
            var cliente21 = new Cliente(1421, "Jorge Muñoz", "8825-7101", ciudad3, "Barrio Bella Vista");
            var cliente22 = new Cliente(1422, "Marta Ramirez", "9776-4000", ciudad5, "Colonia Palermo");
            var cliente23 = new Cliente(1423, "Andres Sanchez", "9920-3544", ciudad5, "Colonia Melgar");
            var cliente24 = new Cliente(1424, "Rogelio Pinto", "3399-0128", ciudad4, "Colonia Los Almendros");
            var cliente25 = new Cliente(1425, "Rafael Garcia", "8875-9101", ciudad2, "Colonia Miraflores");
            var cliente26 = new Cliente(1426, "Cristina Saez", "9530-6640", ciudad1, "Colonia Trejo");
            var cliente27 = new Cliente(1427, "Alberto Ortiz", "3365-5871", ciudad1, "Colonia Los Laureles");
            var cliente28 = new Cliente(1428, "Vicente Lozano", "8885-7122", ciudad3, "Colonia El Roble");
            var cliente29 = new Cliente(1429, "Maria Jose Perez", "9833-1518", ciudad4, "Colonia Godoy");
            var cliente30 = new Cliente(1430, "Enrique Molina", "9465-9084", ciudad5, "Colonia Berlin");

            Listadeclientes.Add(cliente1);
            Listadeclientes.Add(cliente2);
            Listadeclientes.Add(cliente3);
            Listadeclientes.Add(cliente4);
            Listadeclientes.Add(cliente5);
            Listadeclientes.Add(cliente6);
            Listadeclientes.Add(cliente7);
            Listadeclientes.Add(cliente8);
            Listadeclientes.Add(cliente9);
            Listadeclientes.Add(cliente10);
            Listadeclientes.Add(cliente11);
            Listadeclientes.Add(cliente12);
            Listadeclientes.Add(cliente13);
            Listadeclientes.Add(cliente14);
            Listadeclientes.Add(cliente15);
            Listadeclientes.Add(cliente16);
            Listadeclientes.Add(cliente17);
            Listadeclientes.Add(cliente18);
            Listadeclientes.Add(cliente19);
            Listadeclientes.Add(cliente20);
            Listadeclientes.Add(cliente21);
            Listadeclientes.Add(cliente22);
            Listadeclientes.Add(cliente23);
            Listadeclientes.Add(cliente24);
            Listadeclientes.Add(cliente25);
            Listadeclientes.Add(cliente26);
            Listadeclientes.Add(cliente27);
            Listadeclientes.Add(cliente28);
            Listadeclientes.Add(cliente29);
            Listadeclientes.Add(cliente30);

        }
    }
}

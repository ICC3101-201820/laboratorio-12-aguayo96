using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace MVC
{
    class Controlador
    {
        public Form1 form1;
        private ListaComida comidas;

        public Controlador()
        {
          comidas = new ListaComida();
        }

        public void OnAgregarComida(string nombre, int proteinas,  int carbohidratos, int grasas)
        {
            Comida comida= new Comida(nombre, proteinas, carbohidratos, grasas );
            comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }
    }
}

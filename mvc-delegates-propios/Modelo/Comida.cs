using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comida
    {
        string nombre;
        int protinas;
        int carbohidratos;
        int grasas;
        public Comida(string pNombre, int pProteinas,int pCarbohidratos, int pGrasas)
        {
            nombre = pNombre;
            protinas = pProteinas;
            carbohidratos = pCarbohidratos;
            grasas = pGrasas;
            int Calorias()
            {
                int calorias = 0;
                return calorias = 9 * pGrasas + 4 * pProteinas + 4 * pCarbohidratos;
            }
        }

        
        
    }
}

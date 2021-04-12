using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_3.Controlador.Operadores
{
    class Dividir
    {
        private double respuesta;
        Excepciones.Excepciones valida = new Excepciones.Excepciones();

        public double Dividicion(double valor1, double valor2)
        {
            if (valida.valida_Cero(valor1, valor2) == false)
            {
                respuesta = 0;
            }
            else
                respuesta = valor1 / valor2; ;
            
            return respuesta;
        }
    }
}

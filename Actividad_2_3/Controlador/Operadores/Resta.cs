using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_3.Controlador.Operadores
{
    class Resta
    {
        private double respuesta;

        public double Restar(double valor1, double valor2)
        {
            respuesta = valor1 - valor2;
            return respuesta;
        }
    }
}

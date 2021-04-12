using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_3.Controlador.Excepciones
{
    class Excepciones
    {
        private Boolean respuesta = true;

        public String exception()
        {
            String msg = "Sintaxis Error";
            return msg;
        }

        public bool isNumeric(string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta = false;
            }
        }

        public Boolean valida_Cero(Double valor1, Double valor2)
        {
            if (valor1 == 0)
            {
                respuesta = false;
            }
            else if (valor2 == 0)
            {
                respuesta = false;
            }

            return respuesta;
        }

        public Boolean valida_Nulo(Double valor1, Double valor2)
        {
            if (valor1 == null)
            {
                respuesta = false;
            }
            else if (valor2 == null)
            {
                respuesta = false;
            }

            return respuesta;
        }

    }
}

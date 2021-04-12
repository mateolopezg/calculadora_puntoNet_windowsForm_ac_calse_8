using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Actividad_2_3
{
    public partial class Calculadora : Form
    {
       
        private double resultado;
        private double valor1;
        private double valor2;

        //Operación
        //1 suma
        //2 resta
        //3 multiplicacion
        //4 division
        //5 producto
        private int operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        Controlador.Operadores.Suma suma = new Controlador.Operadores.Suma();
        Controlador.Operadores.Resta resta = new Controlador.Operadores.Resta();
        Controlador.Operadores.Multiplicar multi = new Controlador.Operadores.Multiplicar();
        Controlador.Operadores.Dividir divi = new Controlador.Operadores.Dividir();
        Controlador.Operadores.Producto producto = new Controlador.Operadores.Producto();
        Controlador.Excepciones.Excepciones excepciones = new Controlador.Excepciones.Excepciones();

        private void btn0_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "9";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void btnBorraUno_Click(object sender, EventArgs e)
        {
            if(tbPantalla.Text.Length > 1)
                tbPantalla.Text = tbPantalla.Text.Substring(0, tbPantalla.Text.Count() - 1);
            else
                tbPantalla.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                valor2 = Convert.ToInt32(tbPantalla.Text);

                switch (operacion)
                {
                    case 1:
                        resultado = suma.Sumar(valor1, valor2);
                        break;
                    case 2:
                        resultado = resta.Restar(valor1, valor2);
                        break;
                    case 3:
                        resultado = multi.Multiplicacion(valor1, valor2);
                        break;
                    case 4:
                        resultado = divi.Dividicion(valor1, valor2);
                        break;
                    case 5:
                        resultado = producto._Producto(valor1, valor2);
                        break;
                }

                tbPantalla.Text = resultado.ToString();
                valor1 = 0;
                valor2 = 0;
            }
            catch(Exception error)
            {
                tbPantalla.Text = excepciones.exception();
                Console.WriteLine(error);
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += ",";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(tbPantalla.Text);
            tbPantalla.Text = "";
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            operacion = 5;
            valor1 = Convert.ToDouble(tbPantalla.Text);
            tbPantalla.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(tbPantalla.Text);
            tbPantalla.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(tbPantalla.Text);
            tbPantalla.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(tbPantalla.Text);
            tbPantalla.Text = "";
        }
    }
}

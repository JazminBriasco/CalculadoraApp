using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraApp
{
    public partial class Form1 : Form
    {
        //Atributos para usarlos en todos los procedimientos
        private double num1 = 0;
        private double num2 = 0;
        private double resultado = 0;
        private int operacion = 0;
        public Form1()
        {
           
        InitializeComponent();
        }

        //Funciones
        //Procedimientos
        private void Sumar()
        {
            resultado = num1 + num2;
            
        }
        private void Restar()
        {
            resultado = num1 - num2;

        }
        private void Multiplicar()
        {
            resultado = num1 * num2;

        }
        private void Dividir()
        {
            resultado = num1 / num2;

        }
        
        //Deja el InputText vacío paraagregar el siguiente número.
        private void LimpiarInput()
        {
            textBoxInput.Text = "";
        }

        //Va actualizando el valor del Label para tener un seguimiento de los números
        //Según la operación varía el signo
        private void CargarLabel(double num)
        {
            string texto = "";
            switch (operacion)
            {
                case 1:
                    texto = "+";
                    break;
                case 2:
                    texto = "-";
                    break;
                case 3:
                    texto = "*";
                    break;
                case 4:
                    texto = "/";
                    break;
            }
            labelResultado.Text = labelResultado.Text + " " + texto + " " + Convert.ToString(num);
        }

        //Los eventos de los números:
        //Cada botón cuenta con un número que se muestra en el input.
        //El valor del num1 también podría darse acá.
        //No se repite mucho código?
        private void btn1_Click(object sender, EventArgs e)
        {
            
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn1.Text);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn2.Text);

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn9.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Convert.ToString(textBoxInput.Text) + Convert.ToString(btn0.Text);
        }
        //Invoca a cada operación y lo muestra en el label
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length != 0)
            {
                num2 = Convert.ToDouble(textBoxInput.Text);

                switch (operacion)
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                }

                textBoxInput.Text = Convert.ToString(resultado);
                CargarLabel(num2);
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBoxInput.Text);
            LimpiarInput();
            CargarLabel(num1);
            operacion = 1;
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBoxInput.Text);
            LimpiarInput();
            CargarLabel(num1);
            operacion = 2;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBoxInput.Text);
            LimpiarInput();
            CargarLabel(num1);
            operacion = 3;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBoxInput.Text);
            LimpiarInput();
            CargarLabel(num1);
            operacion = 4;
        }

        //Busca el último caracter del total de caracteres del string y lo elimina.
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length > 0)
            {
                int caracteres = textBoxInput.Text.Length;
                textBoxInput.Text = textBoxInput.Text.Remove(caracteres - 1);
            }
        }

     
    }
}

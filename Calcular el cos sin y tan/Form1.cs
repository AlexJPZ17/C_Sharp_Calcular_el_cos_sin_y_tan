using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_el_cos_sin_y_tan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void trigonometria()
        {
            //Declaramos las variables
            double angulo, res;
            string funcion;

            //Condición para validar el TextBox_Angulo si está vacío
            if (TextBox_Angulo.Text == "")
            {
                MessageBox.Show("Ingrese un angulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Coloca el Focus en el TextBox_Angulo
                TextBox_Angulo.Focus();
            }
            else
            {
                /*Función que convierte en un tipo double el valor que se ingrese por 
                el TextBox_Angulo y lo almacena en la variable ángulo */
                angulo = Double.Parse(TextBox_Angulo.Text);
                //Método para extraer los Item seleccionado en el ComboBox
                funcion = ComboBox_Funciones.Text;
                /*Condición que evalúa la variable función si es igual a las funciones 
                seleccionada en el ComboBox */
                if (funcion == "Funciones")
                {
                    MessageBox.Show("Seleccione una de las funciones", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    /* 
                Switch case es una estructura de control permitiéndonos controlar
                las opciones que escojamos por el ComboBox
               */
                    switch (funcion)
                    {
                        case "Cos":
                            /* Método que saca el Coseno del dato que este almacenado 
                            en la varia ángulo y lo almacena en la variable res */
                            res = Math.Cos(angulo * 2.0 * Math.PI / 360.0);
                            MessageBox.Show("El coseno del angulo " + angulo + " es " + res);
                            break;

                        case "Sin":
                            /* Método que saca el Seno del dato que este almacenado 
                            en la varia ángulo y lo almacena en la variable res */
                            res = Math.Sin(angulo * 2.0 * Math.PI / 360.0);
                            MessageBox.Show("El seno del angulo " + angulo + " es " + res);
                            break;

                        case "Tan":
                            /* Método que saca el Tangente del dato que este almacenado 
                            en la varia ángulo y lo almacena en la variable res */
                            res = Math.Tan(angulo * 2.0 * Math.PI / 360.0);
                            MessageBox.Show("El tangente del angulo " + angulo + " es " + res);
                            break;
                    }
                }
            }
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            trigonometria();
        }
    }
}

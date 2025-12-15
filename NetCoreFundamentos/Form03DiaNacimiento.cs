using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnMostarDia_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int año = int.Parse(this.txtAño.Text);

            if (mes == 1)
            {
                mes = 13;
                año --;
            }
            else if (mes == 2)
            {
                mes = 14;
                año --;
            }

            int valor1 = ((mes + 1) * 3) / 5;
            int valor2 = año / 4;
            int valor3 = año / 100;
            int valor4 = año / 400;

            int sumaTotal = dia + (mes * 2) + año + valor1 + valor2 - valor3 + valor4 + 2;
            int divisionSuma = sumaTotal / 7;

            int resultado = sumaTotal - (divisionSuma * 7);
            string resultadoDia = "";
            switch (resultado)
            {
                case 0: resultadoDia = "SÁBADO"; break;
                case 1: resultadoDia = "DOMINGO"; break;
                case 2: resultadoDia = "LUNES"; break;
                case 3: resultadoDia = "MARTES"; break;
                case 4: resultadoDia = "MIÉRCOLES"; break;
                case 5: resultadoDia = "JUEVES"; break;
                case 6: resultadoDia = "VIERNES"; break;
            }

            label4.Text = "El dia es " + resultadoDia;
        }


    }
}
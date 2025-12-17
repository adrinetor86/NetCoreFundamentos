using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnIsbn_Click(object sender, EventArgs e)
        {
            string cadena = this.txtIsbn.Text;

            if (cadena.Length == 10)
            {
                int suma = 0;
                for (int i = 0; i < cadena.Length; i++)
                {
                    int numero = int.Parse(cadena[i].ToString());

                    suma += numero * (i + 1);
                }

                if (suma % 11 == 0)
                {
                    this.lblisbn.Text = "ISBN CORRECTO";
                }
            }
            else
            {
                this.lblisbn.Text = "ISBN INCORRECTO";
                MessageBox.Show(cadena, "El ISBN DEBE TENER 10 DIGITOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void Form01SumarNumeros_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtNumero1.Text);
            int num2 = int.Parse(this.txtNumero2.Text);

            int resultado = num1 + num2;
            this.txtResultado.Text= resultado.ToString();
        }
    }
}

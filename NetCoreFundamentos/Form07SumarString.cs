using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            string cadena = this.txtSuma.Text;
            int suma=0;
            for (int i = 0; i < cadena.Length; i++)
            {
                suma+=int.Parse(cadena[i].ToString());
            }
            this.txtSuma.Text=suma.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
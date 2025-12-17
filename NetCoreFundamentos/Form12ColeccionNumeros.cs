using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaPar = 0;
            int sumaImpar = 0;
            foreach (var items in this.lstNumeros.Items)
            {
                int numero = int.Parse(items.ToString());
                sumaTotal+=numero;
                if (numero % 2 == 0)
                {
                    sumaPar+=numero;
                }
                else
                {
                    sumaImpar+=numero;
                }
            }
            this.txtSuma.Text= sumaTotal.ToString();
            this.txtPares.Text = sumaPar.ToString();
            this.txtImpares.Text = sumaImpar.ToString();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (this.lstNumeros.Items.Count > 0)
            {
                this.lstNumeros.Items.Clear();
            }
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                this.lstNumeros.Items.Add(random.Next(0,50));
            }
            
        }

        private void lstNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

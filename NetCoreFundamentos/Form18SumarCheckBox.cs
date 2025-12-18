using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckBox : Form
    {
        List<CheckBox> checks; 
        public Form18SumarCheckBox()
        {
            InitializeComponent();
            
            this.checks= new List<CheckBox>();

            foreach (CheckBox check in panel1.Controls) {

                this.checks.Add(check);
                check.Click += SumarChecks;
            }
        }

        private void SumarChecks(object? sender, EventArgs e)
        {
            CheckBox checkPulsado = (CheckBox)sender;
            int numero = int.Parse(checkPulsado.Text);
            int suma = int.Parse(this.txtSuma.Text);
            
            if (checkPulsado.Checked)
            {
                suma += numero;
            }
            else
            {
                suma -= numero;
            }

                this.txtSuma.Text = suma.ToString();

           
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox check in this.checks)
            {
                int ale = random.Next(1, 50);
                check.Text = ale.ToString();
            }

        }
    }
}

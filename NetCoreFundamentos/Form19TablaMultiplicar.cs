using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> botones = new List<Button>();
        List<TextBox> textos = new List<TextBox>();
        
        public Form19TablaMultiplicar()
        {
            InitializeComponent();

            foreach (Control elemento in this.Controls)
            {

                if (elemento is Button)
                {
                    this.botones.Add((Button)elemento);
                    elemento.Click += MultiplicarNumeros;
                }
                if (elemento is TextBox)
                {
                    this.textos.Add((TextBox)elemento);    
                }
                
             
            }

        }

        private void MultiplicarNumeros(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int numero = int.Parse(botonPulsado.Text);

            for (int i=0;i<4;i++) {

                this.textos[i].Text = (i * numero).ToString();
            }
        }
    }
}

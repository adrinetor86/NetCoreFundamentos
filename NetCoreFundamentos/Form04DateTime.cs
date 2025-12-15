using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtFecha.Text = DateTime.Now.ToString();
        }

        private void Form04DateTime_Load(object sender, EventArgs e)
        {

        }

        private void checkFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);

            if (this.checkFormato.Checked == true)
            {
                this.txtFecha.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFecha.Text= fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);
            fecha.AddDays(incremento);
            this.txtFechaFinal.Text = fecha.ToString();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06EmailValidator : Form
    {
        public Form06EmailValidator()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;

            if (email.StartsWith('@'))
            {
                MessageBox.Show("No puede empezar con un @"); 
            }
            
            if (email.Contains("@"))
            {
                if (email.IndexOf('@') != -1)
                {
                   string subCadena= email.Substring(email.IndexOf('@')+1);

                   if (subCadena.Contains("@"))
                   {
                       MessageBox.Show("No puede haber mas de un @"); 
                   }else if (!subCadena.Contains("."))
                   {
                       MessageBox.Show("Tiene que haber un ."); 
                   }

                   string subCadenaPunto = email.Substring(email.IndexOf('.') + 1);
              
                   if (subCadenaPunto.Length > 3)
                   {
                       MessageBox.Show("El dominio debe tener maximo 3 caracteres");
                   }
                   else if(subCadenaPunto.Length <2 )
                   {
                       MessageBox.Show("El dominio debe tener minimo 2 caracteres");
                   }
                   if (subCadenaPunto.Contains("."))
                   {
                       MessageBox.Show("No puede haber mas de un .");
                   }

                } 

            }
            
        }
    }
}

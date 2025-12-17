using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        //RECIBIMOS UN WRAPPER POR VALOR
        void GetDobleValor(int numero)
        {
            numero = numero * 2;
        }
        //ESTO SERIA LA FORMA CORRECTA DE DEVOLVER UN VALOR, CON UN METODO RETURN
        int GetDoble(int numero)
        {
            return numero * 2;
        }

        private void btnObjetoRef_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnObjetoRef);
            this.CambiarColor(this.btnDoble);
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //HAY QUE PONERLO TAMBIEN EN LA LLAMADA
            this.GetDobleReferencia(ref num);
            this.label4.Text = num.ToString();
        }

        private void btnDoble_Click(object sender, EventArgs e)
        {
            //AL MANDARLO POR VALOR, NO CAMBIAMOS EL VALOR ORIGINAL
            int num = int.Parse(this.txtNumero.Text);
            this.GetDoble(num);//por return
            this.GetDobleValor(num);//por valor
            this.label4.Text = num.ToString();
        }
        //SI PONEMOS ref, MANDAMOS LA DIRECCION DE MEMORIA, Y PODEMOS MODIFICAR EL VALOR ORIGINAL
        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }
        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Peru;
        }

        private void lblRaton_Click(object sender, EventArgs e)
        {

        }

        private void txtSoloNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TENEMOS UNA ENUMERACION LLAMADA Keys QUE NOS PERMITE
            //ACCEDER A LOS CODIGOS DEL TECLADO
            //DEBEMOS SABER EL CODIGO ASCII DE LA TECLA DE BORRAR
            char teclaBorrar = (char)Keys.Back;
            //EXISTE ALGUNA FORMA DE SABER SI UN CHAR ES UN NUMERO?
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEY
                e.Handled = true;
            }

        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            //EXISTE ALGUNA FORMA DE SABER SI UN CHAR ES UN NUMERO?
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEY
                e.Handled = true;
            }
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }
    }
}

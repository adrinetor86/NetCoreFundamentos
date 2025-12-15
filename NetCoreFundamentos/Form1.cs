namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.txtNombre.Location = new Point(10,30);
            this.txtNombre.Text = "Soy un texto nuevo!!!";
            this.txtNombre.Width = 220;
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.txtNombre.BackColor = Color.Fuchsia;

            //NO ES CONVERSION AUTOMATICA
            short pequeño = 88;
            int mayor = pequeño;

            //STRING A PRIMITIVO
            string textoNumero = "Hoy es viernes";
            int numero = int.Parse(textoNumero);
            double otro = double.Parse(textoNumero);

            int mayor2 = 88;
            short pequeño2 = (short)mayor2;


            string dato = pequeño.ToString();
            dato = btnPulsar.ToString();
        }
    }
}

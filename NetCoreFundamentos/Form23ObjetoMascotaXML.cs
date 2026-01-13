using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;
        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();

                if (!string.IsNullOrEmpty(mascota.imagen))
                {
                    byte[] imageBytes = Convert.FromBase64String(mascota.imagen);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        this.pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            mascota.imagen = await this.BaseImage();
            //LAS CLASES QUE SE UTILIZAN SON DE TIPO STREAM 
            //PARA ESCRIBIR NECESITAMOS LA CLASE StreamWriter
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {


                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
        }


        private async Task<string> BaseImage()
        {
            //RECUPERAMOS LA RUTA DE LA IMAGEN
            string path = this.openFileDialog1.FileName;

            // Leer el archivo y convertir a Base64
            byte[] imageArray = await File.ReadAllBytesAsync(path);
            string base64String = Convert.ToBase64String(imageArray);
            return base64String;
        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //ABRIR EL OPENFILE PARA SELECCIONAR LA IMAGEN
            this.openFileDialog1.ShowDialog();
            //RECUPERAMOS LA RUTA DE LA IMAGEN
            string path = this.openFileDialog1.FileName;
            //DIBUJAMOS LA IMAGEN EN EL FORM
            this.pictureBox1.Image = Image.FromFile(path);
   
        }
    }
}

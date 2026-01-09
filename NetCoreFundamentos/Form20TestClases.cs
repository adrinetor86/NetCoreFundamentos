using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;


namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Reyes";
            persona.Edad = 20;
            persona.Genero = TipoGenero.Masculino;
            persona.Nacionalidad = Paises.Polonia;
            persona[0] = "Vamos 1";
            persona[1] = "Vamos 2";

            this.lstClases.Items.Add("Nombre: " + persona.Nombre +
                ", Apellidos: " + persona.Apellidos +
                ", Edad: " + persona.Edad +
                ", Genero: " + persona.Genero +
                ", Nacionalidad: " + persona.Nacionalidad
                );

            this.lstClases.Items.Add(
                persona.GetNombreCompleto(true)
                );

            //PODEMOS INSTANCIARLO AQUI O EN LA CLASE PERSONA
            //persona.Domicilio = new Direccion();

            persona.Domicilio.Calle = "Avenida Enero";
            persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28003;

            this.lstClases.Items.Add("Dirección: "
                + persona.Domicilio.Calle + ", "
                + persona.Domicilio.Ciudad + ", "
                + persona.Domicilio.CodigoPostal);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado emp = new Empleado("Nombre","Apellidos");
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            this.lstClases.Items.Add("Empleado: "+ emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");
            this.lstClases.Items.Add("Vacaciones: " + emp.GetDiasVacaciones());
            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellidos = "Dire";
            this.lstClases.Items.Add("Empleado: " + dire.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dire.GetSalarioMinimo() + "€");
            this.lstClases.Items.Add("Vacaciones: " + dire.GetDiasVacaciones());
        }
    }
}

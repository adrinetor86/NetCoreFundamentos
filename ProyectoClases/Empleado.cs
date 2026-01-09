using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        
        protected int SalarioMinimo { get; set; }

        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacio");
            this.SalarioMinimo = 1600;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }

        public Empleado(string nombre, string apellido) : base(nombre, apellido)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            Debug.WriteLine("Contructor EMPLEADO con 2 parametros");
        }
        public Empleado(string nombre, string apellido,int edad) : base(nombre, apellido)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.Edad=edad;
            Debug.WriteLine("Contructor EMPLEADO con 2 parametros");
        }


    }
}

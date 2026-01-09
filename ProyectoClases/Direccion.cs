using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        public Direccion()
        {
            Debug.WriteLine("Constructor DIRECCION sin parametros");
        }

        public Direccion(string calle,string ciudad)
        {
            //INICIALIZAMOS LAS VARIABLES DE LA CLASE
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Contructor DIRECCION con dos parámetros");
        }
        public Direccion(string calle,string ciudad,int cp)
        {
            //INICIALIZAMOS LAS VARIABLES DE LA CLASE
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Contructor DIRECCION con tres parámetros");
        }
    }
}

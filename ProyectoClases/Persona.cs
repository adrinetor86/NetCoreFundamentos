using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{

    //LAS ENUMERACIONES ESTAN DENTRO DEL NAMESPACE
    public enum TipoGenero { Masculino,Femenino}
    public enum Paises { España,Polonia,Francia,Colombia,Alemania}

    public class Persona
    {

        #region CONSTRUCTORES
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacio");
            this.Domicilio = new Direccion();
        }

        public Persona(string nombre,string apellido)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            Debug.WriteLine("Contructor PERSONA con 2 parametros");
        }
      
     

        #endregion
        //EL REGION ES UNA HERRAMIENTA PARA ORGANIZARNOS EL CÓDIGO
        #region Propiedades

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set
            {
                //DEVOLVEMOS UNA DESCRIPCION ALEATORIA DE NUESTRO NUMERO
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._DescripcionThis = "Descripción " + dato;
            }
        }
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public Direccion Domicilio { get; set; }

        public Direccion DomicilioVacaciones { get; set; }

        public TipoGenero Genero
        {

            get {return this._Genero; }

            set
            {
                if(value!=TipoGenero.Masculino &&
                    value!= TipoGenero.Femenino)
                {
                    throw new Exception("Donde vas maquina");
                }
                else
                {
                    this._Genero = value;
                }
            }

        
        }
        public Paises Nacionalidad { get; set; }

        //CAMPO DE PROPIEDAD
        private int _Edad;
        public TipoGenero _Genero;
        public int Edad
        {
            //DEVOLVEMOS EL VALOR
            get { return this._Edad; }
            //ESTABLECEMOS UN VALOR
            set
            {
                if(value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
                    
            }
        }
        #endregion

        #region Metodos

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }
        public string GetNombreCompleto(int num1)
        {
            return (this.Apellidos + " " + this.Nombre).ToUpper();
        }
        public string GetNombreCompleto(int num1,int num2)
        {
            return this.GetNombreCompleto().ToLower();
        }

        public void GetNombreCompleto(string dato) { }

        #endregion
    }
}

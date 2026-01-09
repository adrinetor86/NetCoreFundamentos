using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director : Empleado
    {

        //METODO SOBRESCRITO
        public override int GetDiasVacaciones()
        {
            int vacasEmpleado = base.GetDiasVacaciones();
            Debug.WriteLine("GetVacaciones() DIRECTOR");
            return vacasEmpleado+8;
        }

        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR ");
            this.SalarioMinimo +=200 ;
        }

       
    }
}

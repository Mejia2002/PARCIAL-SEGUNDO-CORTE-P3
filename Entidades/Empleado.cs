using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public Empleado()
        {
        }

        public Empleado(string nombreEmpleado, string identificacion, double salarioBase, string estado)
        {
            NombreEmpleado = nombreEmpleado;
            Identificacion = identificacion;
            SalarioBase = salarioBase;
            Estado = estado;
        }

        public string NombreEmpleado { get; set; }
        public string Identificacion { get; set; }
        public double SalarioBase { get; set; }
        public string Estado { get; set; }

        public override string ToString()
        {
            return $"{NombreEmpleado};{Identificacion};{SalarioBase};{Estado}";
        }
    
    }

    

}

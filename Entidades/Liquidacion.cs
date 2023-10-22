using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Liquidacion
    {
        public Liquidacion()
        {
        }

        public Liquidacion(string idDetalle, int idLiquidacion, int año, int mes, string identificacionL, string nombreL, double salarioL, double salud, double pension, double auxilioTransporte, double devengado)
        {
            IdDetalle = idDetalle;
            IdLiquidacion = idLiquidacion;
            Año = año;
            Mes = mes;
            IdentificacionL = identificacionL;
            NombreL = nombreL;
            SalarioL = salarioL;
            Salud = salud;
            Pension = pension;
            AuxilioTransporte = auxilioTransporte;
            Devengado = devengado;
        }

        public string IdDetalle { get; set; }
        public int IdLiquidacion { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public string IdentificacionL { get; set; }
        public string NombreL { get; set; }
        public double SalarioL { get; set; }
        public double Salud { get; set; }
        public double Pension { get; set; }
        public double AuxilioTransporte { get; set; }
        public double Devengado { get; set; }

        public override string ToString()
        {
            return $"{IdDetalle};{IdLiquidacion};{Año};{Mes};{IdentificacionL};{NombreL};{SalarioL};{Salud};{Pension};{AuxilioTransporte};{Devengado}";
        }

    }
}

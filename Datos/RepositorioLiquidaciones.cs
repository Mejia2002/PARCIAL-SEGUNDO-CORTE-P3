using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioLiquidaciones
    {
        string filePath = "LIQUIDACIONES.txt";

        public string GuardarRegistros(Liquidacion liquidacion)
        {
            var write = new StreamWriter(filePath, true);
            write.WriteLine(liquidacion.ToString());
            write.Close();
            return $"Registro almacenado";
        }
        public string Guardar(List<Liquidacion> liquidacionList)
        {
            var write = new StreamWriter(filePath);
            foreach (var i in liquidacionList)
            {
                write.WriteLine(i.ToString());
            }
            write.Close();
            return $"Datos almacenados";
        }

        public List<Liquidacion> CargarRegistros()
        {
            var liquidacionList = new List<Liquidacion>();
            try
            {
                StreamReader reader = new StreamReader(filePath);
                while (!reader.EndOfStream)
                {
                    liquidacionList.Add(Map(reader.ReadLine()));
                }
                reader.Close();
                return liquidacionList;
            }
            catch (IOException)
            {
                return null;
            }
        }

        private Liquidacion Map(string line)
        {
            var productoL = new Liquidacion();
            var datosL = line.Split(';');

            productoL.IdDetalle = (datosL[0]);
            productoL.IdLiquidacion = int.Parse(datosL[1]);
            productoL.Año = int.Parse(datosL[2]);
            productoL.Mes = int.Parse(datosL[3]);
            productoL.IdentificacionL = (datosL[4]);
            productoL.NombreL = (datosL[5]);
            productoL.SalarioL = Convert.ToDouble(datosL[6]);
            productoL.Salud = Convert.ToDouble(datosL[7]);
            productoL.AuxilioTransporte = Convert.ToDouble(datosL[8]);
            productoL.Devengado = Convert.ToDouble(datosL[9]);
            return productoL;

        }
        
    }
}

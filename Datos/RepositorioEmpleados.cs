using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
    public class RepositorioEmpleados
    {
        string filePath = "EMPLEADOS.txt";

        public string GuardarRegistros(Empleado empleado)
        {
            var write = new StreamWriter(filePath, true);
            write.WriteLine(empleado.ToString());
            write.Close();
            return $"Registro almacenado";
        }
        public string Guardar(List<Empleado> empleadoList)
        {
            var write = new StreamWriter(filePath);
            foreach (var i in empleadoList)
            {
                write.WriteLine(i.ToString());
            }
            write.Close();
            return $"Datos almacenados";
        }

        public List<Empleado> CargarRegistros()
        {
            var empleadoList = new List<Empleado>();
            try
            {
                StreamReader reader = new StreamReader(filePath);
                while (!reader.EndOfStream)
                {
                    empleadoList.Add(Map(reader.ReadLine()));
                }
                reader.Close();
                return empleadoList;
            }
            catch (IOException)
            {
                return null;
            }
        }

        private Empleado Map(string line)
        {
            var producto = new Empleado();
            var datos = line.Split(';');

            producto.NombreEmpleado = datos[0];
            producto.Identificacion = datos[1];
            producto.SalarioBase = double.Parse(datos[2]);
            producto.Estado = (datos[3]);
 
            return producto;
        }
    }
}

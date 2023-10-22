using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;
using Datos;

namespace Logica
{
    public class EmpleadoService
    {
        private RepositorioEmpleados repositorioEmpleados = null;
        private List<Empleado> empleadoList = null;

        public EmpleadoService()
        {
            repositorioEmpleados = new RepositorioEmpleados();
            empleadoList = repositorioEmpleados.CargarRegistros();

        }
        public String GuardarRegistros(Empleado empleado)
        {
            if (empleado.Identificacion == null || empleado.NombreEmpleado == null
                || empleado.SalarioBase == 0 || empleado.Estado == null)
            {
                return $"Campos nulos";
            }
            var message = (repositorioEmpleados.GuardarRegistros(empleado));
            empleadoList = repositorioEmpleados.CargarRegistros();
            return message;
        }
        public List<Empleado> CargarRegistros()
        {
            return empleadoList;
        }
        public string EliminarRegistro(string idAEliminar)
        {
            try
            {
                var EmpleadoAEliminar = empleadoList.FirstOrDefault(p => p.Identificacion == idAEliminar);

                if (EmpleadoAEliminar != null)
                {
                    empleadoList.Remove(EmpleadoAEliminar);
                    repositorioEmpleados.Guardar(empleadoList);
                    return "Registro eliminado con éxito.";
                }
                else
                {
                    return "No se encontró un registro con el ID proporcionado.";
                }
            }
            catch (IOException)
            {
                return "Ocurrió un error al intentar eliminar el registro.";
            }
        }

        public Empleado BuscarPotId(string id)
        {
            foreach (var item in empleadoList)
            {
                if (id == item.Identificacion)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Empleado> ConsultarTodos()
        {
            return empleadoList;
        }
        public List<Empleado> ConsultarFiltrado(string filtro)
        {
            if (filtro == "")
            {
                return empleadoList;
            }
            List<Empleado> lista = new List<Empleado>();
            foreach (var item in empleadoList)
            {
                if (item.NombreEmpleado.Contains(filtro) || item.Identificacion.StartsWith(filtro))
                {
                    lista.Add(item);
                }
            }
            return lista;
        }
    }
}

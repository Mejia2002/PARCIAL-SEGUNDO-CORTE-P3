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
    public class LiquidacionService
    {
        private RepositorioLiquidaciones repositorioLiquidaciones = null;
        private List<Liquidacion> liquidacionList = null;

        public LiquidacionService()
        {
            repositorioLiquidaciones = new RepositorioLiquidaciones();
            liquidacionList = repositorioLiquidaciones.CargarRegistros();

        }
        public String GuardarRegistros(Liquidacion liquidacion)
        {
            if (liquidacion.IdentificacionL == null || liquidacion.NombreL == null
                || liquidacion.SalarioL == 0 || liquidacion.IdDetalle == null || liquidacion.IdLiquidacion == 0 || liquidacion.Salud ==0 || liquidacion.Pension == 0 || liquidacion.Año == 0 || liquidacion.Mes == 0) 
            {
                return $"Campos nulos";
            }
            var message = (repositorioLiquidaciones.GuardarRegistros(liquidacion));
            liquidacionList = repositorioLiquidaciones.CargarRegistros();
            return message;
        }
        public List<Liquidacion> CargarRegistros()
        {
            return liquidacionList;
        }
        public string EliminarRegistro(string idAEliminar)
        {
            try
            {
                var LiquidacionAEliminar = liquidacionList.FirstOrDefault(p => p.IdDetalle == idAEliminar);

                if (LiquidacionAEliminar != null)
                {
                    liquidacionList.Remove(LiquidacionAEliminar);
                    repositorioLiquidaciones.Guardar(liquidacionList);
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

        public Liquidacion BuscarPotId(string id)
        {
            foreach (var item in liquidacionList)
            {
                if (id == item.IdDetalle)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Liquidacion> ConsultarTodos()
        {
            return liquidacionList;
        }
        public List<Liquidacion> ConsultarFiltrado(string filtro)
        {
            if (filtro == "")
            {
                return liquidacionList;
            }
            List<Liquidacion> lista = new List<Liquidacion>();
            foreach (var item in liquidacionList)
            {
                if (item.NombreL.Contains(filtro) || item.IdentificacionL.StartsWith(filtro))
                {
                    lista.Add(item);
                }
            }
            return lista;
        }
    }
}

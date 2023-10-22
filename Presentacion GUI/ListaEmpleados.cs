using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion_GUI
{
    public partial class ListaEmpleados : Form
    {
        EmpleadoService servicio = new EmpleadoService();
        public ListaEmpleados()
        {
            InitializeComponent();
        }

        private void CargarEstablecimientos1()
        {
            dgvEmpleados.DataSource = servicio.ConsultarTodos();
        }
        private void CargarEstablecimientos2()
        {
            var lista = servicio.ConsultarTodos();

            foreach (var item in lista)
            {
                dgv2.Rows.Add(item.NombreEmpleado,
                    item.Identificacion,
                    item.SalarioBase.ToString(),
                    item.Estado.ToString()
                    );
            }
        }

        private void CargarEstablecimientosFiltrado(string filtro)
        {
            dgvEmpleados.DataSource = servicio.ConsultarFiltrado(filtro);
        }

        private void FormularioListaEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.Columns["Nombre"].HeaderText = "Nombre del Empleado";
            dgvEmpleados.Columns["Identificacion"].HeaderText = "Identificación del Empleado";
            dgvEmpleados.Columns["SalarioBase"].HeaderText = "Salario Base del Empleado";
            dgvEmpleados.Columns["Estado"].HeaderText = "Estado del Empleado";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

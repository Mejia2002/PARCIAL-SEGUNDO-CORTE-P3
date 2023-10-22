using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace Presentacion_GUI
{
    public partial class Empleado : Form
    {
        EmpleadoService servicio = new EmpleadoService();
        public Empleado()
        {
            InitializeComponent();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtSalarioBase.Clear();
            txtEstado.SelectedIndex = -1;
        }
        void Salir()
        {
            this.Close();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalarioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void Guardar(Entidades.Empleado empleado)
        {

            var msg = servicio.GuardarRegistros(empleado);
            MessageBox.Show(msg);

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Guardar(new Entidades.Empleado(txtNombre.Text, txtIdentificacion.Text, double.Parse(txtSalarioBase.Text), txtEstado.Text));
        }

        void Buscar(string id)
        {
            var empleado = servicio.BuscarPotId(id);
            VerEmpleado(empleado);
        }

        void VerEmpleado(Entidades.Empleado empleado)
        {
            txtNombre.Text = empleado.NombreEmpleado;
            txtIdentificacion.Text = empleado.Identificacion;
            txtSalarioBase.Text = empleado.SalarioBase.ToString();
            txtEstado.Text = empleado.Estado;
            
        }

    }
}

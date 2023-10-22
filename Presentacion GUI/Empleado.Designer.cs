namespace Presentacion_GUI
{
    partial class Empleado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtSalarioBase);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR EMPLEADO";
            // 
            // txtEstado
            // 
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txtEstado.Location = new System.Drawing.Point(122, 169);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 21);
            this.txtEstado.TabIndex = 7;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(122, 131);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioBase.TabIndex = 6;
            this.txtSalarioBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioBase_KeyPress);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(122, 89);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 5;
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonSalir);
            this.groupBox2.Controls.Add(this.botonBuscar);
            this.groupBox2.Controls.Add(this.botonEliminar);
            this.groupBox2.Controls.Add(this.botonNuevo);
            this.groupBox2.Controls.Add(this.botonGuardar);
            this.groupBox2.Location = new System.Drawing.Point(36, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(394, 28);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 4;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(297, 28);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(202, 28);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 2;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(109, 28);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 1;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(18, 28);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 0;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Empleado";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonGuardar;
    }
}


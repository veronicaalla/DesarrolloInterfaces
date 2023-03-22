namespace UT2E2_Veronica
{
    partial class FichaSocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbOtros = new System.Windows.Forms.RadioButton();
            this.grbAficiones = new System.Windows.Forms.GroupBox();
            this.txtAficciones = new System.Windows.Forms.TextBox();
            this.chkOtros = new System.Windows.Forms.CheckBox();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkMusica = new System.Windows.Forms.CheckBox();
            this.chkDeportes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSituacion = new System.Windows.Forms.ComboBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbAficiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nacimiento";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(88, 75);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(275, 20);
            this.dtpNacimiento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo";
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Checked = true;
            this.rbHombre.Location = new System.Drawing.Point(88, 118);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 5;
            this.rbHombre.TabStop = true;
            this.rbHombre.Tag = "Hombre";
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.rbSexo_CheckedChanged);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(196, 118);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 6;
            this.rbMujer.Tag = "Mujer";
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            this.rbMujer.CheckedChanged += new System.EventHandler(this.rbSexo_CheckedChanged);
            // 
            // rbOtros
            // 
            this.rbOtros.AutoSize = true;
            this.rbOtros.Location = new System.Drawing.Point(296, 118);
            this.rbOtros.Name = "rbOtros";
            this.rbOtros.Size = new System.Drawing.Size(50, 17);
            this.rbOtros.TabIndex = 7;
            this.rbOtros.Tag = "Otros";
            this.rbOtros.Text = "Otros";
            this.rbOtros.UseVisualStyleBackColor = true;
            this.rbOtros.CheckedChanged += new System.EventHandler(this.rbSexo_CheckedChanged);
            // 
            // grbAficiones
            // 
            this.grbAficiones.Controls.Add(this.txtAficciones);
            this.grbAficiones.Controls.Add(this.chkOtros);
            this.grbAficiones.Controls.Add(this.chkLectura);
            this.grbAficiones.Controls.Add(this.chkMusica);
            this.grbAficiones.Controls.Add(this.chkDeportes);
            this.grbAficiones.Location = new System.Drawing.Point(25, 157);
            this.grbAficiones.Name = "grbAficiones";
            this.grbAficiones.Size = new System.Drawing.Size(340, 151);
            this.grbAficiones.TabIndex = 8;
            this.grbAficiones.TabStop = false;
            this.grbAficiones.Text = "Aficiones";
            // 
            // txtAficciones
            // 
            this.txtAficciones.Enabled = false;
            this.txtAficciones.Location = new System.Drawing.Point(16, 68);
            this.txtAficciones.Multiline = true;
            this.txtAficciones.Name = "txtAficciones";
            this.txtAficciones.Size = new System.Drawing.Size(297, 67);
            this.txtAficciones.TabIndex = 4;
            // 
            // chkOtros
            // 
            this.chkOtros.AutoSize = true;
            this.chkOtros.Location = new System.Drawing.Point(262, 35);
            this.chkOtros.Name = "chkOtros";
            this.chkOtros.Size = new System.Drawing.Size(51, 17);
            this.chkOtros.TabIndex = 3;
            this.chkOtros.Tag = "Otros";
            this.chkOtros.Text = "Otros";
            this.chkOtros.UseVisualStyleBackColor = true;
            this.chkOtros.CheckedChanged += new System.EventHandler(this.chkOtros_CheckedChanged);
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.Location = new System.Drawing.Point(173, 35);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(62, 17);
            this.chkLectura.TabIndex = 2;
            this.chkLectura.Tag = "Lectura";
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            this.chkMusica.AutoSize = true;
            this.chkMusica.Location = new System.Drawing.Point(102, 35);
            this.chkMusica.Name = "chkMusica";
            this.chkMusica.Size = new System.Drawing.Size(60, 17);
            this.chkMusica.TabIndex = 1;
            this.chkMusica.Tag = "Musica";
            this.chkMusica.Text = "Musica";
            this.chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeportes
            // 
            this.chkDeportes.AutoSize = true;
            this.chkDeportes.Location = new System.Drawing.Point(16, 35);
            this.chkDeportes.Name = "chkDeportes";
            this.chkDeportes.Size = new System.Drawing.Size(69, 17);
            this.chkDeportes.TabIndex = 0;
            this.chkDeportes.Tag = "Deportes";
            this.chkDeportes.Text = "Deportes";
            this.chkDeportes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Situación";
            // 
            // cmbSituacion
            // 
            this.cmbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacion.FormattingEnabled = true;
            this.cmbSituacion.Items.AddRange(new object[] {
            "Becario",
            "Empleado",
            "Excedencia",
            "Jubilado "});
            this.cmbSituacion.Location = new System.Drawing.Point(79, 325);
            this.cmbSituacion.Name = "cmbSituacion";
            this.cmbSituacion.Size = new System.Drawing.Size(210, 21);
            this.cmbSituacion.TabIndex = 10;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(196, 367);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 11;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(278, 367);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FichaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 403);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.cmbSituacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbAficiones);
            this.Controls.Add(this.rbOtros);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FichaSocio";
            this.Text = "Ficha Socio";
            this.grbAficiones.ResumeLayout(false);
            this.grbAficiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbOtros;
        private System.Windows.Forms.GroupBox grbAficiones;
        private System.Windows.Forms.TextBox txtAficciones;
        private System.Windows.Forms.CheckBox chkOtros;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.CheckBox chkDeportes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSituacion;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnAceptar;
    }
}


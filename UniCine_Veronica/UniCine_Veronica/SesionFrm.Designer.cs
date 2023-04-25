namespace UniCine_Veronica
{
    partial class SesionFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAforo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.cmbDiaSemana = new System.Windows.Forms.ComboBox();
            this.dtpComienzo = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia Semana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comienzo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fin";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(79, 98);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // txtAforo
            // 
            this.txtAforo.Location = new System.Drawing.Point(308, 98);
            this.txtAforo.Name = "txtAforo";
            this.txtAforo.Size = new System.Drawing.Size(100, 20);
            this.txtAforo.TabIndex = 6;
            this.txtAforo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAforo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aforo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Location = new System.Drawing.Point(146, 150);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(227, 150);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Items.AddRange(new object[] {
            "SALA 1",
            "SALA 2",
            "SALA 3",
            "SALA 4",
            "SALA 5",
            "SALA 6",
            "SALA 7"});
            this.cmbSala.Location = new System.Drawing.Point(79, 30);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(100, 21);
            this.cmbSala.TabIndex = 1;
            // 
            // cmbDiaSemana
            // 
            this.cmbDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaSemana.FormattingEnabled = true;
            this.cmbDiaSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cmbDiaSemana.Location = new System.Drawing.Point(308, 25);
            this.cmbDiaSemana.Name = "cmbDiaSemana";
            this.cmbDiaSemana.Size = new System.Drawing.Size(100, 21);
            this.cmbDiaSemana.TabIndex = 2;
            // 
            // dtpComienzo
            // 
            this.dtpComienzo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpComienzo.Location = new System.Drawing.Point(79, 68);
            this.dtpComienzo.MaxDate = new System.DateTime(1753, 1, 2, 0, 0, 0, 0);
            this.dtpComienzo.Name = "dtpComienzo";
            this.dtpComienzo.Size = new System.Drawing.Size(100, 20);
            this.dtpComienzo.TabIndex = 3;
            this.dtpComienzo.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFin.Location = new System.Drawing.Point(308, 68);
            this.dtpFin.MaxDate = new System.DateTime(1753, 1, 2, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFin.TabIndex = 4;
            this.dtpFin.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // SesionFrm
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(451, 184);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpComienzo);
            this.Controls.Add(this.cmbDiaSemana);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtAforo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SesionFrm";
            this.Text = "Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAforo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.ComboBox cmbDiaSemana;
        private System.Windows.Forms.DateTimePicker dtpComienzo;
        private System.Windows.Forms.DateTimePicker dtpFin;
    }
}
namespace UniCine_Veronica
{
    partial class PeliculaFrm
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
            this.label5 = new System.Windows.Forms.Label();
            this.Sinopsis = new System.Windows.Forms.GroupBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.brnCancelar = new System.Windows.Forms.Button();
            this.Sinopsis.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duración";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Género";
            // 
            // Sinopsis
            // 
            this.Sinopsis.Controls.Add(this.txtSinopsis);
            this.Sinopsis.Location = new System.Drawing.Point(25, 167);
            this.Sinopsis.Name = "Sinopsis";
            this.Sinopsis.Size = new System.Drawing.Size(483, 163);
            this.Sinopsis.TabIndex = 5;
            this.Sinopsis.TabStop = false;
            this.Sinopsis.Text = "Sinopsis";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopsis.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSinopsis.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSinopsis.Location = new System.Drawing.Point(15, 19);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(449, 127);
            this.txtSinopsis.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(72, 69);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(137, 20);
            this.txtDuracion.TabIndex = 2;
            this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracion_KeyPress);
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(72, 111);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(243, 20);
            this.txtAnno.TabIndex = 3;
            this.txtAnno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnno_KeyPress);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Todos",
            ">12",
            ">16",
            ">18"});
            this.cmbCategoria.Location = new System.Drawing.Point(383, 30);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(140, 21);
            this.cmbCategoria.TabIndex = 4;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Acción",
            "Aventura",
            "Terror",
            "Comedia",
            "Romance"});
            this.cmbGenero.Location = new System.Drawing.Point(383, 69);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(140, 21);
            this.cmbGenero.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(193, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // brnCancelar
            // 
            this.brnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brnCancelar.Location = new System.Drawing.Point(274, 357);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Size = new System.Drawing.Size(75, 23);
            this.brnCancelar.TabIndex = 8;
            this.brnCancelar.Text = "Cancelar";
            this.brnCancelar.UseVisualStyleBackColor = true;
            this.brnCancelar.Click += new System.EventHandler(this.brnCancelar_Click);
            // 
            // PeliculaFrm
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.brnCancelar;
            this.ClientSize = new System.Drawing.Size(547, 410);
            this.Controls.Add(this.brnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtAnno);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Sinopsis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PeliculaFrm";
            this.Text = "Pelicula";
            this.Sinopsis.ResumeLayout(false);
            this.Sinopsis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Sinopsis;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button brnCancelar;
    }
}
namespace UniCine_Veronica
{
    partial class ProyeccionesFrm
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
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.btnAcpetar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.lupa = new System.Windows.Forms.PictureBox();
            this.txtSesion = new System.Windows.Forms.TextBox();
            this.lupaSala = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupaSala)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Incio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fin";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(67, 26);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(164, 20);
            this.txtPelicula.TabIndex = 1;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(328, 72);
            this.txtFin.MaxLength = 10;
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(192, 20);
            this.txtFin.TabIndex = 4;
            this.txtFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFin_KeyPress);
            this.txtFin.Leave += new System.EventHandler(this.txtFin_Leave);
            this.txtFin.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtFin_PreviewKeyDown);
            // 
            // btnAcpetar
            // 
            this.btnAcpetar.Location = new System.Drawing.Point(199, 123);
            this.btnAcpetar.Name = "btnAcpetar";
            this.btnAcpetar.Size = new System.Drawing.Size(75, 23);
            this.btnAcpetar.TabIndex = 5;
            this.btnAcpetar.Text = "Aceptar";
            this.btnAcpetar.UseVisualStyleBackColor = true;
            this.btnAcpetar.Click += new System.EventHandler(this.btnAcpetar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(294, 123);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(67, 72);
            this.txtInicio.MaxLength = 10;
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(192, 20);
            this.txtInicio.TabIndex = 3;
            this.txtInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInicio_KeyPress);
            this.txtInicio.Leave += new System.EventHandler(this.txtInicio_Leave);
            this.txtInicio.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtInicio_PreviewKeyDown);
            // 
            // lupa
            // 
            this.lupa.Image = global::UniCine_Veronica.Properties.Resources.lupa;
            this.lupa.Location = new System.Drawing.Point(237, 20);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(22, 26);
            this.lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lupa.TabIndex = 13;
            this.lupa.TabStop = false;
            this.lupa.Click += new System.EventHandler(this.lupa_Click);
            // 
            // txtSesion
            // 
            this.txtSesion.Location = new System.Drawing.Point(328, 22);
            this.txtSesion.Multiline = true;
            this.txtSesion.Name = "txtSesion";
            this.txtSesion.Size = new System.Drawing.Size(192, 40);
            this.txtSesion.TabIndex = 14;
            // 
            // lupaSala
            // 
            this.lupaSala.Image = global::UniCine_Veronica.Properties.Resources.lupa;
            this.lupaSala.Location = new System.Drawing.Point(536, 26);
            this.lupaSala.Name = "lupaSala";
            this.lupaSala.Size = new System.Drawing.Size(32, 33);
            this.lupaSala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lupaSala.TabIndex = 15;
            this.lupaSala.TabStop = false;
            this.lupaSala.Click += new System.EventHandler(this.lupaSala_Click);
            // 
            // ProyeccionesFrm
            // 
            this.AcceptButton = this.btnAcpetar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(636, 158);
            this.Controls.Add(this.lupaSala);
            this.Controls.Add(this.txtSesion);
            this.Controls.Add(this.lupa);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcpetar);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProyeccionesFrm";
            this.Text = "Proyeccion";
            ((System.ComponentModel.ISupportInitialize)(this.lupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupaSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Button btnAcpetar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.PictureBox lupa;
        private System.Windows.Forms.TextBox txtSesion;
        private System.Windows.Forms.PictureBox lupaSala;
    }
}
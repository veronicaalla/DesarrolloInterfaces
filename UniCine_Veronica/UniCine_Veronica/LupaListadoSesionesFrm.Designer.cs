namespace UniCine_Veronica
{
    partial class LupaListadoSesionesFrm
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
            this.lvSesiones = new System.Windows.Forms.ListView();
            this.chSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiaSemana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComienzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAforo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSesiones
            // 
            this.lvSesiones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSala,
            this.chDiaSemana,
            this.chComienzo,
            this.chFin,
            this.chPrecio,
            this.chAforo});
            this.lvSesiones.FullRowSelect = true;
            this.lvSesiones.GridLines = true;
            this.lvSesiones.HideSelection = false;
            this.lvSesiones.Location = new System.Drawing.Point(28, 53);
            this.lvSesiones.MultiSelect = false;
            this.lvSesiones.Name = "lvSesiones";
            this.lvSesiones.Size = new System.Drawing.Size(716, 340);
            this.lvSesiones.TabIndex = 2;
            this.lvSesiones.UseCompatibleStateImageBehavior = false;
            this.lvSesiones.View = System.Windows.Forms.View.Details;
            this.lvSesiones.DoubleClick += new System.EventHandler(this.lvSesiones_DoubleClick);
            // 
            // chSala
            // 
            this.chSala.Text = "Sala";
            this.chSala.Width = 111;
            // 
            // chDiaSemana
            // 
            this.chDiaSemana.Text = "Dia";
            this.chDiaSemana.Width = 129;
            // 
            // chComienzo
            // 
            this.chComienzo.Text = "Comienzo";
            this.chComienzo.Width = 128;
            // 
            // chFin
            // 
            this.chFin.Text = "Fin";
            this.chFin.Width = 110;
            // 
            // chPrecio
            // 
            this.chPrecio.Text = "Precio";
            this.chPrecio.Width = 98;
            // 
            // chAforo
            // 
            this.chAforo.Text = "Aforo";
            this.chAforo.Width = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sala";
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "TODOS",
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cmbDia.Location = new System.Drawing.Point(54, 14);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(188, 21);
            this.cmbDia.TabIndex = 5;
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Items.AddRange(new object[] {
            "TODAS",
            "SALA 1",
            "SALA 2",
            "SALA 3",
            "SALA 4",
            "SALA 5",
            "SALA 6",
            "SALA 7"});
            this.cmbSala.Location = new System.Drawing.Point(363, 14);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(207, 21);
            this.cmbSala.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(620, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(124, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // LupaListadoSesionesFrm
            // 
            this.AcceptButton = this.btnFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 406);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSesiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LupaListadoSesionesFrm";
            this.Text = "Buscar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSesiones;
        private System.Windows.Forms.ColumnHeader chSala;
        private System.Windows.Forms.ColumnHeader chDiaSemana;
        private System.Windows.Forms.ColumnHeader chComienzo;
        private System.Windows.Forms.ColumnHeader chFin;
        private System.Windows.Forms.ColumnHeader chPrecio;
        private System.Windows.Forms.ColumnHeader chAforo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Button btnFiltrar;
    }
}
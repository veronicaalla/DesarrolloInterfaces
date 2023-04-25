namespace UniCine_Veronica
{
    partial class ListadoSesionesFrm
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
            this.components = new System.ComponentModel.Container();
            this.MenuListado = new System.Windows.Forms.MenuStrip();
            this.tsmiSesiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevaSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.lvSesiones = new System.Windows.Forms.ListView();
            this.chSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiaSemana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComienzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAforo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSesiones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuListado.SuspendLayout();
            this.cmsSesiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuListado
            // 
            this.MenuListado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSesiones});
            this.MenuListado.Location = new System.Drawing.Point(0, 0);
            this.MenuListado.Name = "MenuListado";
            this.MenuListado.Size = new System.Drawing.Size(800, 24);
            this.MenuListado.TabIndex = 0;
            this.MenuListado.Text = "MenuListado";
            // 
            // tsmiSesiones
            // 
            this.tsmiSesiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevaSesion});
            this.tsmiSesiones.Name = "tsmiSesiones";
            this.tsmiSesiones.Size = new System.Drawing.Size(53, 20);
            this.tsmiSesiones.Text = "Sesion";
            // 
            // tsmiNuevaSesion
            // 
            this.tsmiNuevaSesion.Name = "tsmiNuevaSesion";
            this.tsmiNuevaSesion.Size = new System.Drawing.Size(108, 22);
            this.tsmiNuevaSesion.Text = "Nueva";
            this.tsmiNuevaSesion.Click += new System.EventHandler(this.tsmiNuevaSesion_Click);
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
            this.lvSesiones.ContextMenuStrip = this.cmsSesiones;
            this.lvSesiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSesiones.FullRowSelect = true;
            this.lvSesiones.GridLines = true;
            this.lvSesiones.HideSelection = false;
            this.lvSesiones.Location = new System.Drawing.Point(0, 24);
            this.lvSesiones.MultiSelect = false;
            this.lvSesiones.Name = "lvSesiones";
            this.lvSesiones.Size = new System.Drawing.Size(800, 426);
            this.lvSesiones.TabIndex = 1;
            this.lvSesiones.UseCompatibleStateImageBehavior = false;
            this.lvSesiones.View = System.Windows.Forms.View.Details;
            this.lvSesiones.DoubleClick += new System.EventHandler(this.lvSesiones_DoubleClick);
            // 
            // chSala
            // 
            this.chSala.Text = "Sala";
            this.chSala.Width = 143;
            // 
            // chDiaSemana
            // 
            this.chDiaSemana.Text = "Dia Semana";
            this.chDiaSemana.Width = 147;
            // 
            // chComienzo
            // 
            this.chComienzo.Text = "Comienzo";
            this.chComienzo.Width = 126;
            // 
            // chFin
            // 
            this.chFin.Text = "Fin";
            this.chFin.Width = 126;
            // 
            // chPrecio
            // 
            this.chPrecio.Text = "Precio";
            this.chPrecio.Width = 92;
            // 
            // chAforo
            // 
            this.chAforo.Text = "Aforo";
            this.chAforo.Width = 108;
            // 
            // cmsSesiones
            // 
            this.cmsSesiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCrear,
            this.cmsVer,
            this.cmsBorrar});
            this.cmsSesiones.Name = "cmsSesiones";
            this.cmsSesiones.Size = new System.Drawing.Size(107, 70);
            this.cmsSesiones.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSesiones_Opening);
            // 
            // cmsCrear
            // 
            this.cmsCrear.Name = "cmsCrear";
            this.cmsCrear.Size = new System.Drawing.Size(106, 22);
            this.cmsCrear.Text = "Crear";
            this.cmsCrear.Click += new System.EventHandler(this.cmsCrear_Click);
            // 
            // cmsVer
            // 
            this.cmsVer.Name = "cmsVer";
            this.cmsVer.Size = new System.Drawing.Size(106, 22);
            this.cmsVer.Text = "Ver";
            this.cmsVer.Click += new System.EventHandler(this.cmsVer_Click);
            // 
            // cmsBorrar
            // 
            this.cmsBorrar.Name = "cmsBorrar";
            this.cmsBorrar.Size = new System.Drawing.Size(106, 22);
            this.cmsBorrar.Text = "Borrar";
            this.cmsBorrar.Click += new System.EventHandler(this.cmsBorrar_Click);
            // 
            // ListadoSesionesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvSesiones);
            this.Controls.Add(this.MenuListado);
            this.MainMenuStrip = this.MenuListado;
            this.Name = "ListadoSesionesFrm";
            this.Text = "Listado Sesiones";
            this.MenuListado.ResumeLayout(false);
            this.MenuListado.PerformLayout();
            this.cmsSesiones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuListado;
        private System.Windows.Forms.ToolStripMenuItem tsmiSesiones;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevaSesion;
        private System.Windows.Forms.ListView lvSesiones;
        private System.Windows.Forms.ColumnHeader chSala;
        private System.Windows.Forms.ColumnHeader chDiaSemana;
        private System.Windows.Forms.ColumnHeader chComienzo;
        private System.Windows.Forms.ColumnHeader chFin;
        private System.Windows.Forms.ColumnHeader chPrecio;
        private System.Windows.Forms.ColumnHeader chAforo;
        private System.Windows.Forms.ContextMenuStrip cmsSesiones;
        private System.Windows.Forms.ToolStripMenuItem cmsCrear;
        private System.Windows.Forms.ToolStripMenuItem cmsVer;
        private System.Windows.Forms.ToolStripMenuItem cmsBorrar;
    }
}
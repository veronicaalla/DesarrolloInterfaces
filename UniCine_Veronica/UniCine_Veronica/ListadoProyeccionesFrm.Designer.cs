namespace UniCine_Veronica
{
    partial class ListadoProyeccionesFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proyeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsProyecciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.lvProyecciones = new System.Windows.Forms.ListView();
            this.chPelicula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChSesion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.cmsProyecciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyeccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proyeccionToolStripMenuItem
            // 
            this.proyeccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNueva});
            this.proyeccionToolStripMenuItem.Name = "proyeccionToolStripMenuItem";
            this.proyeccionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.proyeccionToolStripMenuItem.Text = "Proyeccion";
            // 
            // tsmiNueva
            // 
            this.tsmiNueva.Name = "tsmiNueva";
            this.tsmiNueva.Size = new System.Drawing.Size(108, 22);
            this.tsmiNueva.Text = "Nueva";
            this.tsmiNueva.Click += new System.EventHandler(this.tsmiNueva_Click);
            // 
            // cmsProyecciones
            // 
            this.cmsProyecciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNueva,
            this.cmsVer,
            this.cmsBorrar});
            this.cmsProyecciones.Name = "cmsProyecciones";
            this.cmsProyecciones.Size = new System.Drawing.Size(109, 70);
            this.cmsProyecciones.Opening += new System.ComponentModel.CancelEventHandler(this.cmsProyecciones_Opening);
            // 
            // cmsNueva
            // 
            this.cmsNueva.Name = "cmsNueva";
            this.cmsNueva.Size = new System.Drawing.Size(108, 22);
            this.cmsNueva.Text = "Nueva";
            this.cmsNueva.Click += new System.EventHandler(this.cmsNueva_Click);
            // 
            // cmsVer
            // 
            this.cmsVer.Name = "cmsVer";
            this.cmsVer.Size = new System.Drawing.Size(108, 22);
            this.cmsVer.Text = "Ver";
            this.cmsVer.Click += new System.EventHandler(this.cmsVer_Click);
            // 
            // cmsBorrar
            // 
            this.cmsBorrar.Name = "cmsBorrar";
            this.cmsBorrar.Size = new System.Drawing.Size(108, 22);
            this.cmsBorrar.Text = "Borrar";
            this.cmsBorrar.Click += new System.EventHandler(this.cmsBorrar_Click);
            // 
            // lvProyecciones
            // 
            this.lvProyecciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPelicula,
            this.ChSesion,
            this.chInicio,
            this.chFin});
            this.lvProyecciones.ContextMenuStrip = this.cmsProyecciones;
            this.lvProyecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProyecciones.FullRowSelect = true;
            this.lvProyecciones.GridLines = true;
            this.lvProyecciones.HideSelection = false;
            this.lvProyecciones.Location = new System.Drawing.Point(0, 24);
            this.lvProyecciones.MultiSelect = false;
            this.lvProyecciones.Name = "lvProyecciones";
            this.lvProyecciones.Size = new System.Drawing.Size(800, 426);
            this.lvProyecciones.TabIndex = 1;
            this.lvProyecciones.UseCompatibleStateImageBehavior = false;
            this.lvProyecciones.View = System.Windows.Forms.View.Details;
            this.lvProyecciones.DoubleClick += new System.EventHandler(this.lvProyecciones_DoubleClick);
            // 
            // chPelicula
            // 
            this.chPelicula.Text = "Pelicula";
            this.chPelicula.Width = 268;
            // 
            // ChSesion
            // 
            this.ChSesion.Text = "Sesion";
            this.ChSesion.Width = 189;
            // 
            // chInicio
            // 
            this.chInicio.Text = "Inicio";
            this.chInicio.Width = 140;
            // 
            // chFin
            // 
            this.chFin.Text = "Fin";
            this.chFin.Width = 154;
            // 
            // ListadoProyeccionesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvProyecciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListadoProyeccionesFrm";
            this.Text = "Listado Proyecciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsProyecciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proyeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNueva;
        private System.Windows.Forms.ContextMenuStrip cmsProyecciones;
        private System.Windows.Forms.ToolStripMenuItem cmsNueva;
        private System.Windows.Forms.ToolStripMenuItem cmsVer;
        private System.Windows.Forms.ToolStripMenuItem cmsBorrar;
        private System.Windows.Forms.ListView lvProyecciones;
        private System.Windows.Forms.ColumnHeader chPelicula;
        private System.Windows.Forms.ColumnHeader ChSesion;
        private System.Windows.Forms.ColumnHeader chInicio;
        private System.Windows.Forms.ColumnHeader chFin;
    }
}
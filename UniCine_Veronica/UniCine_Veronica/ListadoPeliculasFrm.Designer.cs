namespace UniCine_Veronica
{
    partial class ListadoPeliculasFrm
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
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevaPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPeliculas = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDuracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPeliculas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevaPelicula});
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.peliculaToolStripMenuItem.Text = "Pelicula";
            // 
            // tsmiNuevaPelicula
            // 
            this.tsmiNuevaPelicula.Name = "tsmiNuevaPelicula";
            this.tsmiNuevaPelicula.Size = new System.Drawing.Size(180, 22);
            this.tsmiNuevaPelicula.Text = "Nueva";
            this.tsmiNuevaPelicula.Click += new System.EventHandler(this.tsmiNuevaPelicula_Click);
            // 
            // lvPeliculas
            // 
            this.lvPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chDuracion,
            this.chAnno,
            this.chCategoria,
            this.chGenero});
            this.lvPeliculas.ContextMenuStrip = this.cmsPeliculas;
            this.lvPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPeliculas.FullRowSelect = true;
            this.lvPeliculas.GridLines = true;
            this.lvPeliculas.HideSelection = false;
            this.lvPeliculas.Location = new System.Drawing.Point(0, 24);
            this.lvPeliculas.MultiSelect = false;
            this.lvPeliculas.Name = "lvPeliculas";
            this.lvPeliculas.Size = new System.Drawing.Size(800, 426);
            this.lvPeliculas.TabIndex = 1;
            this.lvPeliculas.UseCompatibleStateImageBehavior = false;
            this.lvPeliculas.View = System.Windows.Forms.View.Details;
            this.lvPeliculas.DoubleClick += new System.EventHandler(this.lvPeliculas_DoubleClick);
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 218;
            // 
            // chDuracion
            // 
            this.chDuracion.Text = "Duracion";
            this.chDuracion.Width = 117;
            // 
            // chAnno
            // 
            this.chAnno.Text = "Año";
            this.chAnno.Width = 125;
            // 
            // chCategoria
            // 
            this.chCategoria.Text = "Categoria";
            this.chCategoria.Width = 153;
            // 
            // chGenero
            // 
            this.chGenero.Text = "Genero";
            this.chGenero.Width = 160;
            // 
            // cmsPeliculas
            // 
            this.cmsPeliculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNuevo,
            this.cmsVer,
            this.cmsBorrar});
            this.cmsPeliculas.Name = "cmsPeliculas";
            this.cmsPeliculas.Size = new System.Drawing.Size(110, 70);
            this.cmsPeliculas.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPeliculas_Opening);
            // 
            // cmsNuevo
            // 
            this.cmsNuevo.Name = "cmsNuevo";
            this.cmsNuevo.Size = new System.Drawing.Size(180, 22);
            this.cmsNuevo.Text = "Nuevo";
            this.cmsNuevo.Click += new System.EventHandler(this.cmsNuevo_Click);
            // 
            // cmsVer
            // 
            this.cmsVer.Name = "cmsVer";
            this.cmsVer.Size = new System.Drawing.Size(180, 22);
            this.cmsVer.Text = "Ver";
            this.cmsVer.Click += new System.EventHandler(this.cmsVer_Click);
            // 
            // cmsBorrar
            // 
            this.cmsBorrar.Name = "cmsBorrar";
            this.cmsBorrar.Size = new System.Drawing.Size(180, 22);
            this.cmsBorrar.Text = "Borrar";
            this.cmsBorrar.Click += new System.EventHandler(this.cmsBorrar_Click);
            // 
            // ListadoPeliculasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvPeliculas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListadoPeliculasFrm";
            this.Text = "Listado Peliculas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsPeliculas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevaPelicula;
        private System.Windows.Forms.ListView lvPeliculas;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chDuracion;
        private System.Windows.Forms.ColumnHeader chAnno;
        private System.Windows.Forms.ColumnHeader chCategoria;
        private System.Windows.Forms.ColumnHeader chGenero;
        private System.Windows.Forms.ContextMenuStrip cmsPeliculas;
        private System.Windows.Forms.ToolStripMenuItem cmsNuevo;
        private System.Windows.Forms.ToolStripMenuItem cmsVer;
        private System.Windows.Forms.ToolStripMenuItem cmsBorrar;
    }
}
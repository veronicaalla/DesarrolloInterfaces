namespace UT2E9_Veronica
{
    partial class ListaPeliculasFrm
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
            this.tsmiPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCrearPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPeliculas = new System.Windows.Forms.ListView();
            this.chTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPeliculas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCrearPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVerPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPeliculas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiPeliculas
            // 
            this.tsmiPeliculas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrearPelicula});
            this.tsmiPeliculas.Name = "tsmiPeliculas";
            this.tsmiPeliculas.Size = new System.Drawing.Size(65, 20);
            this.tsmiPeliculas.Text = "Peliculas";
            // 
            // tsmiCrearPelicula
            // 
            this.tsmiCrearPelicula.Image = global::UT2E9_Veronica.Properties.Resources.añadir;
            this.tsmiCrearPelicula.Name = "tsmiCrearPelicula";
            this.tsmiCrearPelicula.Size = new System.Drawing.Size(102, 22);
            this.tsmiCrearPelicula.Text = "Crear";
            this.tsmiCrearPelicula.Click += new System.EventHandler(this.tsmiCrearPelicula_Click);
            // 
            // lvPeliculas
            // 
            this.lvPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitulo,
            this.chAnno,
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
            // chTitulo
            // 
            this.chTitulo.Text = "Titulo";
            this.chTitulo.Width = 409;
            // 
            // chAnno
            // 
            this.chAnno.Text = "Año";
            this.chAnno.Width = 95;
            // 
            // chGenero
            // 
            this.chGenero.Text = "Género";
            this.chGenero.Width = 286;
            // 
            // cmsPeliculas
            // 
            this.cmsPeliculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCrearPelicula,
            this.cmsVerPelicula,
            this.cmsEliminarPelicula});
            this.cmsPeliculas.Name = "cmsPeliculas";
            this.cmsPeliculas.Size = new System.Drawing.Size(118, 70);
            this.cmsPeliculas.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPeliculas_Opening);
            // 
            // cmsCrearPelicula
            // 
            this.cmsCrearPelicula.Image = global::UT2E9_Veronica.Properties.Resources.añadir;
            this.cmsCrearPelicula.Name = "cmsCrearPelicula";
            this.cmsCrearPelicula.Size = new System.Drawing.Size(117, 22);
            this.cmsCrearPelicula.Text = "Crear";
            this.cmsCrearPelicula.Click += new System.EventHandler(this.cmsCrearPelicula_Click);
            // 
            // cmsVerPelicula
            // 
            this.cmsVerPelicula.Image = global::UT2E9_Veronica.Properties.Resources.ver;
            this.cmsVerPelicula.Name = "cmsVerPelicula";
            this.cmsVerPelicula.Size = new System.Drawing.Size(117, 22);
            this.cmsVerPelicula.Text = "Ver";
            this.cmsVerPelicula.Click += new System.EventHandler(this.cmsVerPelicula_Click);
            // 
            // cmsEliminarPelicula
            // 
            this.cmsEliminarPelicula.Image = global::UT2E9_Veronica.Properties.Resources.borrar;
            this.cmsEliminarPelicula.Name = "cmsEliminarPelicula";
            this.cmsEliminarPelicula.Size = new System.Drawing.Size(117, 22);
            this.cmsEliminarPelicula.Text = "Eliminar";
            this.cmsEliminarPelicula.Click += new System.EventHandler(this.cmsEliminarPelicula_Click);
            // 
            // ListaPeliculasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvPeliculas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaPeliculasFrm";
            this.Text = "Mantenimiento de películas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsPeliculas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPeliculas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrearPelicula;
        private System.Windows.Forms.ListView lvPeliculas;
        private System.Windows.Forms.ColumnHeader chTitulo;
        private System.Windows.Forms.ColumnHeader chAnno;
        private System.Windows.Forms.ColumnHeader chGenero;
        private System.Windows.Forms.ContextMenuStrip cmsPeliculas;
        private System.Windows.Forms.ToolStripMenuItem cmsCrearPelicula;
        private System.Windows.Forms.ToolStripMenuItem cmsVerPelicula;
        private System.Windows.Forms.ToolStripMenuItem cmsEliminarPelicula;
    }
}
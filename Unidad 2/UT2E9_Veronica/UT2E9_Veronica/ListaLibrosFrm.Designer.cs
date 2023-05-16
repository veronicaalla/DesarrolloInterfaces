namespace UT2E9_Veronica
{
    partial class ListaLibrosFrm
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
            this.tsmiLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCrearLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.lvLibro = new System.Windows.Forms.ListView();
            this.chTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsLibros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCrearLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVerLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBorrarLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsLibros.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLibros});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiLibros
            // 
            this.tsmiLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrearLibro});
            this.tsmiLibros.Name = "tsmiLibros";
            this.tsmiLibros.Size = new System.Drawing.Size(51, 20);
            this.tsmiLibros.Text = "Libros";
            // 
            // tsmiCrearLibro
            // 
            this.tsmiCrearLibro.Image = global::UT2E9_Veronica.Properties.Resources.añadir;
            this.tsmiCrearLibro.Name = "tsmiCrearLibro";
            this.tsmiCrearLibro.Size = new System.Drawing.Size(102, 22);
            this.tsmiCrearLibro.Text = "Crear";
            this.tsmiCrearLibro.Click += new System.EventHandler(this.tsmiCrearLibro_Click);
            // 
            // lvLibro
            // 
            this.lvLibro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitulo,
            this.chAño,
            this.chAutor});
            this.lvLibro.ContextMenuStrip = this.cmsLibros;
            this.lvLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLibro.FullRowSelect = true;
            this.lvLibro.GridLines = true;
            this.lvLibro.HideSelection = false;
            this.lvLibro.Location = new System.Drawing.Point(0, 24);
            this.lvLibro.MultiSelect = false;
            this.lvLibro.Name = "lvLibro";
            this.lvLibro.Size = new System.Drawing.Size(800, 426);
            this.lvLibro.TabIndex = 1;
            this.lvLibro.UseCompatibleStateImageBehavior = false;
            this.lvLibro.View = System.Windows.Forms.View.Details;
            this.lvLibro.DoubleClick += new System.EventHandler(this.lvLibro_DoubleClick);
            // 
            // chTitulo
            // 
            this.chTitulo.Text = "Titulo";
            this.chTitulo.Width = 424;
            // 
            // chAño
            // 
            this.chAño.Text = "Año";
            this.chAño.Width = 102;
            // 
            // chAutor
            // 
            this.chAutor.Text = "Autor";
            this.chAutor.Width = 258;
            // 
            // cmsLibros
            // 
            this.cmsLibros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCrearLibro,
            this.cmsVerLibro,
            this.cmsBorrarLibro});
            this.cmsLibros.Name = "cmsLibros";
            this.cmsLibros.Size = new System.Drawing.Size(107, 70);
            this.cmsLibros.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLibros_Opening);
            // 
            // cmsCrearLibro
            // 
            this.cmsCrearLibro.Image = global::UT2E9_Veronica.Properties.Resources.añadir;
            this.cmsCrearLibro.Name = "cmsCrearLibro";
            this.cmsCrearLibro.Size = new System.Drawing.Size(106, 22);
            this.cmsCrearLibro.Text = "Crear";
            this.cmsCrearLibro.Click += new System.EventHandler(this.cmsCrearLibro_Click);
            // 
            // cmsVerLibro
            // 
            this.cmsVerLibro.Image = global::UT2E9_Veronica.Properties.Resources.ver;
            this.cmsVerLibro.Name = "cmsVerLibro";
            this.cmsVerLibro.Size = new System.Drawing.Size(106, 22);
            this.cmsVerLibro.Text = "Ver";
            this.cmsVerLibro.Click += new System.EventHandler(this.cmsVerLibro_Click);
            // 
            // cmsBorrarLibro
            // 
            this.cmsBorrarLibro.Image = global::UT2E9_Veronica.Properties.Resources.borrar;
            this.cmsBorrarLibro.Name = "cmsBorrarLibro";
            this.cmsBorrarLibro.Size = new System.Drawing.Size(106, 22);
            this.cmsBorrarLibro.Text = "Borrar";
            this.cmsBorrarLibro.Click += new System.EventHandler(this.cmsBorrarLibro_Click);
            // 
            // ListaLibrosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvLibro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaLibrosFrm";
            this.Text = "Mantenimiento de libros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsLibros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLibros;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrearLibro;
        private System.Windows.Forms.ListView lvLibro;
        private System.Windows.Forms.ColumnHeader chTitulo;
        private System.Windows.Forms.ColumnHeader chAño;
        private System.Windows.Forms.ColumnHeader chAutor;
        private System.Windows.Forms.ContextMenuStrip cmsLibros;
        private System.Windows.Forms.ToolStripMenuItem cmsCrearLibro;
        private System.Windows.Forms.ToolStripMenuItem cmsVerLibro;
        private System.Windows.Forms.ToolStripMenuItem cmsBorrarLibro;
    }
}
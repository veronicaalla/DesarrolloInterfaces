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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.tsmiCrearLibro.Size = new System.Drawing.Size(180, 22);
            this.tsmiCrearLibro.Text = "Crear";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitulo,
            this.chAño,
            this.chAutor});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 426);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // 
            // cmsCrearLibro
            // 
            this.cmsCrearLibro.Image = global::UT2E9_Veronica.Properties.Resources.añadir;
            this.cmsCrearLibro.Name = "cmsCrearLibro";
            this.cmsCrearLibro.Size = new System.Drawing.Size(180, 22);
            this.cmsCrearLibro.Text = "Crear";
            // 
            // cmsVerLibro
            // 
            this.cmsVerLibro.Image = global::UT2E9_Veronica.Properties.Resources.ver;
            this.cmsVerLibro.Name = "cmsVerLibro";
            this.cmsVerLibro.Size = new System.Drawing.Size(106, 22);
            this.cmsVerLibro.Text = "Ver";
            // 
            // cmsBorrarLibro
            // 
            this.cmsBorrarLibro.Image = global::UT2E9_Veronica.Properties.Resources.borrar;
            this.cmsBorrarLibro.Name = "cmsBorrarLibro";
            this.cmsBorrarLibro.Size = new System.Drawing.Size(106, 22);
            this.cmsBorrarLibro.Text = "Borrar";
            // 
            // ListaLibrosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chTitulo;
        private System.Windows.Forms.ColumnHeader chAño;
        private System.Windows.Forms.ColumnHeader chAutor;
        private System.Windows.Forms.ContextMenuStrip cmsLibros;
        private System.Windows.Forms.ToolStripMenuItem cmsCrearLibro;
        private System.Windows.Forms.ToolStripMenuItem cmsVerLibro;
        private System.Windows.Forms.ToolStripMenuItem cmsBorrarLibro;
    }
}
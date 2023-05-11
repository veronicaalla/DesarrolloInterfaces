namespace Winforms_Veronica_Alvarez
{
    partial class ListadoAlumnosFrm
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
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.lvAlumnos = new System.Windows.Forms.ListView();
            this.chDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComienzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsAlumnos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrear});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // tsmiCrear
            // 
            this.tsmiCrear.Name = "tsmiCrear";
            this.tsmiCrear.Size = new System.Drawing.Size(180, 22);
            this.tsmiCrear.Text = "Crear";
            this.tsmiCrear.Click += new System.EventHandler(this.tsmiCrear_Click);
            // 
            // lvAlumnos
            // 
            this.lvAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDNI,
            this.chNombre,
            this.chEmpresa,
            this.chComienzo});
            this.lvAlumnos.ContextMenuStrip = this.cmsAlumnos;
            this.lvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAlumnos.FullRowSelect = true;
            this.lvAlumnos.GridLines = true;
            this.lvAlumnos.HideSelection = false;
            this.lvAlumnos.Location = new System.Drawing.Point(0, 24);
            this.lvAlumnos.MultiSelect = false;
            this.lvAlumnos.Name = "lvAlumnos";
            this.lvAlumnos.Size = new System.Drawing.Size(800, 426);
            this.lvAlumnos.TabIndex = 1;
            this.lvAlumnos.UseCompatibleStateImageBehavior = false;
            this.lvAlumnos.View = System.Windows.Forms.View.Details;
            this.lvAlumnos.DoubleClick += new System.EventHandler(this.lvAlumnos_DoubleClick);
            // 
            // chDNI
            // 
            this.chDNI.Text = "DNI";
            this.chDNI.Width = 167;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 178;
            // 
            // chEmpresa
            // 
            this.chEmpresa.Text = "Empresa";
            this.chEmpresa.Width = 194;
            // 
            // chComienzo
            // 
            this.chComienzo.Text = "Comienzo";
            this.chComienzo.Width = 224;
            // 
            // cmsAlumnos
            // 
            this.cmsAlumnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCrear,
            this.cmsVer,
            this.cmsEliminar});
            this.cmsAlumnos.Name = "cmsAlumnos";
            this.cmsAlumnos.Size = new System.Drawing.Size(118, 70);
            this.cmsAlumnos.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAlumnos_Opening);
            // 
            // cmsCrear
            // 
            this.cmsCrear.Name = "cmsCrear";
            this.cmsCrear.Size = new System.Drawing.Size(117, 22);
            this.cmsCrear.Text = "Crear";
            this.cmsCrear.Click += new System.EventHandler(this.cmsCrear_Click);
            // 
            // cmsVer
            // 
            this.cmsVer.Name = "cmsVer";
            this.cmsVer.Size = new System.Drawing.Size(117, 22);
            this.cmsVer.Text = "Ver";
            this.cmsVer.Click += new System.EventHandler(this.cmsVer_Click);
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.Size = new System.Drawing.Size(117, 22);
            this.cmsEliminar.Text = "Eliminar";
            this.cmsEliminar.Click += new System.EventHandler(this.cmsEliminar_Click);
            // 
            // ListadoAlumnosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvAlumnos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListadoAlumnosFrm";
            this.Text = "Mantenimiento Alumnos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsAlumnos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrear;
        private System.Windows.Forms.ListView lvAlumnos;
        private System.Windows.Forms.ColumnHeader chDNI;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chEmpresa;
        private System.Windows.Forms.ColumnHeader chComienzo;
        private System.Windows.Forms.ContextMenuStrip cmsAlumnos;
        private System.Windows.Forms.ToolStripMenuItem cmsCrear;
        private System.Windows.Forms.ToolStripMenuItem cmsVer;
        private System.Windows.Forms.ToolStripMenuItem cmsEliminar;
    }
}
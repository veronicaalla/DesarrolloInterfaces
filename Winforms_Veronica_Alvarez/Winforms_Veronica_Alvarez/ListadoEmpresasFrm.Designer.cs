namespace Winforms_Veronica_Alvarez
{
    partial class ListadoEmpresasFrm
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
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.lvEmpresas = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContacto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsEmpresas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsEmpresas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrear});
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // tsmiCrear
            // 
            this.tsmiCrear.Name = "tsmiCrear";
            this.tsmiCrear.Size = new System.Drawing.Size(180, 22);
            this.tsmiCrear.Text = "Crear";
            this.tsmiCrear.Click += new System.EventHandler(this.tsmiCrear_Click);
            // 
            // lvEmpresas
            // 
            this.lvEmpresas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chTelefono,
            this.chContacto});
            this.lvEmpresas.ContextMenuStrip = this.cmsEmpresas;
            this.lvEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEmpresas.FullRowSelect = true;
            this.lvEmpresas.GridLines = true;
            this.lvEmpresas.HideSelection = false;
            this.lvEmpresas.Location = new System.Drawing.Point(0, 24);
            this.lvEmpresas.MultiSelect = false;
            this.lvEmpresas.Name = "lvEmpresas";
            this.lvEmpresas.Size = new System.Drawing.Size(603, 385);
            this.lvEmpresas.TabIndex = 1;
            this.lvEmpresas.UseCompatibleStateImageBehavior = false;
            this.lvEmpresas.View = System.Windows.Forms.View.Details;
            this.lvEmpresas.DoubleClick += new System.EventHandler(this.lvEmpresas_DoubleClick);
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 139;
            // 
            // chTelefono
            // 
            this.chTelefono.Text = "Teléfono";
            this.chTelefono.Width = 192;
            // 
            // chContacto
            // 
            this.chContacto.Text = "Contacto";
            this.chContacto.Width = 216;
            // 
            // cmsEmpresas
            // 
            this.cmsEmpresas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCrear,
            this.cmsVer,
            this.cmsEliminar});
            this.cmsEmpresas.Name = "cmsEmpresas";
            this.cmsEmpresas.Size = new System.Drawing.Size(118, 70);
            this.cmsEmpresas.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEmpresas_Opening);
            // 
            // cmsCrear
            // 
            this.cmsCrear.Name = "cmsCrear";
            this.cmsCrear.Size = new System.Drawing.Size(180, 22);
            this.cmsCrear.Text = "Crear";
            this.cmsCrear.Click += new System.EventHandler(this.cmsCrear_Click);
            // 
            // cmsVer
            // 
            this.cmsVer.Name = "cmsVer";
            this.cmsVer.Size = new System.Drawing.Size(180, 22);
            this.cmsVer.Text = "Ver";
            this.cmsVer.Click += new System.EventHandler(this.cmsVer_Click);
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.Size = new System.Drawing.Size(180, 22);
            this.cmsEliminar.Text = "Eliminar";
            this.cmsEliminar.Click += new System.EventHandler(this.cmsEliminar_Click);
            // 
            // ListadoEmpresasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 409);
            this.Controls.Add(this.lvEmpresas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListadoEmpresasFrm";
            this.Text = "Listado Empresas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsEmpresas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrear;
        private System.Windows.Forms.ListView lvEmpresas;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chTelefono;
        private System.Windows.Forms.ColumnHeader chContacto;
        private System.Windows.Forms.ContextMenuStrip cmsEmpresas;
        private System.Windows.Forms.ToolStripMenuItem cmsCrear;
        private System.Windows.Forms.ToolStripMenuItem cmsVer;
        private System.Windows.Forms.ToolStripMenuItem cmsEliminar;
    }
}
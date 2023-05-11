namespace Winforms_Veronica_Alvarez
{
    partial class BuscadorEmpresaFrm
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
            this.txtFiltrado = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lvEmpresas = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtFiltrado
            // 
            this.txtFiltrado.Location = new System.Drawing.Point(31, 25);
            this.txtFiltrado.Name = "txtFiltrado";
            this.txtFiltrado.Size = new System.Drawing.Size(336, 20);
            this.txtFiltrado.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(388, 25);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(87, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(494, 25);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(101, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // lvEmpresas
            // 
            this.lvEmpresas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre});
            this.lvEmpresas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvEmpresas.FullRowSelect = true;
            this.lvEmpresas.GridLines = true;
            this.lvEmpresas.HideSelection = false;
            this.lvEmpresas.Location = new System.Drawing.Point(0, 70);
            this.lvEmpresas.MultiSelect = false;
            this.lvEmpresas.Name = "lvEmpresas";
            this.lvEmpresas.Size = new System.Drawing.Size(653, 265);
            this.lvEmpresas.TabIndex = 3;
            this.lvEmpresas.UseCompatibleStateImageBehavior = false;
            this.lvEmpresas.View = System.Windows.Forms.View.Details;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 590;
            // 
            // BuscadorEmpresaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 335);
            this.Controls.Add(this.lvEmpresas);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltrado);
            this.Name = "BuscadorEmpresaFrm";
            this.Text = "BuscadorEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltrado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ListView lvEmpresas;
        private System.Windows.Forms.ColumnHeader chNombre;
    }
}
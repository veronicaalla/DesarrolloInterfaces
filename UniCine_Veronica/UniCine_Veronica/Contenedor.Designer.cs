namespace UniCine_Veronica
{
    partial class Contenedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuContenedor = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatosDesarrollador = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSesiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProyecciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContenedor
            // 
            this.menuContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiMantenimiento,
            this.tsmiVentanas});
            this.menuContenedor.Location = new System.Drawing.Point(0, 0);
            this.menuContenedor.Name = "menuContenedor";
            this.menuContenedor.Size = new System.Drawing.Size(800, 24);
            this.menuContenedor.TabIndex = 1;
            this.menuContenedor.Text = "menu";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDatosDesarrollador,
            this.toolStripSeparator1,
            this.tsmiSalir});
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiDatosDesarrollador
            // 
            this.tsmiDatosDesarrollador.Name = "tsmiDatosDesarrollador";
            this.tsmiDatosDesarrollador.Size = new System.Drawing.Size(177, 22);
            this.tsmiDatosDesarrollador.Text = "Datos Desarrollador";
            this.tsmiDatosDesarrollador.Click += new System.EventHandler(this.tsmiDatosDesarrollador_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(177, 22);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // tsmiMantenimiento
            // 
            this.tsmiMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPeliculas,
            this.tsmiSesiones,
            this.tsmiProyecciones});
            this.tsmiMantenimiento.Name = "tsmiMantenimiento";
            this.tsmiMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.tsmiMantenimiento.Text = "Mantenimiento";
            // 
            // tsmiPeliculas
            // 
            this.tsmiPeliculas.Name = "tsmiPeliculas";
            this.tsmiPeliculas.Size = new System.Drawing.Size(144, 22);
            this.tsmiPeliculas.Text = "Peliculas";
            this.tsmiPeliculas.Click += new System.EventHandler(this.tsmiPeliculas_Click);
            // 
            // tsmiSesiones
            // 
            this.tsmiSesiones.Name = "tsmiSesiones";
            this.tsmiSesiones.Size = new System.Drawing.Size(144, 22);
            this.tsmiSesiones.Text = "Sesiones";
            this.tsmiSesiones.Click += new System.EventHandler(this.tsmiSesiones_Click);
            // 
            // tsmiProyecciones
            // 
            this.tsmiProyecciones.Name = "tsmiProyecciones";
            this.tsmiProyecciones.Size = new System.Drawing.Size(144, 22);
            this.tsmiProyecciones.Text = "Proyecciones";
            this.tsmiProyecciones.Click += new System.EventHandler(this.tsmiProyecciones_Click);
            // 
            // tsmiVentanas
            // 
            this.tsmiVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCascada,
            this.tsmiHorizontal,
            this.tsmiVertical});
            this.tsmiVentanas.Name = "tsmiVentanas";
            this.tsmiVentanas.Size = new System.Drawing.Size(66, 20);
            this.tsmiVentanas.Text = "Ventanas";
            // 
            // tsmiCascada
            // 
            this.tsmiCascada.Name = "tsmiCascada";
            this.tsmiCascada.Size = new System.Drawing.Size(180, 22);
            this.tsmiCascada.Text = "Cascada";
            this.tsmiCascada.Click += new System.EventHandler(this.tsmiCascada_Click);
            // 
            // tsmiHorizontal
            // 
            this.tsmiHorizontal.Name = "tsmiHorizontal";
            this.tsmiHorizontal.Size = new System.Drawing.Size(180, 22);
            this.tsmiHorizontal.Text = "Horizontal";
            this.tsmiHorizontal.Click += new System.EventHandler(this.tsmiHorizontal_Click);
            // 
            // tsmiVertical
            // 
            this.tsmiVertical.Name = "tsmiVertical";
            this.tsmiVertical.Size = new System.Drawing.Size(180, 22);
            this.tsmiVertical.Text = "Vertical";
            this.tsmiVertical.Click += new System.EventHandler(this.tsmiVertical_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuContenedor);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuContenedor;
            this.Name = "Contenedor";
            this.Text = "Contenedor";
            this.menuContenedor.ResumeLayout(false);
            this.menuContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuContenedor;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatosDesarrollador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmiPeliculas;
        private System.Windows.Forms.ToolStripMenuItem tsmiSesiones;
        private System.Windows.Forms.ToolStripMenuItem tsmiProyecciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentanas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascada;
        private System.Windows.Forms.ToolStripMenuItem tsmiHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmiVertical;
    }
}


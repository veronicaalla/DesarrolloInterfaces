namespace UT2E3_Veronica
{
    partial class FrmCalculadora
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Location = new System.Drawing.Point(23, 23);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(251, 20);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(23, 61);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(39, 24);
            this.btn7.TabIndex = 1;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(68, 61);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(39, 24);
            this.btn8.TabIndex = 2;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(113, 61);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(39, 24);
            this.btn9.TabIndex = 3;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(158, 61);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(39, 24);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Tag = "/";
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(203, 61);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(71, 24);
            this.btnMS.TabIndex = 5;
            this.btnMS.Tag = "";
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(203, 91);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(71, 24);
            this.btnMR.TabIndex = 10;
            this.btnMR.Tag = "";
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(158, 91);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(39, 24);
            this.btnMultiplicar.TabIndex = 9;
            this.btnMultiplicar.Tag = "*";
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(113, 91);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(39, 24);
            this.btn6.TabIndex = 8;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(68, 91);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(39, 24);
            this.btn5.TabIndex = 7;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(23, 91);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(39, 24);
            this.btn4.TabIndex = 6;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(203, 121);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(71, 24);
            this.btnC.TabIndex = 15;
            this.btnC.Tag = "";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(158, 121);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(39, 24);
            this.btnRestar.TabIndex = 14;
            this.btnRestar.Tag = "-";
            this.btnRestar.Text = "--";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(113, 121);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(39, 24);
            this.btn3.TabIndex = 13;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(68, 121);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(39, 24);
            this.btn2.TabIndex = 12;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(23, 121);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(39, 24);
            this.btn1.TabIndex = 11;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(203, 151);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(71, 24);
            this.btnIgual.TabIndex = 20;
            this.btnIgual.Tag = "=";
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(158, 151);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(39, 24);
            this.btnSumar.TabIndex = 19;
            this.btnSumar.Tag = "+";
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(113, 151);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(39, 24);
            this.btnPunto.TabIndex = 18;
            this.btnPunto.Tag = ".";
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(23, 151);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(84, 24);
            this.btn0.TabIndex = 16;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // FrmCalculadora
            // 
            this.AcceptButton = this.btnIgual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 204);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.Click += new System.EventHandler(this.BtnNumeros_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
    }
}


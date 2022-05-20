namespace Team_Proyect_Sim
{
    partial class Form1
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
            this.lblC_M = new System.Windows.Forms.Label();
            this.txtC_M = new System.Windows.Forms.TextBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.lblMod = new System.Windows.Forms.Label();
            this.txtC_A = new System.Windows.Forms.TextBox();
            this.LblC_A = new System.Windows.Forms.Label();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.cmdIntroducir = new System.Windows.Forms.Button();
            this.cmdClean = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblC_M
            // 
            this.lblC_M.Location = new System.Drawing.Point(4, 13);
            this.lblC_M.Name = "lblC_M";
            this.lblC_M.Size = new System.Drawing.Size(79, 17);
            this.lblC_M.TabIndex = 1;
            this.lblC_M.Text = "Constante M. =";
            // 
            // txtC_M
            // 
            this.txtC_M.Location = new System.Drawing.Point(83, 10);
            this.txtC_M.Name = "txtC_M";
            this.txtC_M.Size = new System.Drawing.Size(100, 20);
            this.txtC_M.TabIndex = 2;
            this.txtC_M.AcceptsTabChanged += new System.EventHandler(this.txtC_M_AcceptsTabChanged);
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(83, 97);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(100, 20);
            this.txtMod.TabIndex = 4;
            // 
            // lblMod
            // 
            this.lblMod.Location = new System.Drawing.Point(4, 100);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(79, 17);
            this.lblMod.TabIndex = 3;
            this.lblMod.Text = "Modulo =";
            // 
            // txtC_A
            // 
            this.txtC_A.Location = new System.Drawing.Point(83, 69);
            this.txtC_A.Name = "txtC_A";
            this.txtC_A.Size = new System.Drawing.Size(100, 20);
            this.txtC_A.TabIndex = 6;
            // 
            // LblC_A
            // 
            this.LblC_A.Location = new System.Drawing.Point(4, 72);
            this.LblC_A.Name = "LblC_A";
            this.LblC_A.Size = new System.Drawing.Size(79, 17);
            this.LblC_A.TabIndex = 5;
            this.LblC_A.Text = "Constante A. =";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(83, 39);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(100, 20);
            this.txtSemilla.TabIndex = 8;
            // 
            // lblSemilla
            // 
            this.lblSemilla.Location = new System.Drawing.Point(4, 42);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(79, 17);
            this.lblSemilla.TabIndex = 7;
            this.lblSemilla.Text = "Semilla =";
            // 
            // cmdIntroducir
            // 
            this.cmdIntroducir.Location = new System.Drawing.Point(7, 128);
            this.cmdIntroducir.Name = "cmdIntroducir";
            this.cmdIntroducir.Size = new System.Drawing.Size(75, 23);
            this.cmdIntroducir.TabIndex = 9;
            this.cmdIntroducir.Text = "&Aceptar";
            this.cmdIntroducir.UseVisualStyleBackColor = true;
            this.cmdIntroducir.Click += new System.EventHandler(this.cmdIntroducir_Click);
            // 
            // cmdClean
            // 
            this.cmdClean.Location = new System.Drawing.Point(108, 170);
            this.cmdClean.Name = "cmdClean";
            this.cmdClean.Size = new System.Drawing.Size(75, 23);
            this.cmdClean.TabIndex = 10;
            this.cmdClean.Text = "&Limpiar";
            this.cmdClean.UseVisualStyleBackColor = true;
            this.cmdClean.Click += new System.EventHandler(this.cmdClean_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(8, 170);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 12;
            this.cmdClose.Text = "&Salir";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cantidad de Numeros =";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 321);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdClean);
            this.Controls.Add(this.cmdIntroducir);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.lblSemilla);
            this.Controls.Add(this.txtC_A);
            this.Controls.Add(this.LblC_A);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.txtC_M);
            this.Controls.Add(this.lblC_M);
            this.Name = "Form1";
            this.Text = "Proyecto Simulacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblC_M;
        private System.Windows.Forms.TextBox txtC_M;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.TextBox txtC_A;
        private System.Windows.Forms.Label LblC_A;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Button cmdIntroducir;
        private System.Windows.Forms.Button cmdClean;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


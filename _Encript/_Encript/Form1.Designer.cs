namespace _Encript
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPalabras = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPalabraC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtCifrado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PALABRAS";
            // 
            // TxtPalabras
            // 
            this.TxtPalabras.Location = new System.Drawing.Point(115, 63);
            this.TxtPalabras.Name = "TxtPalabras";
            this.TxtPalabras.Size = new System.Drawing.Size(122, 20);
            this.TxtPalabras.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CIFRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtPalabraC
            // 
            this.txtPalabraC.Location = new System.Drawing.Point(115, 91);
            this.txtPalabraC.Name = "txtPalabraC";
            this.txtPalabraC.Size = new System.Drawing.Size(122, 20);
            this.txtPalabraC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CLAVE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "DECIFRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TxtCifrado
            // 
            this.TxtCifrado.FormattingEnabled = true;
            this.TxtCifrado.Location = new System.Drawing.Point(95, 148);
            this.TxtCifrado.Name = "TxtCifrado";
            this.TxtCifrado.Size = new System.Drawing.Size(150, 108);
            this.TxtCifrado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 321);
            this.Controls.Add(this.TxtCifrado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPalabraC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPalabras);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPalabras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPalabraC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox TxtCifrado;
    }
}


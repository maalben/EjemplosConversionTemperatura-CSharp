namespace EjemplosConversosTemperatura
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.btnconvertirkelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Unidades";
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.txtvalor.Location = new System.Drawing.Point(160, 141);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(137, 68);
            this.txtvalor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(43, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Centígrados";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbltotal.Location = new System.Drawing.Point(566, 158);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(43, 24);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "total";
            this.lbltotal.Visible = false;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnconvertir.Location = new System.Drawing.Point(325, 136);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(192, 34);
            this.btnconvertir.TabIndex = 4;
            this.btnconvertir.Text = "A fahrenheit";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // btnconvertirkelvin
            // 
            this.btnconvertirkelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnconvertirkelvin.Location = new System.Drawing.Point(325, 181);
            this.btnconvertirkelvin.Name = "btnconvertirkelvin";
            this.btnconvertirkelvin.Size = new System.Drawing.Size(192, 34);
            this.btnconvertirkelvin.TabIndex = 5;
            this.btnconvertirkelvin.Text = "A Kelvin";
            this.btnconvertirkelvin.UseVisualStyleBackColor = true;
            this.btnconvertirkelvin.Click += new System.EventHandler(this.btnconvertirkelvin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 305);
            this.Controls.Add(this.btnconvertirkelvin);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Button btnconvertirkelvin;
    }
}


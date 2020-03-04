namespace WindowsFormsApplication1
{
    partial class Promedio
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_prom = new System.Windows.Forms.TextBox();
            this.txt_exa3 = new System.Windows.Forms.TextBox();
            this.txt_exa1 = new System.Windows.Forms.TextBox();
            this.txt_exa2 = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_limp = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examen 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Examen 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Examen 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Promedio";
            // 
            // txt_prom
            // 
            this.txt_prom.Location = new System.Drawing.Point(117, 116);
            this.txt_prom.Name = "txt_prom";
            this.txt_prom.ReadOnly = true;
            this.txt_prom.Size = new System.Drawing.Size(100, 20);
            this.txt_prom.TabIndex = 4;
            // 
            // txt_exa3
            // 
            this.txt_exa3.Location = new System.Drawing.Point(117, 77);
            this.txt_exa3.Name = "txt_exa3";
            this.txt_exa3.Size = new System.Drawing.Size(100, 20);
            this.txt_exa3.TabIndex = 5;
            // 
            // txt_exa1
            // 
            this.txt_exa1.Location = new System.Drawing.Point(117, 6);
            this.txt_exa1.Name = "txt_exa1";
            this.txt_exa1.Size = new System.Drawing.Size(100, 20);
            this.txt_exa1.TabIndex = 6;
            // 
            // txt_exa2
            // 
            this.txt_exa2.Location = new System.Drawing.Point(117, 41);
            this.txt_exa2.Name = "txt_exa2";
            this.txt_exa2.Size = new System.Drawing.Size(100, 20);
            this.txt_exa2.TabIndex = 7;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(12, 156);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 8;
            this.btn_cal.Text = "Calcular";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_limp
            // 
            this.btn_limp.Location = new System.Drawing.Point(142, 156);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(75, 23);
            this.btn_limp.TabIndex = 9;
            this.btn_limp.Text = "Limpiar";
            this.btn_limp.UseVisualStyleBackColor = true;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(268, 156);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 219);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limp);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txt_exa2);
            this.Controls.Add(this.txt_exa1);
            this.Controls.Add(this.txt_exa3);
            this.Controls.Add(this.txt_prom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_prom;
        private System.Windows.Forms.TextBox txt_exa3;
        private System.Windows.Forms.TextBox txt_exa1;
        private System.Windows.Forms.TextBox txt_exa2;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_limp;
        private System.Windows.Forms.Button btn_salir;
    }
}


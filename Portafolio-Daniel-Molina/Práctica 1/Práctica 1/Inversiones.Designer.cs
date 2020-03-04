namespace WindowsFormsApplication1
{
    partial class Inversiones
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
            this.txtinversionista1 = new System.Windows.Forms.TextBox();
            this.txtinversionista2 = new System.Windows.Forms.TextBox();
            this.txtinversionista3 = new System.Windows.Forms.TextBox();
            this.txtporcentaje1 = new System.Windows.Forms.TextBox();
            this.txtporcentaje2 = new System.Windows.Forms.TextBox();
            this.txtporcentaje3 = new System.Windows.Forms.TextBox();
            this.txttotalinvesiones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtinversionista1
            // 
            this.txtinversionista1.Location = new System.Drawing.Point(26, 34);
            this.txtinversionista1.Name = "txtinversionista1";
            this.txtinversionista1.Size = new System.Drawing.Size(100, 20);
            this.txtinversionista1.TabIndex = 0;
            this.txtinversionista1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtinversionista2
            // 
            this.txtinversionista2.Location = new System.Drawing.Point(26, 61);
            this.txtinversionista2.Name = "txtinversionista2";
            this.txtinversionista2.Size = new System.Drawing.Size(100, 20);
            this.txtinversionista2.TabIndex = 1;
            // 
            // txtinversionista3
            // 
            this.txtinversionista3.Location = new System.Drawing.Point(26, 88);
            this.txtinversionista3.Name = "txtinversionista3";
            this.txtinversionista3.Size = new System.Drawing.Size(100, 20);
            this.txtinversionista3.TabIndex = 2;
            // 
            // txtporcentaje1
            // 
            this.txtporcentaje1.Location = new System.Drawing.Point(162, 34);
            this.txtporcentaje1.Name = "txtporcentaje1";
            this.txtporcentaje1.Size = new System.Drawing.Size(100, 20);
            this.txtporcentaje1.TabIndex = 3;
            // 
            // txtporcentaje2
            // 
            this.txtporcentaje2.Location = new System.Drawing.Point(162, 60);
            this.txtporcentaje2.Name = "txtporcentaje2";
            this.txtporcentaje2.Size = new System.Drawing.Size(100, 20);
            this.txtporcentaje2.TabIndex = 4;
            // 
            // txtporcentaje3
            // 
            this.txtporcentaje3.Location = new System.Drawing.Point(162, 88);
            this.txtporcentaje3.Name = "txtporcentaje3";
            this.txtporcentaje3.Size = new System.Drawing.Size(100, 20);
            this.txtporcentaje3.TabIndex = 5;
            // 
            // txttotalinvesiones
            // 
            this.txttotalinvesiones.Location = new System.Drawing.Point(26, 139);
            this.txttotalinvesiones.Name = "txttotalinvesiones";
            this.txttotalinvesiones.Size = new System.Drawing.Size(100, 20);
            this.txttotalinvesiones.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inversionistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Porcentajes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "1.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "2.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "3.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Inversiones";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(26, 169);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(122, 168);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 14;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(218, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 218);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttotalinvesiones);
            this.Controls.Add(this.txtporcentaje3);
            this.Controls.Add(this.txtporcentaje2);
            this.Controls.Add(this.txtporcentaje1);
            this.Controls.Add(this.txtinversionista3);
            this.Controls.Add(this.txtinversionista2);
            this.Controls.Add(this.txtinversionista1);
            this.Name = "Form3";
            this.Text = "Inversiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinversionista1;
        private System.Windows.Forms.TextBox txtinversionista2;
        private System.Windows.Forms.TextBox txtinversionista3;
        private System.Windows.Forms.TextBox txtporcentaje1;
        private System.Windows.Forms.TextBox txtporcentaje2;
        private System.Windows.Forms.TextBox txtporcentaje3;
        private System.Windows.Forms.TextBox txttotalinvesiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}
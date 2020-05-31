namespace Práctica_11
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
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTriangulo = new System.Windows.Forms.RadioButton();
            this.rdoCuadrado = new System.Windows.Forms.RadioButton();
            this.rdoCirculo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(169, 72);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(40, 13);
            this.lblValor2.TabIndex = 17;
            this.lblValor2.Text = "Valor 2";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(166, 14);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(40, 13);
            this.lblValor1.TabIndex = 16;
            this.lblValor1.Text = "Valor 1";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(169, 92);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 15;
            this.txtValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor2_KeyPress);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(166, 30);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 14;
            this.txtValor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor1_KeyPress);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(166, 161);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.Size = new System.Drawing.Size(100, 20);
            this.txtRespuesta.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "El aréa es:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(18, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 22);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTriangulo);
            this.groupBox1.Controls.Add(this.rdoCuadrado);
            this.groupBox1.Controls.Add(this.rdoCirculo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 136);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione:";
            // 
            // rdoTriangulo
            // 
            this.rdoTriangulo.AutoSize = true;
            this.rdoTriangulo.Location = new System.Drawing.Point(6, 101);
            this.rdoTriangulo.Name = "rdoTriangulo";
            this.rdoTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rdoTriangulo.TabIndex = 2;
            this.rdoTriangulo.Text = "Triángulo";
            this.rdoTriangulo.UseVisualStyleBackColor = true;
            this.rdoTriangulo.CheckedChanged += new System.EventHandler(this.rdoTriangulo_CheckedChanged);
            // 
            // rdoCuadrado
            // 
            this.rdoCuadrado.AutoSize = true;
            this.rdoCuadrado.Location = new System.Drawing.Point(6, 56);
            this.rdoCuadrado.Name = "rdoCuadrado";
            this.rdoCuadrado.Size = new System.Drawing.Size(71, 17);
            this.rdoCuadrado.TabIndex = 1;
            this.rdoCuadrado.Text = "Cuadrado";
            this.rdoCuadrado.UseVisualStyleBackColor = true;
            this.rdoCuadrado.CheckedChanged += new System.EventHandler(this.rdoCuadrado_CheckedChanged);
            // 
            // rdoCirculo
            // 
            this.rdoCirculo.AutoSize = true;
            this.rdoCirculo.Location = new System.Drawing.Point(6, 19);
            this.rdoCirculo.Name = "rdoCirculo";
            this.rdoCirculo.Size = new System.Drawing.Size(59, 17);
            this.rdoCirculo.TabIndex = 0;
            this.rdoCirculo.Text = "Círculo";
            this.rdoCirculo.UseVisualStyleBackColor = true;
            this.rdoCirculo.CheckedChanged += new System.EventHandler(this.rdoCirculo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 195);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTriangulo;
        private System.Windows.Forms.RadioButton rdoCuadrado;
        private System.Windows.Forms.RadioButton rdoCirculo;
    }
}


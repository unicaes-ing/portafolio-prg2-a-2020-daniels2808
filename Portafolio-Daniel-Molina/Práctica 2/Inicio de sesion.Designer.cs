namespace Práctica_2
{
    partial class Inicio_de_sesion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxcorreoelectrónico = new System.Windows.Forms.MaskedTextBox();
            this.mtxcontraseña = new System.Windows.Forms.MaskedTextBox();
            this.mtxconfirmacióndecontraseña = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo electrónico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmación de \r\ncontraseña";
            // 
            // mtxcorreoelectrónico
            // 
            this.mtxcorreoelectrónico.Location = new System.Drawing.Point(112, 13);
            this.mtxcorreoelectrónico.Name = "mtxcorreoelectrónico";
            this.mtxcorreoelectrónico.Size = new System.Drawing.Size(100, 20);
            this.mtxcorreoelectrónico.TabIndex = 6;
            // 
            // mtxcontraseña
            // 
            this.mtxcontraseña.Location = new System.Drawing.Point(112, 49);
            this.mtxcontraseña.Name = "mtxcontraseña";
            this.mtxcontraseña.PasswordChar = '*';
            this.mtxcontraseña.Size = new System.Drawing.Size(100, 20);
            this.mtxcontraseña.TabIndex = 7;
            // 
            // mtxconfirmacióndecontraseña
            // 
            this.mtxconfirmacióndecontraseña.Location = new System.Drawing.Point(112, 93);
            this.mtxconfirmacióndecontraseña.Name = "mtxconfirmacióndecontraseña";
            this.mtxconfirmacióndecontraseña.PasswordChar = '*';
            this.mtxconfirmacióndecontraseña.Size = new System.Drawing.Size(100, 20);
            this.mtxconfirmacióndecontraseña.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Inicio_de_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 190);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtxconfirmacióndecontraseña);
            this.Controls.Add(this.mtxcontraseña);
            this.Controls.Add(this.mtxcorreoelectrónico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inicio_de_sesion";
            this.Text = "Inicio_de_sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxcorreoelectrónico;
        private System.Windows.Forms.MaskedTextBox mtxcontraseña;
        private System.Windows.Forms.MaskedTextBox mtxconfirmacióndecontraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
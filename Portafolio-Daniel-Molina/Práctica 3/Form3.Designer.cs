namespace Práctica_3
{
    partial class Form3
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
            this.btnlanzar = new System.Windows.Forms.Button();
            this.lstnumerolanzado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnlanzar
            // 
            this.btnlanzar.Location = new System.Drawing.Point(25, 226);
            this.btnlanzar.Name = "btnlanzar";
            this.btnlanzar.Size = new System.Drawing.Size(75, 23);
            this.btnlanzar.TabIndex = 0;
            this.btnlanzar.Text = "Lanzar";
            this.btnlanzar.UseVisualStyleBackColor = true;
            this.btnlanzar.Click += new System.EventHandler(this.btnlanzar_Click);
            // 
            // lstnumerolanzado
            // 
            this.lstnumerolanzado.FormattingEnabled = true;
            this.lstnumerolanzado.Location = new System.Drawing.Point(13, 13);
            this.lstnumerolanzado.Name = "lstnumerolanzado";
            this.lstnumerolanzado.Size = new System.Drawing.Size(101, 199);
            this.lstnumerolanzado.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(127, 261);
            this.Controls.Add(this.lstnumerolanzado);
            this.Controls.Add(this.btnlanzar);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlanzar;
        private System.Windows.Forms.ListBox lstnumerolanzado;
    }
}
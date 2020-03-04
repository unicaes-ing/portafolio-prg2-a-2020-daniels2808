namespace Práctica_3
{
    partial class Form4
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroABuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMostrarNumero = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(186, 291);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 19);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroABuscar
            // 
            this.txtNumeroABuscar.Location = new System.Drawing.Point(106, 291);
            this.txtNumeroABuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroABuscar.Name = "txtNumeroABuscar";
            this.txtNumeroABuscar.Size = new System.Drawing.Size(76, 20);
            this.txtNumeroABuscar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número a buscar:";
            // 
            // dgvMostrarNumero
            // 
            this.dgvMostrarNumero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarNumero.Location = new System.Drawing.Point(11, 11);
            this.dgvMostrarNumero.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMostrarNumero.Name = "dgvMostrarNumero";
            this.dgvMostrarNumero.RowHeadersWidth = 51;
            this.dgvMostrarNumero.RowTemplate.Height = 24;
            this.dgvMostrarNumero.Size = new System.Drawing.Size(259, 276);
            this.dgvMostrarNumero.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 327);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeroABuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMostrarNumero);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumeroABuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMostrarNumero;
    }
}
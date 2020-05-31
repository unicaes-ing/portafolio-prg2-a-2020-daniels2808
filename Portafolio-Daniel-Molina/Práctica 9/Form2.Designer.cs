namespace Práctica_9
{
    partial class Form2
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarNuevoVehiculo = new System.Windows.Forms.Button();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(642, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarNuevoVehiculo
            // 
            this.btnAgregarNuevoVehiculo.Location = new System.Drawing.Point(13, 183);
            this.btnAgregarNuevoVehiculo.Name = "btnAgregarNuevoVehiculo";
            this.btnAgregarNuevoVehiculo.Size = new System.Drawing.Size(148, 23);
            this.btnAgregarNuevoVehiculo.TabIndex = 4;
            this.btnAgregarNuevoVehiculo.Text = "Agregar nuevo vehículo";
            this.btnAgregarNuevoVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoVehiculo.Click += new System.EventHandler(this.btnAgregarNuevoVehiculo_Click);
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.AllowUserToAddRows = false;
            this.dgvVehiculo.AllowUserToDeleteRows = false;
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Marca,
            this.Modelo,
            this.Color,
            this.Año,
            this.Pasajeros,
            this.Eliminar});
            this.dgvVehiculo.Location = new System.Drawing.Point(12, 12);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.ReadOnly = true;
            this.dgvVehiculo.RowHeadersVisible = false;
            this.dgvVehiculo.Size = new System.Drawing.Size(705, 150);
            this.dgvVehiculo.TabIndex = 3;
            this.dgvVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculo_CellContentClick);
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matrícula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Pasajeros
            // 
            this.Pasajeros.HeaderText = "Pasajeros";
            this.Pasajeros.Name = "Pasajeros";
            this.Pasajeros.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 220);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarNuevoVehiculo);
            this.Controls.Add(this.dgvVehiculo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarNuevoVehiculo;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasajeros;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
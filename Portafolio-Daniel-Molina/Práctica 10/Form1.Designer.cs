namespace Práctica_10
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.nudMillas = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.rdoCarro = new System.Windows.Forms.RadioButton();
            this.rdoCamión = new System.Windows.Forms.RadioButton();
            this.rdoMicrobus = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Millas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puertas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MIllas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(55, 13);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(55, 49);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 6;
            // 
            // nudMillas
            // 
            this.nudMillas.Location = new System.Drawing.Point(55, 80);
            this.nudMillas.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.nudMillas.Name = "nudMillas";
            this.nudMillas.Size = new System.Drawing.Size(120, 20);
            this.nudMillas.TabIndex = 7;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(55, 108);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 20);
            this.nudPrecio.TabIndex = 8;
            // 
            // rdoCarro
            // 
            this.rdoCarro.AutoSize = true;
            this.rdoCarro.Location = new System.Drawing.Point(55, 138);
            this.rdoCarro.Name = "rdoCarro";
            this.rdoCarro.Size = new System.Drawing.Size(50, 17);
            this.rdoCarro.TabIndex = 9;
            this.rdoCarro.Text = "Carro";
            this.rdoCarro.UseVisualStyleBackColor = true;
            this.rdoCarro.CheckedChanged += new System.EventHandler(this.rdoCarro_CheckedChanged);
            // 
            // rdoCamión
            // 
            this.rdoCamión.AutoSize = true;
            this.rdoCamión.Location = new System.Drawing.Point(147, 138);
            this.rdoCamión.Name = "rdoCamión";
            this.rdoCamión.Size = new System.Drawing.Size(60, 17);
            this.rdoCamión.TabIndex = 10;
            this.rdoCamión.Text = "Camión";
            this.rdoCamión.UseVisualStyleBackColor = true;
            this.rdoCamión.CheckedChanged += new System.EventHandler(this.rdoCamión_CheckedChanged);
            // 
            // rdoMicrobus
            // 
            this.rdoMicrobus.AutoSize = true;
            this.rdoMicrobus.Location = new System.Drawing.Point(239, 138);
            this.rdoMicrobus.Name = "rdoMicrobus";
            this.rdoMicrobus.Size = new System.Drawing.Size(68, 17);
            this.rdoMicrobus.TabIndex = 11;
            this.rdoMicrobus.Text = "Microbus";
            this.rdoMicrobus.UseVisualStyleBackColor = true;
            this.rdoMicrobus.CheckedChanged += new System.EventHandler(this.rdoMicrobus_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(331, 138);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Modelo,
            this.Millas,
            this.Precio,
            this.Tipo,
            this.Puertas,
            this.Capacidad,
            this.Combustible,
            this.Pasajeros});
            this.dataGridView1.Location = new System.Drawing.Point(16, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(904, 150);
            this.dataGridView1.TabIndex = 13;
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
            // Millas
            // 
            this.Millas.HeaderText = "Millas";
            this.Millas.Name = "Millas";
            this.Millas.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Puertas
            // 
            this.Puertas.HeaderText = "Puertas";
            this.Puertas.Name = "Puertas";
            this.Puertas.ReadOnly = true;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            // 
            // Combustible
            // 
            this.Combustible.HeaderText = "Combustible";
            this.Combustible.Name = "Combustible";
            this.Combustible.ReadOnly = true;
            // 
            // Pasajeros
            // 
            this.Pasajeros.HeaderText = "Pasajeros";
            this.Pasajeros.Name = "Pasajeros";
            this.Pasajeros.ReadOnly = true;
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Location = new System.Drawing.Point(239, 26);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(43, 13);
            this.lblPuertas.TabIndex = 14;
            this.lblPuertas.Text = "Puertas";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(239, 49);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 15;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Location = new System.Drawing.Point(239, 78);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(64, 13);
            this.lblCombustible.TabIndex = 16;
            this.lblCombustible.Text = "Combustible";
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(239, 104);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(53, 13);
            this.lblPasajeros.TabIndex = 17;
            this.lblPasajeros.Text = "Pasajeros";
            // 
            // txtPuertas
            // 
            this.txtPuertas.Location = new System.Drawing.Point(309, 23);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(100, 20);
            this.txtPuertas.TabIndex = 18;
            this.txtPuertas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuertas_KeyPress);
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Location = new System.Drawing.Point(309, 101);
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(100, 20);
            this.txtPasajeros.TabIndex = 19;
            this.txtPasajeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasajeros_KeyPress);
            // 
            // txtCombustible
            // 
            this.txtCombustible.Location = new System.Drawing.Point(309, 75);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(100, 20);
            this.txtCombustible.TabIndex = 20;
            this.txtCombustible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCombustible_KeyPress);
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(309, 49);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 21;
            this.txtCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacidad_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 346);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtCombustible);
            this.Controls.Add(this.txtPasajeros);
            this.Controls.Add(this.txtPuertas);
            this.Controls.Add(this.lblPasajeros);
            this.Controls.Add(this.lblCombustible);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblPuertas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rdoMicrobus);
            this.Controls.Add(this.rdoCamión);
            this.Controls.Add(this.rdoCarro);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudMillas);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown nudMillas;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.RadioButton rdoCarro;
        private System.Windows.Forms.RadioButton rdoCamión;
        private System.Windows.Forms.RadioButton rdoMicrobus;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Millas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasajeros;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.TextBox txtPasajeros;
        private System.Windows.Forms.TextBox txtCombustible;
        private System.Windows.Forms.TextBox txtCapacidad;
    }
}


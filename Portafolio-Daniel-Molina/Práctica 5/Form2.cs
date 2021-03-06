﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[,] A = new int[5, 5];
        int[,] B = new int[5, 5];
        int[,] Resultado = new int[5, 5];
        private void Form2_Load(object sender, EventArgs e)
        {
            Random a = new Random();
            dgvMatrizA.ColumnCount = 5;
            dgvMatrizA.ColumnHeadersVisible = false;
            dgvMatrizA.RowHeadersVisible = false;
            dgvMatrizA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatrizB.ColumnCount = 5;
            dgvMatrizB.ColumnHeadersVisible = false;
            dgvMatrizB.RowHeadersVisible = false;
            dgvMatrizB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int f = 0; f < A.GetLength(0); f++)
            {
                dgvMatrizA.Rows.Add();
                dgvMatrizB.Rows.Add();
                for (int c = 0; c < A.GetLength(1); c++)
                {
                    A[f, c] = a.Next(10, 91);
                    B[f, c] = a.Next(10, 91);
                    dgvMatrizA.Rows[f].Cells[c].Value = A[f, c];
                    dgvMatrizB.Rows[f].Cells[c].Value = B[f, c];
                }
            }
            dgvMatrizA.ClearSelection();
            dgvMatrizB.ClearSelection();
        }
        public static int[,] suma(int[,] A, int[,] B, RadioButton suma)
        {
            int[,] Resultado = new int[5, 5];

            for (int f = 0; f < A.GetLength(0); f++)
            {

                for (int c = 0; c < A.GetLength(1); c++)
                {
                    Resultado[f, c] = A[f, c] + B[f, c];
                }
            }
            return Resultado;
        }
        public static int[,] multi(int[,] A, int[,] B, RadioButton multiplicar)
        {
            int[,] Resultado = new int[5, 5];

            for (int f = 0; f < A.GetLength(0); f++)
            {

                for (int c = 0; c < A.GetLength(1); c++)
                {
                    Resultado[f, c] = A[f, c] * B[f, c];
                }
            }
            return Resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            if (rdoSumar.Checked)
            {
                dgvResultado.ColumnCount = 5;
                dgvResultado.ColumnHeadersVisible = false;
                dgvResultado.RowHeadersVisible = false;
                dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int f = 0; f < Resultado.GetLength(0); f++)
                {
                    dgvResultado.Rows.Add();
                    for (int c = 0; c < Resultado.GetLength(1); c++)
                    {

                        dgvResultado.Rows[f].Cells[c].Value = suma(A, B, rdoSumar);
                    }
                }
                dgvResultado.ClearSelection();
            }
            else if (rdoMultiplicar.Checked)
            {
                dgvResultado.ColumnCount = 5;
                dgvResultado.ColumnHeadersVisible = false;
                dgvResultado.RowHeadersVisible = false;
                dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int f = 0; f < Resultado.GetLength(0); f++)
                {
                    dgvResultado.Rows.Add();
                    for (int c = 0; c < Resultado.GetLength(1); c++)
                    {

                        dgvResultado.Rows[f].Cells[c].Value = multi(A, B, rdoMultiplicar);
                    }
                }
                dgvResultado.ClearSelection();
            }
        }
    }
}

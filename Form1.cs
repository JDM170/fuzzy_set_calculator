﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double ConvertDGValue(object value)
        { return Convert.ToDouble(value); }

        private void MergeDGs()
        {
            DataGridView matrix_low, matrix_high;
            if (dataGridView1.Rows.Count < dataGridView2.Rows.Count)
            {
                matrix_low = dataGridView1;
                matrix_high = dataGridView2;
            }
            else
            {
                matrix_low = dataGridView2;
                matrix_high = dataGridView1;
            }
            int lowRowCount = matrix_low.Rows.Count,
                highRowCount = matrix_high.Rows.Count;
            int wrong = 0;
            for (int first = 0; first < highRowCount; first++)
            {
                for (int second = 0; second < lowRowCount; second++)
                    if (ConvertDGValue(matrix_low[0, second].Value) != ConvertDGValue(matrix_high[0, first].Value))
                        wrong++;
                if (wrong > lowRowCount - 1)
                    dataGridView3.Rows.Add(new object[] { matrix_high[0, first].Value, matrix_high[1, first].Value, matrix_high[2, first].Value });
                wrong = 0;
            }
        }

        private double[,] ConvertDGtoMatrix(DataGridView dgv)
        {
            int rowCount = dgv.Rows.Count,
                colCount = dgv.Columns.Count;
            double[,] matrix = new double[colCount, rowCount];
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                    matrix[j, i] = ConvertDGValue(dgv[j, i].Value);
            return matrix;
        }

        private double[,] SortMatrix(double[,] matrix)
        {
            int rowCount = matrix.GetLength(1),
                colCount = matrix.GetLength(0);
            double temp;
            for (int first = 0; first < rowCount; first++)
                for (int second = 0; second < rowCount; second++)
                    if (matrix[0, first] < matrix[0, second])
                        for (int k = 0; k < colCount; k++)
                        {
                            temp = matrix[k, first];
                            matrix[k, first] = matrix[k, second];
                            matrix[k, second] = temp;
                        }
            return matrix;
        }

        private void PrintGraph(double[,] matrix, string chart_series)
        {
            DataPointCollection points = chart1.Series.FindByName(chart_series).Points;
            int matrixLength = matrix.GetLength(1);
            for (int row = 0; row < matrixLength; row++)
                points.AddXY(matrix[1, row], matrix[0, row]);
            for(int row = matrixLength - 1; row >= 0; row--)
                points.AddXY(matrix[2, row], matrix[0, row]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[] { 0, 1, 9 });
            dataGridView1.Rows.Add(new object[] { 0.5, 2, 8 });
            dataGridView1.Rows.Add(new object[] { 1, 3, 4 });

            dataGridView2.Rows.Add(new object[] { 0, 1, 9 });
            dataGridView2.Rows.Add(new object[] { 0.5, 3, 6 });
            dataGridView2.Rows.Add(new object[] { 0.2, 2, 7 });
            dataGridView2.Rows.Add(new object[] { 1, 4, 5 });

            /*// Simple merging
            if(dataGridView2.Rows.Count > dataGridView1.Rows.Count)
            {
                for(int row = dataGridView1.Rows.Count; row < dataGridView2.Rows.Count; row++)
                {
                    dataGridView3.RowCount++;
                    for(int col = 0; col < dataGridView1.Columns.Count; col++)
                        dataGridView3[col, row].Value = ConvertDGValue(dataGridView2[col, row].Value);
                }
            }*/

            /*double[,] matrix = ConvertDGtoMatrix(dataGridView2);
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for(int col = 0; col < matrix.GetLength(0); col++)
                    Console.WriteLine(matrix[col, row]);
                Console.WriteLine();
            }*/
        }

        private void addition_Click(object sender, EventArgs e)
        {
            double[,] matrix_low, matrix_high;
            if (dataGridView1.Rows.Count < dataGridView2.Rows.Count)
            {
                matrix_low = ConvertDGtoMatrix(dataGridView1);
                matrix_high = ConvertDGtoMatrix(dataGridView2);
            }
            else
            {
                matrix_low = ConvertDGtoMatrix(dataGridView2);
                matrix_high = ConvertDGtoMatrix(dataGridView1);
            }
            dataGridView3.Rows.Clear();
            for (int high = 0; high < matrix_high.GetLength(1); high++)
                for (int low = 0; low < matrix_low.GetLength(1); low++)
                    if (matrix_low[0, low] == matrix_high[0, high])
                        dataGridView3.Rows.Add(new object[]
                        {
                            matrix_high[0, high],
                            matrix_low[1, low] + matrix_high[1, high],
                            matrix_low[2, low] + matrix_high[2, high]
                        });
            MergeDGs();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            double[,] matrix_low, matrix_high;
            if (dataGridView1.Rows.Count < dataGridView2.Rows.Count)
            {
                matrix_low = ConvertDGtoMatrix(dataGridView1);
                matrix_high = ConvertDGtoMatrix(dataGridView2);
            }
            else
            {
                matrix_low = ConvertDGtoMatrix(dataGridView2);
                matrix_high = ConvertDGtoMatrix(dataGridView1);
            }
            dataGridView3.Rows.Clear();
            for (int high = 0; high < matrix_high.GetLength(1); high++)
                for (int low = 0; low < matrix_low.GetLength(1); low++)
                    if (matrix_low[0, low] == matrix_high[0, high])
                        dataGridView3.Rows.Add(new object[]
                        {
                            matrix_high[0, high],
                            matrix_low[1, low] - matrix_high[2, high],
                            matrix_low[2, low] - matrix_high[1, high]
                        });
            MergeDGs();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double[,] matrix_low, matrix_high;
            if (dataGridView1.Rows.Count < dataGridView2.Rows.Count)
            {
                matrix_low = ConvertDGtoMatrix(dataGridView1);
                matrix_high = ConvertDGtoMatrix(dataGridView2);
            }
            else
            {
                matrix_low = ConvertDGtoMatrix(dataGridView2);
                matrix_high = ConvertDGtoMatrix(dataGridView1);
            }
            dataGridView3.Rows.Clear();
            for (int high = 0; high < matrix_high.GetLength(1); high++)
                for (int low = 0; low < matrix_low.GetLength(1); low++)
                    if (matrix_low[0, low] == matrix_high[0, high])
                        dataGridView3.Rows.Add(new object[]
                        {
                            matrix_high[0, high],
                            matrix_low[1, low] * matrix_high[1, high],
                            matrix_low[2, low] * matrix_high[2, high]
                        });
            MergeDGs();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double[,] matrix_low, matrix_high;
            if (dataGridView1.Rows.Count < dataGridView2.Rows.Count)
            {
                matrix_low = ConvertDGtoMatrix(dataGridView1);
                matrix_high = ConvertDGtoMatrix(dataGridView2);
            }
            else
            {
                matrix_low = ConvertDGtoMatrix(dataGridView2);
                matrix_high = ConvertDGtoMatrix(dataGridView1);
            }
            dataGridView3.Rows.Clear();
            for (int high = 0; high < matrix_high.GetLength(1); high++)
                for (int low = 0; low < matrix_low.GetLength(1); low++)
                    if (matrix_low[0, low] == matrix_high[0, high])
                        dataGridView3.Rows.Add(new object[]
                        {
                            matrix_high[0, high],
                            matrix_low[1, low] / matrix_high[2, high],
                            matrix_low[2, low] / matrix_high[1, high]
                        });
            MergeDGs();
        }

        private void build_a_Click(object sender, EventArgs e)
        {
            double[,] matrix = SortMatrix(ConvertDGtoMatrix(dataGridView1));
            PrintGraph(matrix, "A1");
        }

        private void build_b_Click(object sender, EventArgs e)
        {
            double[,] matrix = SortMatrix(ConvertDGtoMatrix(dataGridView2));
            PrintGraph(matrix, "B2");
        }

        private void build_c_Click(object sender, EventArgs e)
        {
            double[,] matrix = SortMatrix(ConvertDGtoMatrix(dataGridView3));
            PrintGraph(matrix, "C3");
        }

        private void del_by_name_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            chart1.Series.FindByName(text).Points.Clear();
        }

        private void clean_graph_Click(object sender, EventArgs e)
        {
            chart1.Series.FindByName("A1").Points.Clear();
            chart1.Series.FindByName("B2").Points.Clear();
            chart1.Series.FindByName("C3").Points.Clear();
        }
    }
}

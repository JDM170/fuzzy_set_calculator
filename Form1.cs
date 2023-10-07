using System;
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

        private Tuple<double[,], double[,]> GetUnknownAlpha(double[,] matrix1, double[,] matrix2)
        {
            double[,] matrix_low, matrix_high;
            if(matrix1.GetLength(1) < matrix2.GetLength(1))
            {
                matrix_low = matrix1;
                matrix_high = matrix2;
            }
            else
            {
                matrix_low = matrix2;
                matrix_high = matrix1;
            }
            int colCount = matrix_low.GetLength(0),
                lowRowCount = matrix_low.GetLength(1),
                highRowCount = matrix_high.GetLength(1),
                wrong = 0,
                offsetNew = 0;
            double[,] matrix3 = new double[colCount, highRowCount];
            for (int row = 0; row < lowRowCount; row++)
                for (int col = 0; col < colCount; col++)
                    matrix3[col, row] = matrix_low[col, row];
            for (int high = 0; high < highRowCount; high++)
            {
                for (int low = 0; low < lowRowCount; low++)
                    if (matrix_low[0, low] != matrix_high[0, high])
                        wrong++;
                if (wrong > lowRowCount - 1)
                {
                    matrix3[0, lowRowCount + offsetNew] = matrix_high[0, high];
                    matrix3[1, lowRowCount + offsetNew] = 0;
                    matrix3[2, lowRowCount + offsetNew] = 0;
                    offsetNew++;
                }
                wrong = 0;
            }

            matrix3 = SortMatrix(matrix3);
            int minCoord = 0, maxCoord = 0;
            double k, b;
            for (int i = 0; i < highRowCount; i++)
            {
                if (matrix3[1, i] == 0 && matrix3[2, i] == 0)
                {
                    minCoord = i - 1;
                    maxCoord = i + 1;
                    // k = (y2 - y1) / (x2 - x1);
                    // b = (x2 * y1 - x1 * y2) / (x2 - x1);
                    k = (matrix3[0, maxCoord] - matrix3[0, minCoord]) / (matrix3[1, maxCoord] - matrix3[1, minCoord]);
                    b = (matrix3[1, maxCoord] * matrix3[0, minCoord] - matrix3[1, minCoord] * matrix3[0, maxCoord]) / (matrix3[1, maxCoord] - matrix3[1, minCoord]);
                    matrix3[1, i] = -(b - matrix3[0, i]) / k;

                    k = (matrix3[0, maxCoord] - matrix3[0, minCoord]) / (matrix3[2, maxCoord] - matrix3[2, minCoord]);
                    b = (matrix3[2, maxCoord] * matrix3[0, minCoord] - matrix3[2, minCoord] * matrix3[0, maxCoord]) / (matrix3[2, maxCoord] - matrix3[2, minCoord]);
                    matrix3[2, i] = -(b - matrix3[0, i]) / k;
                }
            }

            return Tuple.Create(matrix3, matrix_high);
        }

        private void PrintGraph(double[,] matrix, string chart_series)
        {
            DataPointCollection points = chart1.Series.FindByName(chart_series).Points;
            int matrixLength = matrix.GetLength(1);
            points.Clear();
            for (int row = 0; row < matrixLength; row++)
                points.AddXY(matrix[1, row], matrix[0, row]);
            for (int row = matrixLength - 1; row >= 0; row--)
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
            double[,] matrix_low = ConvertDGtoMatrix(dataGridView1),
                matrix_high = ConvertDGtoMatrix(dataGridView2);
            Tuple<double[,], double[,]> tuple = GetUnknownAlpha(matrix_low, matrix_high);
            matrix_low = tuple.Item1;
            matrix_high = tuple.Item2;
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
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            double[,] matrix_low = ConvertDGtoMatrix(dataGridView1),
                matrix_high = ConvertDGtoMatrix(dataGridView2);
            Tuple<double[,], double[,]> tuple = GetUnknownAlpha(matrix_low, matrix_high);
            matrix_low = tuple.Item1;
            matrix_high = tuple.Item2;
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
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double[,] matrix_low = ConvertDGtoMatrix(dataGridView1),
                matrix_high = ConvertDGtoMatrix(dataGridView2);
            Tuple<double[,], double[,]> tuple = GetUnknownAlpha(matrix_low, matrix_high);
            matrix_low = tuple.Item1;
            matrix_high = tuple.Item2;
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
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double[,] matrix_low = ConvertDGtoMatrix(dataGridView1),
                matrix_high = ConvertDGtoMatrix(dataGridView2);
            Tuple<double[,], double[,]> tuple = GetUnknownAlpha(matrix_low, matrix_high);
            matrix_low = tuple.Item1;
            matrix_high = tuple.Item2;
            dataGridView3.Rows.Clear();
            for (int high = 0; high < matrix_high.GetLength(1); high++)
                for (int low = 0; low < matrix_low.GetLength(1); low++)
                    if (matrix_low[0, low] == matrix_high[0, high])
                    {
                        if (matrix_high[1, high] > 0 && matrix_high[2, high] > 0)
                        {
                            dataGridView3.Rows.Add(new object[]
                            {
                                matrix_high[0, high],
                                matrix_low[1, low] / matrix_high[2, high],
                                matrix_low[2, low] / matrix_high[1, high]
                            });
                        }
                        else
                        {
                            dataGridView3.Rows.Clear();
                            MessageBox.Show("Деление на 0 невозможно. Задайте другое значение!");
                            return;
                        }
                    }
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

        private void compare_Click(object sender, EventArgs e)
        {
            // compare
        }
    }
}

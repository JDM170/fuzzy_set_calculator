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

        // Конвертирование объекта в double
        private double ConvertDGValue(object value)
        { return Convert.ToDouble(value); }

        // Преобразование dataGridView в матрицу
        private double[,] ConvertDGtoMatrix(DataGridView dgv)
        {
            int rowCount = dgv.Rows.Count,
                colCount = dgv.Columns.Count;
            double[,] matrix = new double[colCount, rowCount];
            for (int row = 0; row < rowCount; row++)
                for (int col = 0; col < colCount; col++)
                    matrix[col, row] = ConvertDGValue(dgv[col, row].Value);
            return matrix;
        }

        // Сортировка матрицы по возрастанию альфа-среза
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

        // Вычисление неизвестного альфа-среза
        private Tuple<double[,], double[,]> GetUnknownAlpha(double[,] matrixA, double[,] matrixB)
        {
            double[,] matrix_low, matrix_high;
            if(matrixA.GetLength(1) < matrixB.GetLength(1))
            {
                matrix_low = matrixA;
                matrix_high = matrixB;
            }
            else
            {
                matrix_low = matrixB;
                matrix_high = matrixA;
            }
            int colCount = matrix_low.GetLength(0),
                lowRowCount = matrix_low.GetLength(1),
                highRowCount = matrix_high.GetLength(1),
                wrong = 0,
                offsetNew = 0;
            double[,] matrixC = new double[colCount, highRowCount];
            for (int row = 0; row < lowRowCount; row++)
                for (int col = 0; col < colCount; col++)
                    matrixC[col, row] = matrix_low[col, row];
            for (int high = 0; high < highRowCount; high++)
            {
                for (int low = 0; low < lowRowCount; low++)
                    if (matrix_low[0, low] != matrix_high[0, high])
                        wrong++;
                if (wrong > lowRowCount - 1)
                {
                    matrixC[0, lowRowCount + offsetNew] = matrix_high[0, high];
                    matrixC[1, lowRowCount + offsetNew] = 0;
                    matrixC[2, lowRowCount + offsetNew] = 0;
                    offsetNew++;
                }
                wrong = 0;
            }
            matrixC = SortMatrix(matrixC);
            int minCoord = 0, maxCoord = 0;
            double k, b;
            for (int i = 0; i < highRowCount; i++)
            {
                if (matrixC[1, i] == 0 && matrixC[2, i] == 0)
                {
                    minCoord = i - 1;
                    maxCoord = i + 1;
                    // k = (y2 - y1) / (x2 - x1);
                    // b = (x2 * y1 - x1 * y2) / (x2 - x1);
                    // нижняя граница
                    k = (matrixC[0, maxCoord] - matrixC[0, minCoord]) / (matrixC[1, maxCoord] - matrixC[1, minCoord]);
                    b = (matrixC[1, maxCoord] * matrixC[0, minCoord] - matrixC[1, minCoord] * matrixC[0, maxCoord]) / (matrixC[1, maxCoord] - matrixC[1, minCoord]);
                    matrixC[1, i] = -(b - matrixC[0, i]) / k;
                    // верхняя граница
                    k = (matrixC[0, maxCoord] - matrixC[0, minCoord]) / (matrixC[2, maxCoord] - matrixC[2, minCoord]);
                    b = (matrixC[2, maxCoord] * matrixC[0, minCoord] - matrixC[2, minCoord] * matrixC[0, maxCoord]) / (matrixC[2, maxCoord] - matrixC[2, minCoord]);
                    matrixC[2, i] = -(b - matrixC[0, i]) / k;
                }
            }
            return Tuple.Create(matrixC, matrix_high);
        }

        // Вывод графика
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
            dataGridView2.Rows.Add(new object[] { 1, 4, 5 });
            dataGridView2.Rows.Add(new object[] { 0.2, 2, 7 });

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
            double[,] matrixA = ConvertDGtoMatrix(dataGridView1),
                matrixB = ConvertDGtoMatrix(dataGridView2);
            GetUnknownAlpha(matrixA, matrixB).Deconstruct(out matrixA, out matrixB);
            dataGridView3.Rows.Clear();
            int matrixLength = matrixA.GetLength(1);
            for (int a = 0; a < matrixLength; a++)
                for (int b = 0; b < matrixLength; b++)
                    if (matrixA[0, a] == matrixB[0, b])
                        dataGridView3.Rows.Add(new object[]
                        {
                            matrixA[0, a],
                            matrixA[1, a] + matrixB[1, b],
                            matrixA[2, a] + matrixB[2, b]
                        });
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            double[,] matrixA = ConvertDGtoMatrix(dataGridView1),
                matrixB = ConvertDGtoMatrix(dataGridView2);
            GetUnknownAlpha(matrixA, matrixB).Deconstruct(out matrixA, out matrixB);
            dataGridView3.Rows.Clear();
            int matrixLength = matrixA.GetLength(1);
            for (int a = 0; a < matrixLength; a++)
                for (int b = 0; b < matrixLength; b++)
                    if (matrixA[0, a] == matrixB[0, b])
                        dataGridView3.Rows.Add(new object[]
                        {
                            matrixA[0, a],
                            matrixA[1, a] - matrixB[2, b],
                            matrixA[2, a] - matrixB[1, b]
                        });
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double[,] matrixA = ConvertDGtoMatrix(dataGridView1),
                matrixB = ConvertDGtoMatrix(dataGridView2);
            GetUnknownAlpha(matrixA, matrixB).Deconstruct(out matrixA, out matrixB);
            dataGridView3.Rows.Clear();
            int matrixLength = matrixA.GetLength(1);
            for (int a = 0; a < matrixLength; a++)
                for (int b = 0; b < matrixLength; b++)
                    if (matrixA[0, a] == matrixB[0, b])
                        dataGridView3.Rows.Add(new object[]
                        {
                            matrixA[0, a],
                            matrixA[1, a] * matrixB[1, b],
                            matrixA[2, a] * matrixB[2, b]
                        });
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double[,] matrixA = ConvertDGtoMatrix(dataGridView1),
                matrixB = ConvertDGtoMatrix(dataGridView2);
            GetUnknownAlpha(matrixA, matrixB).Deconstruct(out matrixA, out matrixB);
            dataGridView3.Rows.Clear();
            int matrixLength = matrixA.GetLength(1);
            for (int a = 0; a < matrixLength; a++)
                for (int b = 0; b < matrixLength; b++)
                    if (matrixA[0, a] == matrixB[0, b])
                    {
                        if (matrixB[1, b] > 0 && matrixB[2, b] > 0)
                        {
                            dataGridView3.Rows.Add(new object[]
                            {
                                matrixA[0, a],
                                matrixA[1, a] / matrixB[2, b],
                                matrixA[2, a] / matrixB[1, b]
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
            PrintGraph(SortMatrix(ConvertDGtoMatrix(dataGridView1)), "A1");
        }

        private void build_b_Click(object sender, EventArgs e)
        {
            PrintGraph(SortMatrix(ConvertDGtoMatrix(dataGridView2)), "B2");
        }

        private void build_c_Click(object sender, EventArgs e)
        {
            PrintGraph(SortMatrix(ConvertDGtoMatrix(dataGridView3)), "C3");
        }

        private void del_by_name_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text != "")
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
            double[,] matrixA = SortMatrix(ConvertDGtoMatrix(dataGridView1)),
                matrixB = SortMatrix(ConvertDGtoMatrix(dataGridView2));
            int aRowCount = matrixA.GetLength(1),
                bRowCount = matrixB.GetLength(1);
            double aSum = 0, bSum = 0;
            for (int i = 0; i < aRowCount; i++)
                aSum += matrixA[1, i] + matrixA[2, i];
            aSum /= aRowCount;
            for (int i = 0; i < bRowCount; i++)
                bSum += matrixB[1, i] + matrixB[2, i];
            bSum /= bRowCount;
            if (aSum > bSum)
            {
                com_greater.BackColor = Color.Green;
                com_less.BackColor = Color.Red;
            }
            else
            {
                com_greater.BackColor = Color.Red;
                com_less.BackColor = Color.Green;
            }
            if (aSum >= bSum)
            {
                com_gore.BackColor = Color.Green;
                com_lore.BackColor = Color.Red;
            }
            else
            {
                com_gore.BackColor = Color.Red;
                com_lore.BackColor = Color.Green;
            }
            if (aSum == bSum)
            {
                com_equal.BackColor = Color.Green;
                com_non_equal.BackColor = Color.Red;
            }
            else
            {
                com_equal.BackColor = Color.Red;
                com_non_equal.BackColor = Color.Green;
            }
            chart1.Series.FindByName("A1").Points.Clear();
            chart1.Series.FindByName("B2").Points.Clear();
            chart1.Series.FindByName("C3").Points.Clear();
            PrintGraph(matrixA, "A1");
            PrintGraph(matrixB, "B2");
        }
    }
}

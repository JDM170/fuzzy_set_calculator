﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.build_a = new System.Windows.Forms.Button();
            this.build_b = new System.Windows.Forms.Button();
            this.build_c = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.del_by_name = new System.Windows.Forms.Button();
            this.clean_graph = new System.Windows.Forms.Button();
            this.compare = new System.Windows.Forms.Button();
            this.com_greater = new System.Windows.Forms.Button();
            this.com_less = new System.Windows.Forms.Button();
            this.com_gore = new System.Windows.Forms.Button();
            this.com_lore = new System.Windows.Forms.Button();
            this.com_equal = new System.Windows.Forms.Button();
            this.com_non_equal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "alpha";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "low";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "high";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(12, 190);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(351, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "alpha";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "low";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "high";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView3.Location = new System.Drawing.Point(12, 411);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(351, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "alpha";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "low";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "high";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 357);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(80, 34);
            this.add.TabIndex = 3;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.addition_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(98, 357);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(80, 34);
            this.sub.TabIndex = 4;
            this.sub.Text = "sub";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(184, 357);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(80, 34);
            this.mul.TabIndex = 5;
            this.mul.Text = "mul";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.multiply_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(270, 357);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(80, 34);
            this.div.TabIndex = 6;
            this.div.Text = "div";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.divide_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(380, 12);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "A1";
            series4.Points.Add(dataPoint3);
            series4.Points.Add(dataPoint4);
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "B2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "C3";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(512, 440);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // build_a
            // 
            this.build_a.Location = new System.Drawing.Point(380, 458);
            this.build_a.Name = "build_a";
            this.build_a.Size = new System.Drawing.Size(101, 31);
            this.build_a.TabIndex = 8;
            this.build_a.Text = "Построить A";
            this.build_a.UseVisualStyleBackColor = true;
            this.build_a.Click += new System.EventHandler(this.build_graph_Click);
            // 
            // build_b
            // 
            this.build_b.Location = new System.Drawing.Point(487, 458);
            this.build_b.Name = "build_b";
            this.build_b.Size = new System.Drawing.Size(101, 31);
            this.build_b.TabIndex = 9;
            this.build_b.Text = "Построить B";
            this.build_b.UseVisualStyleBackColor = true;
            this.build_b.Click += new System.EventHandler(this.build_graph_Click);
            // 
            // build_c
            // 
            this.build_c.Location = new System.Drawing.Point(594, 458);
            this.build_c.Name = "build_c";
            this.build_c.Size = new System.Drawing.Size(101, 31);
            this.build_c.TabIndex = 10;
            this.build_c.Text = "Построить C";
            this.build_c.UseVisualStyleBackColor = true;
            this.build_c.Click += new System.EventHandler(this.build_graph_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 496);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 11;
            // 
            // del_by_name
            // 
            this.del_by_name.Location = new System.Drawing.Point(380, 522);
            this.del_by_name.Name = "del_by_name";
            this.del_by_name.Size = new System.Drawing.Size(208, 23);
            this.del_by_name.TabIndex = 12;
            this.del_by_name.Text = "Удалить по названию";
            this.del_by_name.UseVisualStyleBackColor = true;
            this.del_by_name.Click += new System.EventHandler(this.del_by_name_Click);
            // 
            // clean_graph
            // 
            this.clean_graph.Location = new System.Drawing.Point(594, 496);
            this.clean_graph.Name = "clean_graph";
            this.clean_graph.Size = new System.Drawing.Size(101, 49);
            this.clean_graph.TabIndex = 13;
            this.clean_graph.Text = "Очистить график";
            this.clean_graph.UseVisualStyleBackColor = true;
            this.clean_graph.Click += new System.EventHandler(this.clean_graph_Click);
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(701, 458);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(132, 31);
            this.compare.TabIndex = 14;
            this.compare.Text = "Сравнить";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // com_greater
            // 
            this.com_greater.Enabled = false;
            this.com_greater.Location = new System.Drawing.Point(702, 496);
            this.com_greater.Name = "com_greater";
            this.com_greater.Size = new System.Drawing.Size(40, 23);
            this.com_greater.TabIndex = 15;
            this.com_greater.Text = ">";
            this.com_greater.UseVisualStyleBackColor = true;
            // 
            // com_less
            // 
            this.com_less.Enabled = false;
            this.com_less.Location = new System.Drawing.Point(702, 522);
            this.com_less.Name = "com_less";
            this.com_less.Size = new System.Drawing.Size(40, 23);
            this.com_less.TabIndex = 16;
            this.com_less.Text = "<";
            this.com_less.UseVisualStyleBackColor = true;
            // 
            // com_gore
            // 
            this.com_gore.Enabled = false;
            this.com_gore.Location = new System.Drawing.Point(747, 496);
            this.com_gore.Name = "com_gore";
            this.com_gore.Size = new System.Drawing.Size(40, 23);
            this.com_gore.TabIndex = 17;
            this.com_gore.Text = ">=";
            this.com_gore.UseVisualStyleBackColor = true;
            // 
            // com_lore
            // 
            this.com_lore.Enabled = false;
            this.com_lore.Location = new System.Drawing.Point(747, 522);
            this.com_lore.Name = "com_lore";
            this.com_lore.Size = new System.Drawing.Size(40, 23);
            this.com_lore.TabIndex = 18;
            this.com_lore.Text = "<=";
            this.com_lore.UseVisualStyleBackColor = true;
            // 
            // com_equal
            // 
            this.com_equal.Enabled = false;
            this.com_equal.Location = new System.Drawing.Point(793, 496);
            this.com_equal.Name = "com_equal";
            this.com_equal.Size = new System.Drawing.Size(40, 23);
            this.com_equal.TabIndex = 19;
            this.com_equal.Text = "=";
            this.com_equal.UseVisualStyleBackColor = true;
            // 
            // com_non_equal
            // 
            this.com_non_equal.Enabled = false;
            this.com_non_equal.Location = new System.Drawing.Point(793, 522);
            this.com_non_equal.Name = "com_non_equal";
            this.com_non_equal.Size = new System.Drawing.Size(40, 23);
            this.com_non_equal.TabIndex = 20;
            this.com_non_equal.Text = "/=";
            this.com_non_equal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 576);
            this.Controls.Add(this.com_non_equal);
            this.Controls.Add(this.com_equal);
            this.Controls.Add(this.com_lore);
            this.Controls.Add(this.com_gore);
            this.Controls.Add(this.com_less);
            this.Controls.Add(this.com_greater);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.clean_graph);
            this.Controls.Add(this.del_by_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.build_c);
            this.Controls.Add(this.build_b);
            this.Controls.Add(this.build_a);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Калькулятор нечетких множеств";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button build_a;
        private System.Windows.Forms.Button build_b;
        private System.Windows.Forms.Button build_c;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button del_by_name;
        private System.Windows.Forms.Button clean_graph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Button com_greater;
        private System.Windows.Forms.Button com_less;
        private System.Windows.Forms.Button com_gore;
        private System.Windows.Forms.Button com_lore;
        private System.Windows.Forms.Button com_equal;
        private System.Windows.Forms.Button com_non_equal;
    }
}


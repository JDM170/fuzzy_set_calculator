namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            // 
            // Column2
            // 
            this.Column2.HeaderText = "low";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "high";
            this.Column3.Name = "Column3";
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
            // 
            // Column5
            // 
            this.Column5.HeaderText = "low";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "high";
            this.Column6.Name = "Column6";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView3.Location = new System.Drawing.Point(12, 411);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(351, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "alpha";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "low";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "high";
            this.Column9.Name = "Column9";
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
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(380, 12);
            this.chart1.Name = "chart1";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Legend = "Legend1";
            series28.Name = "A1";
            series28.Points.Add(dataPoint19);
            series28.Points.Add(dataPoint20);
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Legend = "Legend1";
            series29.Name = "B2";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Legend = "Legend1";
            series30.Name = "C3";
            this.chart1.Series.Add(series28);
            this.chart1.Series.Add(series29);
            this.chart1.Series.Add(series30);
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
            this.build_a.Click += new System.EventHandler(this.build_a_Click);
            // 
            // build_b
            // 
            this.build_b.Location = new System.Drawing.Point(487, 458);
            this.build_b.Name = "build_b";
            this.build_b.Size = new System.Drawing.Size(101, 31);
            this.build_b.TabIndex = 9;
            this.build_b.Text = "Построить B";
            this.build_b.UseVisualStyleBackColor = true;
            this.build_b.Click += new System.EventHandler(this.build_b_Click);
            // 
            // build_c
            // 
            this.build_c.Location = new System.Drawing.Point(594, 458);
            this.build_c.Name = "build_c";
            this.build_c.Size = new System.Drawing.Size(101, 31);
            this.build_c.TabIndex = 10;
            this.build_c.Text = "Построить C";
            this.build_c.UseVisualStyleBackColor = true;
            this.build_c.Click += new System.EventHandler(this.build_c_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 574);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
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
    }
}


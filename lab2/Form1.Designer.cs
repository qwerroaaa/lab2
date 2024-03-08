namespace lab2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DollarLabel = new System.Windows.Forms.Label();
            this.EuroLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDollar = new System.Windows.Forms.NumericUpDown();
            this.inputEuro = new System.Windows.Forms.NumericUpDown();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DollarLabel
            // 
            this.DollarLabel.AutoSize = true;
            this.DollarLabel.Location = new System.Drawing.Point(56, 37);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(46, 13);
            this.DollarLabel.TabIndex = 0;
            this.DollarLabel.Text = "Доллар";
            // 
            // EuroLabel
            // 
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Location = new System.Drawing.Point(70, 66);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(32, 13);
            this.EuroLabel.TabIndex = 1;
            this.EuroLabel.Text = "Евро";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена валют(в рублях):";
            // 
            // inputDollar
            // 
            this.inputDollar.DecimalPlaces = 2;
            this.inputDollar.Location = new System.Drawing.Point(108, 37);
            this.inputDollar.Name = "inputDollar";
            this.inputDollar.Size = new System.Drawing.Size(120, 20);
            this.inputDollar.TabIndex = 3;
            this.inputDollar.Value = new decimal(new int[] {
            9075,
            0,
            0,
            131072});
            // 
            // inputEuro
            // 
            this.inputEuro.DecimalPlaces = 2;
            this.inputEuro.Location = new System.Drawing.Point(108, 66);
            this.inputEuro.Name = "inputEuro";
            this.inputEuro.Size = new System.Drawing.Size(120, 20);
            this.inputEuro.TabIndex = 4;
            this.inputEuro.Value = new decimal(new int[] {
            9888,
            0,
            0,
            131072});
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(234, 47);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 5;
            this.StartStopButton.Text = "Старт/Стоп";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(35, 108);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Доллар";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Евро";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(721, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.inputEuro);
            this.Controls.Add(this.inputDollar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EuroLabel);
            this.Controls.Add(this.DollarLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DollarLabel;
        private System.Windows.Forms.Label EuroLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputDollar;
        private System.Windows.Forms.NumericUpDown inputEuro;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}


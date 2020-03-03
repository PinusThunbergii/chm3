namespace chm3
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.calculateButton = new System.Windows.Forms.Button();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.displayChartCheckBox = new System.Windows.Forms.CheckBox();
            this.mLabel = new System.Windows.Forms.Label();
            this.mTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(39, 361);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButtonOnClickHandler);
            // 
            // mainChart
            // 
            chartArea3.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.mainChart.Legends.Add(legend3);
            this.mainChart.Location = new System.Drawing.Point(361, 37);
            this.mainChart.Name = "mainChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.mainChart.Series.Add(series5);
            this.mainChart.Series.Add(series6);
            this.mainChart.Size = new System.Drawing.Size(675, 466);
            this.mainChart.TabIndex = 1;
            this.mainChart.Text = "chart1";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(114, 154);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(127, 20);
            this.aTextBox.TabIndex = 2;
            this.aTextBox.Text = "0";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(114, 192);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(127, 20);
            this.bTextBox.TabIndex = 3;
            this.bTextBox.Text = "1";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(38, 157);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 13);
            this.aLabel.TabIndex = 4;
            this.aLabel.Text = "a";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(38, 192);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(13, 13);
            this.bLabel.TabIndex = 5;
            this.bLabel.Text = "b";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(38, 240);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(13, 13);
            this.nLabel.TabIndex = 7;
            this.nLabel.Text = "n";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(114, 240);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(127, 20);
            this.nTextBox.TabIndex = 6;
            this.nTextBox.Text = "1000";
            // 
            // resultTextBox
            // 
            this.resultTextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.resultTextBox.Location = new System.Drawing.Point(114, 316);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(214, 20);
            this.resultTextBox.TabIndex = 8;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(36, 319);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Result";
            // 
            // displayChartCheckBox
            // 
            this.displayChartCheckBox.AutoSize = true;
            this.displayChartCheckBox.Location = new System.Drawing.Point(130, 365);
            this.displayChartCheckBox.Name = "displayChartCheckBox";
            this.displayChartCheckBox.Size = new System.Drawing.Size(85, 17);
            this.displayChartCheckBox.TabIndex = 10;
            this.displayChartCheckBox.Text = "display chart";
            this.displayChartCheckBox.UseVisualStyleBackColor = true;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(38, 278);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(15, 13);
            this.mLabel.TabIndex = 12;
            this.mLabel.Text = "m";
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(114, 278);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(127, 20);
            this.mTextBox.TabIndex = 11;
            this.mTextBox.Text = "30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 559);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.displayChartCheckBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.CheckBox displayChartCheckBox;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.TextBox mTextBox;
    }
}


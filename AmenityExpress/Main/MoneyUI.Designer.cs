namespace AmenityExpress
{
    partial class MoneyUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Back_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.year_com = new System.Windows.Forms.ComboBox();
            this.month_com = new System.Windows.Forms.ComboBox();
            this.week_com = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(106, 172);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(722, 282);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(27, 504);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(103, 38);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "뒤로가기";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "총금액 xxxxxxxx";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "   20xx";
            // 
            // year_com
            // 
            this.year_com.FormattingEnabled = true;
            this.year_com.Location = new System.Drawing.Point(641, 22);
            this.year_com.Name = "year_com";
            this.year_com.Size = new System.Drawing.Size(81, 23);
            this.year_com.TabIndex = 13;
            this.year_com.Text = " 년도 별";
            this.year_com.SelectedIndexChanged += new System.EventHandler(this.year_com_SelectedIndexChanged);
            // 
            // month_com
            // 
            this.month_com.FormattingEnabled = true;
            this.month_com.Location = new System.Drawing.Point(758, 22);
            this.month_com.Name = "month_com";
            this.month_com.Size = new System.Drawing.Size(81, 23);
            this.month_com.TabIndex = 14;
            this.month_com.Text = " 월 별";
            this.month_com.SelectedIndexChanged += new System.EventHandler(this.month_com_SelectedIndexChanged);
            // 
            // week_com
            // 
            this.week_com.FormattingEnabled = true;
            this.week_com.Location = new System.Drawing.Point(880, 22);
            this.week_com.Name = "week_com";
            this.week_com.Size = new System.Drawing.Size(81, 23);
            this.week_com.TabIndex = 15;
            this.week_com.Text = "주 별";
            this.week_com.SelectedIndexChanged += new System.EventHandler(this.week_com_SelectedIndexChanged);
            // 
            // MoneyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 580);
            this.Controls.Add(this.week_com);
            this.Controls.Add(this.month_com);
            this.Controls.Add(this.year_com);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.chart1);
            this.Name = "MoneyUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MoneyUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox year_com;
        private System.Windows.Forms.ComboBox month_com;
        private System.Windows.Forms.ComboBox week_com;
    }
}
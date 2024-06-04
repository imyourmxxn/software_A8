namespace AmenityExpress
{
    partial class CustomerMainUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.체크인 = new System.Windows.Forms.ListBox();
            this.체크아웃 = new System.Windows.Forms.ListBox();
            this.최대인원수 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Notice_btn = new System.Windows.Forms.Button();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "예약조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.HideSelection = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(151, 34);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(561, 21);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.Text = "어서오세요 홍길동님 잔여 마일리지 : 2500p";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "회원정보수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(900, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "로그아웃";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // 체크인
            // 
            this.체크인.FormattingEnabled = true;
            this.체크인.ItemHeight = 12;
            this.체크인.Location = new System.Drawing.Point(23, 113);
            this.체크인.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.체크인.Name = "체크인";
            this.체크인.Size = new System.Drawing.Size(180, 76);
            this.체크인.TabIndex = 4;
            // 
            // 체크아웃
            // 
            this.체크아웃.FormattingEnabled = true;
            this.체크아웃.ItemHeight = 12;
            this.체크아웃.Location = new System.Drawing.Point(354, 113);
            this.체크아웃.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.체크아웃.Name = "체크아웃";
            this.체크아웃.Size = new System.Drawing.Size(176, 76);
            this.체크아웃.TabIndex = 5;
            // 
            // 최대인원수
            // 
            this.최대인원수.FormattingEnabled = true;
            this.최대인원수.ItemHeight = 12;
            this.최대인원수.Location = new System.Drawing.Point(675, 113);
            this.최대인원수.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.최대인원수.Name = "최대인원수";
            this.최대인원수.Size = new System.Drawing.Size(130, 76);
            this.최대인원수.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(676, 147);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 21);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(892, 128);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "검색";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 147);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(354, 143);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(176, 21);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 217);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 18);
            this.button5.TabIndex = 11;
            this.button5.Text = "핫딜";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 368);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 21);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "더블룸 입실 2024-05-05 최대인원 : 2";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 368);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 21);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "더블룸 입실 2024-05-05 최대인원 : 2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(528, 368);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(234, 21);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "더블룸 입실 2024-05-05 최대인원 : 2";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(783, 368);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(234, 21);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "더블룸 입실 2024-05-05 최대인원 : 2";
            // 
            // Notice_btn
            // 
            this.Notice_btn.Location = new System.Drawing.Point(96, 527);
            this.Notice_btn.Name = "Notice_btn";
            this.Notice_btn.Size = new System.Drawing.Size(970, 95);
            this.Notice_btn.TabIndex = 20;
            this.Notice_btn.Text = "공지사항";
            this.Notice_btn.UseVisualStyleBackColor = true;
            this.Notice_btn.Click += new System.EventHandler(this.Notice_btn_Click);
            // 
            // CustomerMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 698);
            this.Controls.Add(this.Notice_btn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.최대인원수);
            this.Controls.Add(this.체크아웃);
            this.Controls.Add(this.체크인);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "CustomerMainUI";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CustomerUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox 체크인;
        private System.Windows.Forms.ListBox 체크아웃;
        private System.Windows.Forms.ListBox 최대인원수;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Notice_btn;
    }
}
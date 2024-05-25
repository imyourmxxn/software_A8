namespace AmenityExpress
{
    partial class DialogForm
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
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            this.RoomNameLable = new System.Windows.Forms.Label();
            this.RoomNumLable = new System.Windows.Forms.Label();
            this.RoomNumTextBox = new System.Windows.Forms.TextBox();
            this.RoomPriceLable = new System.Windows.Forms.Label();
            this.RoomPricetextBox = new System.Windows.Forms.TextBox();
            this.RoomMaxLable = new System.Windows.Forms.Label();
            this.RoomMaxTextBox = new System.Windows.Forms.TextBox();
            this.RoomNoticeLable = new System.Windows.Forms.Label();
            this.RoomNoticeTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.RoomPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.Location = new System.Drawing.Point(225, 64);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomNameTextBox.TabIndex = 0;
            this.RoomNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RoomNameLable
            // 
            this.RoomNameLable.AutoSize = true;
            this.RoomNameLable.Location = new System.Drawing.Point(265, 49);
            this.RoomNameLable.Name = "RoomNameLable";
            this.RoomNameLable.Size = new System.Drawing.Size(57, 12);
            this.RoomNameLable.TabIndex = 1;
            this.RoomNameLable.Text = "객실 이름";
            // 
            // RoomNumLable
            // 
            this.RoomNumLable.AutoSize = true;
            this.RoomNumLable.Location = new System.Drawing.Point(265, 116);
            this.RoomNumLable.Name = "RoomNumLable";
            this.RoomNumLable.Size = new System.Drawing.Size(45, 12);
            this.RoomNumLable.TabIndex = 3;
            this.RoomNumLable.Text = "방 번호";
            // 
            // RoomNumTextBox
            // 
            this.RoomNumTextBox.Location = new System.Drawing.Point(225, 131);
            this.RoomNumTextBox.Name = "RoomNumTextBox";
            this.RoomNumTextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomNumTextBox.TabIndex = 2;
            // 
            // RoomPriceLable
            // 
            this.RoomPriceLable.AutoSize = true;
            this.RoomPriceLable.Location = new System.Drawing.Point(265, 180);
            this.RoomPriceLable.Name = "RoomPriceLable";
            this.RoomPriceLable.Size = new System.Drawing.Size(57, 12);
            this.RoomPriceLable.TabIndex = 5;
            this.RoomPriceLable.Text = "객실 가격";
            this.RoomPriceLable.Click += new System.EventHandler(this.RoomPriceLable_Click);
            // 
            // RoomPricetextBox
            // 
            this.RoomPricetextBox.Location = new System.Drawing.Point(225, 195);
            this.RoomPricetextBox.Name = "RoomPricetextBox";
            this.RoomPricetextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomPricetextBox.TabIndex = 4;
            // 
            // RoomMaxLable
            // 
            this.RoomMaxLable.AutoSize = true;
            this.RoomMaxLable.Location = new System.Drawing.Point(265, 236);
            this.RoomMaxLable.Name = "RoomMaxLable";
            this.RoomMaxLable.Size = new System.Drawing.Size(73, 12);
            this.RoomMaxLable.TabIndex = 7;
            this.RoomMaxLable.Text = "최대 인원 수";
            this.RoomMaxLable.Click += new System.EventHandler(this.label4_Click);
            // 
            // RoomMaxTextBox
            // 
            this.RoomMaxTextBox.Location = new System.Drawing.Point(225, 251);
            this.RoomMaxTextBox.Name = "RoomMaxTextBox";
            this.RoomMaxTextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomMaxTextBox.TabIndex = 6;
            // 
            // RoomNoticeLable
            // 
            this.RoomNoticeLable.AutoSize = true;
            this.RoomNoticeLable.Location = new System.Drawing.Point(265, 296);
            this.RoomNoticeLable.Name = "RoomNoticeLable";
            this.RoomNoticeLable.Size = new System.Drawing.Size(57, 12);
            this.RoomNoticeLable.TabIndex = 9;
            this.RoomNoticeLable.Text = "유의 사항";
            this.RoomNoticeLable.Click += new System.EventHandler(this.label5_Click);
            // 
            // RoomNoticeTextBox
            // 
            this.RoomNoticeTextBox.Location = new System.Drawing.Point(225, 311);
            this.RoomNoticeTextBox.Name = "RoomNoticeTextBox";
            this.RoomNoticeTextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomNoticeTextBox.TabIndex = 8;
            this.RoomNoticeTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(400, 388);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "등록";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(283, 388);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 11;
            this.Cancelbtn.Text = "취소";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // RoomPictureBox
            // 
            this.RoomPictureBox.Location = new System.Drawing.Point(24, 35);
            this.RoomPictureBox.Name = "RoomPictureBox";
            this.RoomPictureBox.Size = new System.Drawing.Size(131, 72);
            this.RoomPictureBox.TabIndex = 12;
            this.RoomPictureBox.TabStop = false;
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.RoomPictureBox);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.RoomNoticeLable);
            this.Controls.Add(this.RoomNoticeTextBox);
            this.Controls.Add(this.RoomMaxLable);
            this.Controls.Add(this.RoomMaxTextBox);
            this.Controls.Add(this.RoomPriceLable);
            this.Controls.Add(this.RoomPricetextBox);
            this.Controls.Add(this.RoomNumLable);
            this.Controls.Add(this.RoomNumTextBox);
            this.Controls.Add(this.RoomNameLable);
            this.Controls.Add(this.RoomNameTextBox);
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            this.Load += new System.EventHandler(this.DialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RoomNameTextBox;
        private System.Windows.Forms.Label RoomNameLable;
        private System.Windows.Forms.Label RoomNumLable;
        private System.Windows.Forms.TextBox RoomNumTextBox;
        private System.Windows.Forms.Label RoomPriceLable;
        private System.Windows.Forms.TextBox RoomPricetextBox;
        private System.Windows.Forms.Label RoomMaxLable;
        private System.Windows.Forms.TextBox RoomMaxTextBox;
        private System.Windows.Forms.Label RoomNoticeLable;
        private System.Windows.Forms.TextBox RoomNoticeTextBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.PictureBox RoomPictureBox;
    }
}
namespace AmenityExpress.RoomManagement
{
    partial class RoomInformRetouching
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
            this.RoomPictureBox = new System.Windows.Forms.PictureBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.RoomNoticeLable = new System.Windows.Forms.Label();
            this.RoomNoticeTextBox = new System.Windows.Forms.TextBox();
            this.RoomMaxLable = new System.Windows.Forms.Label();
            this.RoomMaxTextBox = new System.Windows.Forms.TextBox();
            this.RoomPriceLable = new System.Windows.Forms.Label();
            this.RoomPricetextBox = new System.Windows.Forms.TextBox();
            this.RoomNumLable = new System.Windows.Forms.Label();
            this.RoomNumTextBox = new System.Windows.Forms.TextBox();
            this.RoomNameLable = new System.Windows.Forms.Label();
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            this.RetouchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomPictureBox
            // 
            this.RoomPictureBox.Location = new System.Drawing.Point(21, 30);
            this.RoomPictureBox.Name = "RoomPictureBox";
            this.RoomPictureBox.Size = new System.Drawing.Size(131, 72);
            this.RoomPictureBox.TabIndex = 25;
            this.RoomPictureBox.TabStop = false;
            this.RoomPictureBox.Click += new System.EventHandler(this.RoomPictureBox_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(280, 383);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 24;
            this.Cancelbtn.Text = "취소";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // RoomNoticeLable
            // 
            this.RoomNoticeLable.AutoSize = true;
            this.RoomNoticeLable.Location = new System.Drawing.Point(262, 291);
            this.RoomNoticeLable.Name = "RoomNoticeLable";
            this.RoomNoticeLable.Size = new System.Drawing.Size(57, 12);
            this.RoomNoticeLable.TabIndex = 22;
            this.RoomNoticeLable.Text = "유의 사항";
            this.RoomNoticeLable.Click += new System.EventHandler(this.RoomNoticeLable_Click);
            // 
            // RoomNoticeTextBox
            // 
            this.RoomNoticeTextBox.Location = new System.Drawing.Point(222, 306);
            this.RoomNoticeTextBox.Name = "RoomNoticeTextBox";
            this.RoomNoticeTextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomNoticeTextBox.TabIndex = 21;
            this.RoomNoticeTextBox.TextChanged += new System.EventHandler(this.RoomNoticeTextBox_TextChanged);
            // 
            // RoomMaxLable
            // 
            this.RoomMaxLable.AutoSize = true;
            this.RoomMaxLable.Location = new System.Drawing.Point(262, 231);
            this.RoomMaxLable.Name = "RoomMaxLable";
            this.RoomMaxLable.Size = new System.Drawing.Size(73, 12);
            this.RoomMaxLable.TabIndex = 20;
            this.RoomMaxLable.Text = "최대 인원 수";
            this.RoomMaxLable.Click += new System.EventHandler(this.RoomMaxLable_Click);
            // 
            // RoomMaxTextBox
            // 
            this.RoomMaxTextBox.Location = new System.Drawing.Point(222, 246);
            this.RoomMaxTextBox.Name = "RoomMaxTextBox";
            this.RoomMaxTextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomMaxTextBox.TabIndex = 19;
            this.RoomMaxTextBox.TextChanged += new System.EventHandler(this.RoomMaxTextBox_TextChanged);
            // 
            // RoomPriceLable
            // 
            this.RoomPriceLable.AutoSize = true;
            this.RoomPriceLable.Location = new System.Drawing.Point(262, 175);
            this.RoomPriceLable.Name = "RoomPriceLable";
            this.RoomPriceLable.Size = new System.Drawing.Size(57, 12);
            this.RoomPriceLable.TabIndex = 18;
            this.RoomPriceLable.Text = "객실 가격";
            this.RoomPriceLable.Click += new System.EventHandler(this.RoomPriceLable_Click);
            // 
            // RoomPricetextBox
            // 
            this.RoomPricetextBox.Location = new System.Drawing.Point(222, 190);
            this.RoomPricetextBox.Name = "RoomPricetextBox";
            this.RoomPricetextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomPricetextBox.TabIndex = 17;
            this.RoomPricetextBox.TextChanged += new System.EventHandler(this.RoomPricetextBox_TextChanged);
            // 
            // RoomNumLable
            // 
            this.RoomNumLable.AutoSize = true;
            this.RoomNumLable.Location = new System.Drawing.Point(262, 111);
            this.RoomNumLable.Name = "RoomNumLable";
            this.RoomNumLable.Size = new System.Drawing.Size(45, 12);
            this.RoomNumLable.TabIndex = 16;
            this.RoomNumLable.Text = "방 번호";
            this.RoomNumLable.Click += new System.EventHandler(this.RoomNumLable_Click);
            // 
            // RoomNumTextBox
            // 
            this.RoomNumTextBox.Location = new System.Drawing.Point(222, 126);
            this.RoomNumTextBox.Name = "RoomNumTextBox";
            this.RoomNumTextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomNumTextBox.TabIndex = 15;
            this.RoomNumTextBox.TextChanged += new System.EventHandler(this.RoomNumTextBox_TextChanged);
            // 
            // RoomNameLable
            // 
            this.RoomNameLable.AutoSize = true;
            this.RoomNameLable.Location = new System.Drawing.Point(262, 44);
            this.RoomNameLable.Name = "RoomNameLable";
            this.RoomNameLable.Size = new System.Drawing.Size(57, 12);
            this.RoomNameLable.TabIndex = 14;
            this.RoomNameLable.Text = "객실 이름";
            this.RoomNameLable.Click += new System.EventHandler(this.RoomNameLable_Click);
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.Location = new System.Drawing.Point(222, 59);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.Size = new System.Drawing.Size(144, 21);
            this.RoomNameTextBox.TabIndex = 13;
            this.RoomNameTextBox.TextChanged += new System.EventHandler(this.RoomNameTextBox_TextChanged);
            // 
            // RetouchBtn
            // 
            this.RetouchBtn.Location = new System.Drawing.Point(397, 383);
            this.RetouchBtn.Name = "RetouchBtn";
            this.RetouchBtn.Size = new System.Drawing.Size(75, 23);
            this.RetouchBtn.TabIndex = 26;
            this.RetouchBtn.Text = "수정";
            this.RetouchBtn.UseVisualStyleBackColor = true;
            this.RetouchBtn.Click += new System.EventHandler(this.RetouchBtn_Click);
            // 
            // RoomInformRetouching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 443);
            this.Controls.Add(this.RetouchBtn);
            this.Controls.Add(this.RoomPictureBox);
            this.Controls.Add(this.Cancelbtn);
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
            this.Name = "RoomInformRetouching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomInformRetouching";
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RoomPictureBox;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label RoomNoticeLable;
        private System.Windows.Forms.TextBox RoomNoticeTextBox;
        private System.Windows.Forms.Label RoomMaxLable;
        private System.Windows.Forms.TextBox RoomMaxTextBox;
        private System.Windows.Forms.Label RoomPriceLable;
        private System.Windows.Forms.TextBox RoomPricetextBox;
        private System.Windows.Forms.Label RoomNumLable;
        private System.Windows.Forms.TextBox RoomNumTextBox;
        private System.Windows.Forms.Label RoomNameLable;
        private System.Windows.Forms.TextBox RoomNameTextBox;
        private System.Windows.Forms.Button RetouchBtn;
    }
}
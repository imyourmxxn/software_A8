namespace AmenityExpress
{
    partial class RequestManage_Form
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
            this.RequestManageAnswer_btn = new System.Windows.Forms.Button();
            this.RequestManagetoMainRequestUI_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answered_radio = new System.Windows.Forms.RadioButton();
            this.TotalAnswer_radio = new System.Windows.Forms.RadioButton();
            this.UnAnswered_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestManageAnswer_btn
            // 
            this.RequestManageAnswer_btn.Location = new System.Drawing.Point(1128, 521);
            this.RequestManageAnswer_btn.Name = "RequestManageAnswer_btn";
            this.RequestManageAnswer_btn.Size = new System.Drawing.Size(132, 43);
            this.RequestManageAnswer_btn.TabIndex = 1;
            this.RequestManageAnswer_btn.Text = "답변하기";
            this.RequestManageAnswer_btn.UseVisualStyleBackColor = true;
            this.RequestManageAnswer_btn.Click += new System.EventHandler(this.RequestManageAnswer_btn_Click);
            // 
            // RequestManagetoMainRequestUI_btn
            // 
            this.RequestManagetoMainRequestUI_btn.Location = new System.Drawing.Point(979, 521);
            this.RequestManagetoMainRequestUI_btn.Name = "RequestManagetoMainRequestUI_btn";
            this.RequestManagetoMainRequestUI_btn.Size = new System.Drawing.Size(132, 43);
            this.RequestManagetoMainRequestUI_btn.TabIndex = 4;
            this.RequestManagetoMainRequestUI_btn.Text = "뒤로가기";
            this.RequestManagetoMainRequestUI_btn.UseVisualStyleBackColor = true;
            this.RequestManagetoMainRequestUI_btn.Click += new System.EventHandler(this.RequestManagetoMainRequestUI_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(52, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1236, 412);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "작성자 ID";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "이름";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "객실번호";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "작성시간";
            this.columnHeader5.Width = 126;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "요청 종류";
            this.columnHeader6.Width = 172;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "요청내용";
            this.columnHeader7.Width = 139;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "답변내용";
            this.columnHeader8.Width = 377;
            // 
            // Answered_radio
            // 
            this.Answered_radio.AutoSize = true;
            this.Answered_radio.Location = new System.Drawing.Point(392, 18);
            this.Answered_radio.Name = "Answered_radio";
            this.Answered_radio.Size = new System.Drawing.Size(105, 22);
            this.Answered_radio.TabIndex = 7;
            this.Answered_radio.TabStop = true;
            this.Answered_radio.Text = "답변완료";
            this.Answered_radio.UseVisualStyleBackColor = true;
            this.Answered_radio.CheckedChanged += new System.EventHandler(this.Answered_radio_CheckedChanged);
            // 
            // TotalAnswer_radio
            // 
            this.TotalAnswer_radio.AutoSize = true;
            this.TotalAnswer_radio.Location = new System.Drawing.Point(149, 18);
            this.TotalAnswer_radio.Name = "TotalAnswer_radio";
            this.TotalAnswer_radio.Size = new System.Drawing.Size(105, 22);
            this.TotalAnswer_radio.TabIndex = 8;
            this.TotalAnswer_radio.TabStop = true;
            this.TotalAnswer_radio.Text = "전체답변";
            this.TotalAnswer_radio.UseVisualStyleBackColor = true;
            this.TotalAnswer_radio.CheckedChanged += new System.EventHandler(this.TotalAnswer_radio_CheckedChanged);
            // 
            // UnAnswered_radio
            // 
            this.UnAnswered_radio.AutoSize = true;
            this.UnAnswered_radio.Location = new System.Drawing.Point(279, 18);
            this.UnAnswered_radio.Name = "UnAnswered_radio";
            this.UnAnswered_radio.Size = new System.Drawing.Size(87, 22);
            this.UnAnswered_radio.TabIndex = 9;
            this.UnAnswered_radio.TabStop = true;
            this.UnAnswered_radio.Text = "답변전";
            this.UnAnswered_radio.UseVisualStyleBackColor = true;
            this.UnAnswered_radio.CheckedChanged += new System.EventHandler(this.UnAnswered_radio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Answered_radio);
            this.groupBox1.Controls.Add(this.UnAnswered_radio);
            this.groupBox1.Controls.Add(this.TotalAnswer_radio);
            this.groupBox1.Location = new System.Drawing.Point(763, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 57);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "답변상태";
            // 
            // RequestManage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.RequestManagetoMainRequestUI_btn);
            this.Controls.Add(this.RequestManageAnswer_btn);
            this.Name = "RequestManage_Form";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RequestManageAnswer_btn;
        private System.Windows.Forms.Button RequestManagetoMainRequestUI_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.RadioButton Answered_radio;
        private System.Windows.Forms.RadioButton TotalAnswer_radio;
        private System.Windows.Forms.RadioButton UnAnswered_radio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
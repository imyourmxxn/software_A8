﻿namespace AmenityExpress
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
            this.RequestManage_list = new System.Windows.Forms.ListView();
            this.Answered_radio = new System.Windows.Forms.RadioButton();
            this.TotalAnswer_radio = new System.Windows.Forms.RadioButton();
            this.UnAnswered_radio = new System.Windows.Forms.RadioButton();
            this.StatueGroup = new System.Windows.Forms.GroupBox();
            this.ToFAQ_btn = new System.Windows.Forms.Button();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatueGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestManageAnswer_btn
            // 
            this.RequestManageAnswer_btn.Location = new System.Drawing.Point(1381, 521);
            this.RequestManageAnswer_btn.Name = "RequestManageAnswer_btn";
            this.RequestManageAnswer_btn.Size = new System.Drawing.Size(132, 43);
            this.RequestManageAnswer_btn.TabIndex = 1;
            this.RequestManageAnswer_btn.Text = "답변하기";
            this.RequestManageAnswer_btn.UseVisualStyleBackColor = true;
            this.RequestManageAnswer_btn.Click += new System.EventHandler(this.RequestManageAnswer_btn_Click);
            // 
            // RequestManagetoMainRequestUI_btn
            // 
            this.RequestManagetoMainRequestUI_btn.Location = new System.Drawing.Point(1232, 521);
            this.RequestManagetoMainRequestUI_btn.Name = "RequestManagetoMainRequestUI_btn";
            this.RequestManagetoMainRequestUI_btn.Size = new System.Drawing.Size(132, 43);
            this.RequestManagetoMainRequestUI_btn.TabIndex = 4;
            this.RequestManagetoMainRequestUI_btn.Text = "뒤로가기";
            this.RequestManagetoMainRequestUI_btn.UseVisualStyleBackColor = true;
            this.RequestManagetoMainRequestUI_btn.Click += new System.EventHandler(this.RequestManagetoMainRequestUI_btn_Click);
            // 
            // RequestManage_list
            // 
            this.RequestManage_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.RequestManage_list.HideSelection = false;
            this.RequestManage_list.Location = new System.Drawing.Point(24, 85);
            this.RequestManage_list.Name = "RequestManage_list";
            this.RequestManage_list.Size = new System.Drawing.Size(1489, 412);
            this.RequestManage_list.TabIndex = 5;
            this.RequestManage_list.UseCompatibleStateImageBehavior = false;
            this.RequestManage_list.View = System.Windows.Forms.View.Details;
            this.RequestManage_list.SelectedIndexChanged += new System.EventHandler(this.RequestManage_list_SelectedIndexChanged);
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
            // StatueGroup
            // 
            this.StatueGroup.Controls.Add(this.Answered_radio);
            this.StatueGroup.Controls.Add(this.UnAnswered_radio);
            this.StatueGroup.Controls.Add(this.TotalAnswer_radio);
            this.StatueGroup.Location = new System.Drawing.Point(988, 12);
            this.StatueGroup.Name = "StatueGroup";
            this.StatueGroup.Size = new System.Drawing.Size(525, 57);
            this.StatueGroup.TabIndex = 10;
            this.StatueGroup.TabStop = false;
            this.StatueGroup.Text = "답변상태";
            // 
            // ToFAQ_btn
            // 
            this.ToFAQ_btn.Location = new System.Drawing.Point(24, 521);
            this.ToFAQ_btn.Name = "ToFAQ_btn";
            this.ToFAQ_btn.Size = new System.Drawing.Size(132, 43);
            this.ToFAQ_btn.TabIndex = 11;
            this.ToFAQ_btn.Text = "FAQ관리";
            this.ToFAQ_btn.UseVisualStyleBackColor = true;
            this.ToFAQ_btn.Click += new System.EventHandler(this.ToFAQ_btn_Click);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "NO";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "답변상태";
            this.columnHeader11.Width = 102;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "작성자ID";
            this.columnHeader12.Width = 137;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "객실번호";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "작성시간";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "요청종류";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "요청내용";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "답변내용";
            // 
            // RequestManage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 587);
            this.Controls.Add(this.ToFAQ_btn);
            this.Controls.Add(this.StatueGroup);
            this.Controls.Add(this.RequestManage_list);
            this.Controls.Add(this.RequestManagetoMainRequestUI_btn);
            this.Controls.Add(this.RequestManageAnswer_btn);
            this.Name = "RequestManage_Form";
            this.Text = "요청사항리스트";
            this.StatueGroup.ResumeLayout(false);
            this.StatueGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RequestManageAnswer_btn;
        private System.Windows.Forms.Button RequestManagetoMainRequestUI_btn;
        private System.Windows.Forms.ListView RequestManage_list;
        private System.Windows.Forms.RadioButton Answered_radio;
        private System.Windows.Forms.RadioButton TotalAnswer_radio;
        private System.Windows.Forms.RadioButton UnAnswered_radio;
        private System.Windows.Forms.GroupBox StatueGroup;
        private System.Windows.Forms.Button ToFAQ_btn;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
    }
}
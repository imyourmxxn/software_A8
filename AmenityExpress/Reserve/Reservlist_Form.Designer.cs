namespace AmenityExpress
{
    partial class Reservlist_Form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Reservelist_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reservelist_lbl = new System.Windows.Forms.Label();
            this.Check_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Room_lbl = new System.Windows.Forms.Label();
            this.Room_cbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.CKOUT_dtp = new System.Windows.Forms.DateTimePicker();
            this.CKIN_dtp = new System.Windows.Forms.DateTimePicker();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Search_lbl = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Reservelist_listView);
            this.panel2.Controls.Add(this.Reservelist_lbl);
            this.panel2.Location = new System.Drawing.Point(24, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 439);
            this.panel2.TabIndex = 23;
            // 
            // Reservelist_listView
            // 
            this.Reservelist_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader3});
            this.Reservelist_listView.FullRowSelect = true;
            this.Reservelist_listView.GridLines = true;
            this.Reservelist_listView.HideSelection = false;
            this.Reservelist_listView.Location = new System.Drawing.Point(0, 42);
            this.Reservelist_listView.MultiSelect = false;
            this.Reservelist_listView.Name = "Reservelist_listView";
            this.Reservelist_listView.Size = new System.Drawing.Size(1070, 343);
            this.Reservelist_listView.TabIndex = 16;
            this.Reservelist_listView.UseCompatibleStateImageBehavior = false;
            this.Reservelist_listView.View = System.Windows.Forms.View.Details;
            this.Reservelist_listView.SelectedIndexChanged += new System.EventHandler(this.Reservelist_listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "성명";
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "연락처";
            this.columnHeader2.Width = 570;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 2;
            this.columnHeader5.Text = "체크인";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 3;
            this.columnHeader6.Text = "체크아웃";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 4;
            this.columnHeader3.Text = "객실번호";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No.";
            this.columnHeader4.Width = 50;
            // 
            // Reservelist_lbl
            // 
            this.Reservelist_lbl.AutoSize = true;
            this.Reservelist_lbl.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.Reservelist_lbl.Location = new System.Drawing.Point(3, 11);
            this.Reservelist_lbl.Name = "Reservelist_lbl";
            this.Reservelist_lbl.Size = new System.Drawing.Size(139, 28);
            this.Reservelist_lbl.TabIndex = 15;
            this.Reservelist_lbl.Text = "예약자 리스트";
            // 
            // Check_btn
            // 
            this.Check_btn.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Check_btn.Location = new System.Drawing.Point(981, 595);
            this.Check_btn.Name = "Check_btn";
            this.Check_btn.Size = new System.Drawing.Size(130, 45);
            this.Check_btn.TabIndex = 21;
            this.Check_btn.Text = "확인";
            this.Check_btn.UseVisualStyleBackColor = true;
            this.Check_btn.Click += new System.EventHandler(this.Check_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Search_btn);
            this.panel1.Controls.Add(this.Room_lbl);
            this.panel1.Controls.Add(this.Room_cbb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Date_lbl);
            this.panel1.Controls.Add(this.CKOUT_dtp);
            this.panel1.Controls.Add(this.CKIN_dtp);
            this.panel1.Controls.Add(this.Search_txt);
            this.panel1.Controls.Add(this.Search_lbl);
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 77);
            this.panel1.TabIndex = 20;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(410, 0);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(82, 35);
            this.Search_btn.TabIndex = 15;
            this.Search_btn.Text = "검색";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Room_lbl
            // 
            this.Room_lbl.AutoSize = true;
            this.Room_lbl.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.Room_lbl.Location = new System.Drawing.Point(489, 49);
            this.Room_lbl.Name = "Room_lbl";
            this.Room_lbl.Size = new System.Drawing.Size(92, 28);
            this.Room_lbl.TabIndex = 14;
            this.Room_lbl.Text = "객실번호";
            this.Room_lbl.Click += new System.EventHandler(this.Room_lbl_Click);
            // 
            // Room_cbb
            // 
            this.Room_cbb.DisplayMember = "선택안함";
            this.Room_cbb.Font = new System.Drawing.Font("굴림", 11F);
            this.Room_cbb.FormattingEnabled = true;
            this.Room_cbb.Items.AddRange(new object[] {
            "선택안함",
            "101",
            "102",
            "104",
            "105",
            "108",
            "198",
            "501"});
            this.Room_cbb.Location = new System.Drawing.Point(587, 53);
            this.Room_cbb.Name = "Room_cbb";
            this.Room_cbb.Size = new System.Drawing.Size(121, 23);
            this.Room_cbb.TabIndex = 13;
            this.Room_cbb.SelectedIndexChanged += new System.EventHandler(this.Room_cbb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.label3.Location = new System.Drawing.Point(264, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "~";
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.Date_lbl.Location = new System.Drawing.Point(19, 46);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(52, 28);
            this.Date_lbl.TabIndex = 11;
            this.Date_lbl.Text = "기간";
            // 
            // CKOUT_dtp
            // 
            this.CKOUT_dtp.Location = new System.Drawing.Point(296, 53);
            this.CKOUT_dtp.Name = "CKOUT_dtp";
            this.CKOUT_dtp.Size = new System.Drawing.Size(178, 21);
            this.CKOUT_dtp.TabIndex = 10;
            // 
            // CKIN_dtp
            // 
            this.CKIN_dtp.Location = new System.Drawing.Point(80, 53);
            this.CKIN_dtp.Name = "CKIN_dtp";
            this.CKIN_dtp.Size = new System.Drawing.Size(178, 21);
            this.CKIN_dtp.TabIndex = 9;
            // 
            // Search_txt
            // 
            this.Search_txt.Font = new System.Drawing.Font("맑은 고딕", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Search_txt.Location = new System.Drawing.Point(77, 0);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(336, 38);
            this.Search_txt.TabIndex = 7;
            this.Search_txt.TextChanged += new System.EventHandler(this.Search_txt_TextChanged);
            // 
            // Search_lbl
            // 
            this.Search_lbl.AutoSize = true;
            this.Search_lbl.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Search_lbl.Location = new System.Drawing.Point(0, 0);
            this.Search_lbl.Name = "Search_lbl";
            this.Search_lbl.Size = new System.Drawing.Size(71, 37);
            this.Search_lbl.TabIndex = 3;
            this.Search_lbl.Text = "이름";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Cancel_btn.Location = new System.Drawing.Point(24, 595);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(130, 45);
            this.Cancel_btn.TabIndex = 24;
            this.Cancel_btn.Text = "이전";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Reservlist_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Check_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reservlist_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservlist_Form";
            this.Load += new System.EventHandler(this.Reservlist_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView Reservelist_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label Reservelist_lbl;
        private System.Windows.Forms.Button Check_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Room_lbl;
        private System.Windows.Forms.ComboBox Room_cbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.DateTimePicker CKOUT_dtp;
        private System.Windows.Forms.DateTimePicker CKIN_dtp;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Label Search_lbl;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Cancel_btn;
    }
}
namespace AmenityExpress
{
    partial class RequestWrite_Form
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
            this.RequestKind_lbl = new System.Windows.Forms.Label();
            this.RequestKind_CmBox = new System.Windows.Forms.ComboBox();
            this.RequestWrite_lbl = new System.Windows.Forms.Label();
            this.RequestContent_txt = new System.Windows.Forms.TextBox();
            this.RequestWriteEnroll_btn = new System.Windows.Forms.Button();
            this.RequestWriteBack_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestKind_lbl
            // 
            this.RequestKind_lbl.AutoSize = true;
            this.RequestKind_lbl.Location = new System.Drawing.Point(40, 28);
            this.RequestKind_lbl.Name = "RequestKind_lbl";
            this.RequestKind_lbl.Size = new System.Drawing.Size(343, 18);
            this.RequestKind_lbl.TabIndex = 0;
            this.RequestKind_lbl.Text = "어떤 종류의 요청사항인가요? (필수 선택)";
            // 
            // RequestKind_CmBox
            // 
            this.RequestKind_CmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RequestKind_CmBox.FormattingEnabled = true;
            this.RequestKind_CmBox.Location = new System.Drawing.Point(43, 65);
            this.RequestKind_CmBox.Name = "RequestKind_CmBox";
            this.RequestKind_CmBox.Size = new System.Drawing.Size(665, 26);
            this.RequestKind_CmBox.TabIndex = 1;
            this.RequestKind_CmBox.SelectedIndexChanged += new System.EventHandler(this.RequestKind_CmBox_SelectedIndexChanged);
            // 
            // RequestWrite_lbl
            // 
            this.RequestWrite_lbl.AutoSize = true;
            this.RequestWrite_lbl.Location = new System.Drawing.Point(43, 143);
            this.RequestWrite_lbl.Name = "RequestWrite_lbl";
            this.RequestWrite_lbl.Size = new System.Drawing.Size(254, 18);
            this.RequestWrite_lbl.TabIndex = 2;
            this.RequestWrite_lbl.Text = "요청사항을 입력하세요. (필수)";
            // 
            // RequestContent_txt
            // 
            this.RequestContent_txt.Location = new System.Drawing.Point(46, 174);
            this.RequestContent_txt.Multiline = true;
            this.RequestContent_txt.Name = "RequestContent_txt";
            this.RequestContent_txt.Size = new System.Drawing.Size(662, 305);
            this.RequestContent_txt.TabIndex = 3;
            this.RequestContent_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RequestWriteEnroll_btn
            // 
            this.RequestWriteEnroll_btn.Location = new System.Drawing.Point(613, 513);
            this.RequestWriteEnroll_btn.Name = "RequestWriteEnroll_btn";
            this.RequestWriteEnroll_btn.Size = new System.Drawing.Size(95, 40);
            this.RequestWriteEnroll_btn.TabIndex = 6;
            this.RequestWriteEnroll_btn.Text = "등록";
            this.RequestWriteEnroll_btn.UseVisualStyleBackColor = true;
            this.RequestWriteEnroll_btn.Click += new System.EventHandler(this.RequestWriteEnroll_btn_Click);
            // 
            // RequestWriteBack_btn
            // 
            this.RequestWriteBack_btn.Location = new System.Drawing.Point(500, 513);
            this.RequestWriteBack_btn.Name = "RequestWriteBack_btn";
            this.RequestWriteBack_btn.Size = new System.Drawing.Size(95, 40);
            this.RequestWriteBack_btn.TabIndex = 7;
            this.RequestWriteBack_btn.Text = "뒤로가기";
            this.RequestWriteBack_btn.UseVisualStyleBackColor = true;
            this.RequestWriteBack_btn.Click += new System.EventHandler(this.RequestWriteBack_btn_Click);
            // 
            // RequestWrite_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 578);
            this.Controls.Add(this.RequestWriteBack_btn);
            this.Controls.Add(this.RequestWriteEnroll_btn);
            this.Controls.Add(this.RequestContent_txt);
            this.Controls.Add(this.RequestWrite_lbl);
            this.Controls.Add(this.RequestKind_CmBox);
            this.Controls.Add(this.RequestKind_lbl);
            this.Name = "RequestWrite_Form";
            this.Text = "요청사항작성";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RequestKind_lbl;
        private System.Windows.Forms.ComboBox RequestKind_CmBox;
        private System.Windows.Forms.Label RequestWrite_lbl;
        private System.Windows.Forms.TextBox RequestContent_txt;
        private System.Windows.Forms.Button RequestWriteEnroll_btn;
        private System.Windows.Forms.Button RequestWriteBack_btn;
    }
}
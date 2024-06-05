namespace AmenityExpress
{
    partial class RequestList_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.RequestListFAQ_btn = new System.Windows.Forms.Button();
            this.RequestList_list = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestList_groupbox = new System.Windows.Forms.GroupBox();
            this.RequestListBack_btn = new System.Windows.Forms.Button();
            this.RequestList_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestListFAQ_btn
            // 
            this.RequestListFAQ_btn.Location = new System.Drawing.Point(1201, 25);
            this.RequestListFAQ_btn.Name = "RequestListFAQ_btn";
            this.RequestListFAQ_btn.Size = new System.Drawing.Size(125, 53);
            this.RequestListFAQ_btn.TabIndex = 0;
            this.RequestListFAQ_btn.Text = "FAQ";
            this.RequestListFAQ_btn.UseVisualStyleBackColor = true;
            this.RequestListFAQ_btn.Click += new System.EventHandler(this.RequestListFAQ_btn_Click);
            // 
            // RequestList_list
            // 
            this.RequestList_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.RequestList_list.HideSelection = false;
            this.RequestList_list.Location = new System.Drawing.Point(40, 47);
            this.RequestList_list.Name = "RequestList_list";
            this.RequestList_list.Size = new System.Drawing.Size(1294, 420);
            this.RequestList_list.TabIndex = 3;
            this.RequestList_list.UseCompatibleStateImageBehavior = false;
            this.RequestList_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "No";
            this.columnHeader6.Width = 144;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "답변상태";
            this.columnHeader7.Width = 97;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "고객아이디";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "객실번호";
            this.columnHeader9.Width = 177;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "작성일자";
            this.columnHeader10.Width = 125;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "요청종류";
            this.columnHeader11.Width = 134;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "요청내용";
            this.columnHeader12.Width = 108;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "관리자아이디";
            this.columnHeader13.Width = 110;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "답변일자";
            this.columnHeader14.Width = 114;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "답변내용";
            this.columnHeader15.Width = 38;
            // 
            // RequestList_groupbox
            // 
            this.RequestList_groupbox.Controls.Add(this.RequestList_list);
            this.RequestList_groupbox.Location = new System.Drawing.Point(23, 84);
            this.RequestList_groupbox.Name = "RequestList_groupbox";
            this.RequestList_groupbox.Size = new System.Drawing.Size(1303, 503);
            this.RequestList_groupbox.TabIndex = 4;
            this.RequestList_groupbox.TabStop = false;
            this.RequestList_groupbox.Text = "요청사항목록";
            this.RequestList_groupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RequestListBack_btn
            // 
            this.RequestListBack_btn.Location = new System.Drawing.Point(1056, 25);
            this.RequestListBack_btn.Name = "RequestListBack_btn";
            this.RequestListBack_btn.Size = new System.Drawing.Size(125, 53);
            this.RequestListBack_btn.TabIndex = 5;
            this.RequestListBack_btn.Text = "뒤로가기";
            this.RequestListBack_btn.UseVisualStyleBackColor = true;
            this.RequestListBack_btn.Click += new System.EventHandler(this.RequestListBack_btn_Click);
            // 
            // RequestList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 599);
            this.Controls.Add(this.RequestListBack_btn);
            this.Controls.Add(this.RequestList_groupbox);
            this.Controls.Add(this.RequestListFAQ_btn);
            this.Name = "RequestList_Form";
            this.Text = "요청사항리스트";
            this.Load += new System.EventHandler(this.RequestList_Form_Load);
            this.RequestList_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RequestListFAQ_btn;
        private System.Windows.Forms.ListView RequestList_list;
        private System.Windows.Forms.GroupBox RequestList_groupbox;
        private System.Windows.Forms.Button RequestListBack_btn;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}


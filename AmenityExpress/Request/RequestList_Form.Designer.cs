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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestList_groupbox = new System.Windows.Forms.GroupBox();
            this.RequestListBack_btn = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.RequestList_list.HideSelection = false;
            this.RequestList_list.Location = new System.Drawing.Point(40, 47);
            this.RequestList_list.Name = "RequestList_list";
            this.RequestList_list.Size = new System.Drawing.Size(1217, 420);
            this.RequestList_list.TabIndex = 3;
            this.RequestList_list.UseCompatibleStateImageBehavior = false;
            this.RequestList_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "답변상태";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "작성시간";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "요청 종류";
            this.columnHeader3.Width = 192;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "요청내용";
            this.columnHeader4.Width = 456;
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "답변내용";
            this.columnHeader5.Width = 425;
            // 
            // RequestList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 651);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox RequestList_groupbox;
        private System.Windows.Forms.Button RequestListBack_btn;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}


namespace AmenityExpress
{
    partial class ManagerMainUI
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
            this.reserv_btn = new System.Windows.Forms.Button();
            this.room_btn = new System.Windows.Forms.Button();
            this.request_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reserv_btn
            // 
            this.reserv_btn.Font = new System.Drawing.Font("굴림", 20F);
            this.reserv_btn.Location = new System.Drawing.Point(78, 195);
            this.reserv_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reserv_btn.Name = "reserv_btn";
            this.reserv_btn.Size = new System.Drawing.Size(208, 115);
            this.reserv_btn.TabIndex = 3;
            this.reserv_btn.Text = "예약관리";
            this.reserv_btn.UseVisualStyleBackColor = true;
            this.reserv_btn.Click += new System.EventHandler(this.reserv_btn_Click);
            // 
            // room_btn
            // 
            this.room_btn.Font = new System.Drawing.Font("굴림", 20F);
            this.room_btn.Location = new System.Drawing.Point(387, 68);
            this.room_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room_btn.Name = "room_btn";
            this.room_btn.Size = new System.Drawing.Size(204, 98);
            this.room_btn.TabIndex = 12;
            this.room_btn.Text = "객실관리";
            this.room_btn.UseVisualStyleBackColor = true;
            this.room_btn.Click += new System.EventHandler(this.room_btn_Click);
            // 
            // request_btn
            // 
            this.request_btn.Font = new System.Drawing.Font("굴림", 20F);
            this.request_btn.Location = new System.Drawing.Point(387, 195);
            this.request_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.request_btn.Name = "request_btn";
            this.request_btn.Size = new System.Drawing.Size(204, 115);
            this.request_btn.TabIndex = 13;
            this.request_btn.Text = "요청사항관리";
            this.request_btn.UseVisualStyleBackColor = true;
            this.request_btn.Click += new System.EventHandler(this.request_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("굴림", 20F);
            this.login_btn.Location = new System.Drawing.Point(78, 68);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(208, 98);
            this.login_btn.TabIndex = 14;
            this.login_btn.Text = "회원관리";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(576, 20);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(97, 30);
            this.LogOutBtn.TabIndex = 16;
            this.LogOutBtn.Text = "로그아웃";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ManagerMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.request_btn);
            this.Controls.Add(this.room_btn);
            this.Controls.Add(this.reserv_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManagerUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reserv_btn;
        private System.Windows.Forms.Button room_btn;
        private System.Windows.Forms.Button request_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutBtn;
    }
}


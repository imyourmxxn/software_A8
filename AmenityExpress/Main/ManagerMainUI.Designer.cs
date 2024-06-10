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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.reserv_btn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.money_btn = new System.Windows.Forms.Button();
            this.room_btn = new System.Windows.Forms.Button();
            this.request_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "리뷰관리";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 30);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "공지관리";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // reserv_btn
            // 
            this.reserv_btn.Location = new System.Drawing.Point(27, 121);
            this.reserv_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reserv_btn.Name = "reserv_btn";
            this.reserv_btn.Size = new System.Drawing.Size(96, 41);
            this.reserv_btn.TabIndex = 3;
            this.reserv_btn.Text = "예약관리";
            this.reserv_btn.UseVisualStyleBackColor = true;
            this.reserv_btn.Click += new System.EventHandler(this.reserv_btn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(197, 205);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 33);
            this.button8.TabIndex = 7;
            this.button8.Text = "카테고리관리";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(519, 8);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 19);
            this.button10.TabIndex = 9;
            this.button10.Text = "로그아웃";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 21);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "안녕하세요 홍길동님";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // money_btn
            // 
            this.money_btn.Location = new System.Drawing.Point(197, 121);
            this.money_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.money_btn.Name = "money_btn";
            this.money_btn.Size = new System.Drawing.Size(96, 41);
            this.money_btn.TabIndex = 11;
            this.money_btn.Text = "매출관리";
            this.money_btn.UseVisualStyleBackColor = true;
            this.money_btn.Click += new System.EventHandler(this.money_btn_Click);
            // 
            // room_btn
            // 
            this.room_btn.Location = new System.Drawing.Point(361, 121);
            this.room_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room_btn.Name = "room_btn";
            this.room_btn.Size = new System.Drawing.Size(96, 41);
            this.room_btn.TabIndex = 12;
            this.room_btn.Text = "객실관리";
            this.room_btn.UseVisualStyleBackColor = true;
            this.room_btn.Click += new System.EventHandler(this.room_btn_Click);
            // 
            // request_btn
            // 
            this.request_btn.Location = new System.Drawing.Point(27, 201);
            this.request_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.request_btn.Name = "request_btn";
            this.request_btn.Size = new System.Drawing.Size(96, 41);
            this.request_btn.TabIndex = 13;
            this.request_btn.Text = "요청사항관리";
            this.request_btn.UseVisualStyleBackColor = true;
            this.request_btn.Click += new System.EventHandler(this.request_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(27, 38);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(96, 41);
            this.login_btn.TabIndex = 14;
            this.login_btn.Text = "회원관리";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // ManagerMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.request_btn);
            this.Controls.Add(this.room_btn);
            this.Controls.Add(this.money_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.reserv_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManagerUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button reserv_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button money_btn;
        private System.Windows.Forms.Button room_btn;
        private System.Windows.Forms.Button request_btn;
        private System.Windows.Forms.Button login_btn;
    }
}


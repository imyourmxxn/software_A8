namespace AmenityExpress
{
    partial class SignUp
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.PW_lbl = new System.Windows.Forms.Label();
            this.PWC_lbl = new System.Windows.Forms.Label();
            this.Tel_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.PW_txt = new System.Windows.Forms.TextBox();
            this.PWC_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Tel_txt = new System.Windows.Forms.TextBox();
            this.doublecheck_btn = new System.Windows.Forms.Button();
            this.admin_check = new System.Windows.Forms.CheckBox();
            this.user_check = new System.Windows.Forms.CheckBox();
            this.SignUP_btn = new System.Windows.Forms.Button();
            this.sex_lbl = new System.Windows.Forms.Label();
            this.Birth_txt = new System.Windows.Forms.TextBox();
            this.birth_lbl = new System.Windows.Forms.Label();
            this.male_Rbtn = new System.Windows.Forms.RadioButton();
            this.female_Rbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(18, 50);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(29, 12);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "이름";
            this.name_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Location = new System.Drawing.Point(18, 93);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(41, 12);
            this.ID_lbl.TabIndex = 1;
            this.ID_lbl.Text = "아이디";
            this.ID_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // PW_lbl
            // 
            this.PW_lbl.AutoSize = true;
            this.PW_lbl.Location = new System.Drawing.Point(18, 132);
            this.PW_lbl.Name = "PW_lbl";
            this.PW_lbl.Size = new System.Drawing.Size(53, 12);
            this.PW_lbl.TabIndex = 2;
            this.PW_lbl.Text = "비밀번호";
            // 
            // PWC_lbl
            // 
            this.PWC_lbl.AutoSize = true;
            this.PWC_lbl.Location = new System.Drawing.Point(18, 166);
            this.PWC_lbl.Name = "PWC_lbl";
            this.PWC_lbl.Size = new System.Drawing.Size(81, 12);
            this.PWC_lbl.TabIndex = 3;
            this.PWC_lbl.Text = "비밀번호 확인";
            // 
            // Tel_lbl
            // 
            this.Tel_lbl.AutoSize = true;
            this.Tel_lbl.Location = new System.Drawing.Point(18, 237);
            this.Tel_lbl.Name = "Tel_lbl";
            this.Tel_lbl.Size = new System.Drawing.Size(53, 12);
            this.Tel_lbl.TabIndex = 4;
            this.Tel_lbl.Text = "전화번호";
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Location = new System.Drawing.Point(18, 203);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(41, 12);
            this.Email_lbl.TabIndex = 5;
            this.Email_lbl.Text = "이메일";
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(101, 41);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(141, 21);
            this.Name_txt.TabIndex = 6;
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(103, 84);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(141, 21);
            this.ID_txt.TabIndex = 7;
            // 
            // PW_txt
            // 
            this.PW_txt.Location = new System.Drawing.Point(103, 123);
            this.PW_txt.Name = "PW_txt";
            this.PW_txt.Size = new System.Drawing.Size(141, 21);
            this.PW_txt.TabIndex = 8;
            this.PW_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PWC_txt
            // 
            this.PWC_txt.Location = new System.Drawing.Point(103, 163);
            this.PWC_txt.Name = "PWC_txt";
            this.PWC_txt.Size = new System.Drawing.Size(139, 21);
            this.PWC_txt.TabIndex = 9;
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(103, 200);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(141, 21);
            this.Email_txt.TabIndex = 10;
            // 
            // Tel_txt
            // 
            this.Tel_txt.Location = new System.Drawing.Point(103, 234);
            this.Tel_txt.Name = "Tel_txt";
            this.Tel_txt.Size = new System.Drawing.Size(142, 21);
            this.Tel_txt.TabIndex = 11;
            this.Tel_txt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // doublecheck_btn
            // 
            this.doublecheck_btn.Location = new System.Drawing.Point(253, 83);
            this.doublecheck_btn.Name = "doublecheck_btn";
            this.doublecheck_btn.Size = new System.Drawing.Size(63, 20);
            this.doublecheck_btn.TabIndex = 12;
            this.doublecheck_btn.Text = "중복확인";
            this.doublecheck_btn.UseVisualStyleBackColor = true;
            this.doublecheck_btn.Click += new System.EventHandler(this.doublecheck_btn_Click);
            // 
            // admin_check
            // 
            this.admin_check.AutoSize = true;
            this.admin_check.Location = new System.Drawing.Point(37, 355);
            this.admin_check.Name = "admin_check";
            this.admin_check.Size = new System.Drawing.Size(60, 16);
            this.admin_check.TabIndex = 13;
            this.admin_check.Text = "관리자";
            this.admin_check.UseVisualStyleBackColor = true;
            // 
            // user_check
            // 
            this.user_check.AutoSize = true;
            this.user_check.Location = new System.Drawing.Point(156, 355);
            this.user_check.Name = "user_check";
            this.user_check.Size = new System.Drawing.Size(48, 16);
            this.user_check.TabIndex = 14;
            this.user_check.Text = "회원";
            this.user_check.UseVisualStyleBackColor = true;
            // 
            // SignUP_btn
            // 
            this.SignUP_btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SignUP_btn.Location = new System.Drawing.Point(20, 394);
            this.SignUP_btn.Name = "SignUP_btn";
            this.SignUP_btn.Size = new System.Drawing.Size(296, 31);
            this.SignUP_btn.TabIndex = 15;
            this.SignUP_btn.Text = "회원가입";
            this.SignUP_btn.UseVisualStyleBackColor = true;
            this.SignUP_btn.Click += new System.EventHandler(this.SignUP_btn_Click);
            // 
            // sex_lbl
            // 
            this.sex_lbl.AutoSize = true;
            this.sex_lbl.Location = new System.Drawing.Point(18, 273);
            this.sex_lbl.Name = "sex_lbl";
            this.sex_lbl.Size = new System.Drawing.Size(29, 12);
            this.sex_lbl.TabIndex = 16;
            this.sex_lbl.Text = "생일";
            // 
            // Birth_txt
            // 
            this.Birth_txt.Location = new System.Drawing.Point(100, 309);
            this.Birth_txt.Name = "Birth_txt";
            this.Birth_txt.Size = new System.Drawing.Size(142, 21);
            this.Birth_txt.TabIndex = 17;
            // 
            // birth_lbl
            // 
            this.birth_lbl.AutoSize = true;
            this.birth_lbl.Location = new System.Drawing.Point(18, 312);
            this.birth_lbl.Name = "birth_lbl";
            this.birth_lbl.Size = new System.Drawing.Size(53, 12);
            this.birth_lbl.TabIndex = 18;
            this.birth_lbl.Text = "생년월일";
            // 
            // male_Rbtn
            // 
            this.male_Rbtn.AutoSize = true;
            this.male_Rbtn.Location = new System.Drawing.Point(103, 271);
            this.male_Rbtn.Name = "male_Rbtn";
            this.male_Rbtn.Size = new System.Drawing.Size(35, 16);
            this.male_Rbtn.TabIndex = 19;
            this.male_Rbtn.TabStop = true;
            this.male_Rbtn.Text = "남";
            this.male_Rbtn.UseVisualStyleBackColor = true;
            // 
            // female_Rbtn
            // 
            this.female_Rbtn.AutoSize = true;
            this.female_Rbtn.Location = new System.Drawing.Point(169, 271);
            this.female_Rbtn.Name = "female_Rbtn";
            this.female_Rbtn.Size = new System.Drawing.Size(35, 16);
            this.female_Rbtn.TabIndex = 20;
            this.female_Rbtn.TabStop = true;
            this.female_Rbtn.Text = "여";
            this.female_Rbtn.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.female_Rbtn);
            this.Controls.Add(this.male_Rbtn);
            this.Controls.Add(this.birth_lbl);
            this.Controls.Add(this.Birth_txt);
            this.Controls.Add(this.sex_lbl);
            this.Controls.Add(this.SignUP_btn);
            this.Controls.Add(this.user_check);
            this.Controls.Add(this.admin_check);
            this.Controls.Add(this.doublecheck_btn);
            this.Controls.Add(this.Tel_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.PWC_txt);
            this.Controls.Add(this.PW_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.Tel_lbl);
            this.Controls.Add(this.PWC_lbl);
            this.Controls.Add(this.PW_lbl);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.name_lbl);
            this.Name = "SignUp";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label PW_lbl;
        private System.Windows.Forms.Label PWC_lbl;
        private System.Windows.Forms.Label Tel_lbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox PW_txt;
        private System.Windows.Forms.TextBox PWC_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Tel_txt;
        private System.Windows.Forms.Button doublecheck_btn;
        private System.Windows.Forms.CheckBox admin_check;
        private System.Windows.Forms.CheckBox user_check;
        private System.Windows.Forms.Button SignUP_btn;
        private System.Windows.Forms.Label sex_lbl;
        private System.Windows.Forms.TextBox Birth_txt;
        private System.Windows.Forms.Label birth_lbl;
        private System.Windows.Forms.RadioButton male_Rbtn;
        private System.Windows.Forms.RadioButton female_Rbtn;
    }
}
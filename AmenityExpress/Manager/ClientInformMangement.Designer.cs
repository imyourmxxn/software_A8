using System.Data;
using System.Windows.Forms;

namespace AmenityExpress
{
    partial class ClientInformMangement
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
            this.Profile_view = new System.Windows.Forms.DataGridView();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Fix_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.PW_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Tel_lbl = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.PW_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.tel_txt = new System.Windows.Forms.TextBox();
            this.sex_lbl = new System.Windows.Forms.Label();
            this.birth_lbl = new System.Windows.Forms.Label();
            this.birth_txt = new System.Windows.Forms.TextBox();
            this.male_RBtn = new System.Windows.Forms.RadioButton();
            this.female_Rbtn = new System.Windows.Forms.RadioButton();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_view)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Profile_view
            // 
            this.Profile_view.AllowUserToOrderColumns = true;
            this.Profile_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Profile_view.Location = new System.Drawing.Point(12, 76);
            this.Profile_view.Name = "Profile_view";
            this.Profile_view.RowTemplate.Height = 23;
            this.Profile_view.Size = new System.Drawing.Size(344, 422);
            this.Profile_view.TabIndex = 0;
            this.Profile_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Profile_view_CellContentClick);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(474, 319);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(121, 35);
            this.Add_btn.TabIndex = 1;
            this.Add_btn.Text = "추가";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fix_btn
            // 
            this.Fix_btn.Location = new System.Drawing.Point(474, 395);
            this.Fix_btn.Name = "Fix_btn";
            this.Fix_btn.Size = new System.Drawing.Size(121, 35);
            this.Fix_btn.TabIndex = 2;
            this.Fix_btn.Text = "수정";
            this.Fix_btn.UseVisualStyleBackColor = true;
            this.Fix_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.Location = new System.Drawing.Point(474, 463);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(121, 35);
            this.Del_btn.TabIndex = 3;
            this.Del_btn.Text = "삭제";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_lbl.Location = new System.Drawing.Point(368, 32);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(31, 12);
            this.name_lbl.TabIndex = 4;
            this.name_lbl.Text = "이름";
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID_lbl.Location = new System.Drawing.Point(368, 79);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(44, 12);
            this.ID_lbl.TabIndex = 5;
            this.ID_lbl.Text = "아이디";
            // 
            // PW_lbl
            // 
            this.PW_lbl.AutoSize = true;
            this.PW_lbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PW_lbl.Location = new System.Drawing.Point(368, 121);
            this.PW_lbl.Name = "PW_lbl";
            this.PW_lbl.Size = new System.Drawing.Size(57, 12);
            this.PW_lbl.TabIndex = 6;
            this.PW_lbl.Text = "비밀번호";
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Email_lbl.Location = new System.Drawing.Point(368, 155);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(44, 12);
            this.Email_lbl.TabIndex = 7;
            this.Email_lbl.Text = "이메일";
            // 
            // Tel_lbl
            // 
            this.Tel_lbl.AutoSize = true;
            this.Tel_lbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Tel_lbl.Location = new System.Drawing.Point(368, 191);
            this.Tel_lbl.Name = "Tel_lbl";
            this.Tel_lbl.Size = new System.Drawing.Size(57, 12);
            this.Tel_lbl.TabIndex = 8;
            this.Tel_lbl.Text = "전화번호";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(456, 29);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(201, 21);
            this.name_txt.TabIndex = 9;
            // 
            // PW_txt
            // 
            this.PW_txt.Location = new System.Drawing.Point(456, 118);
            this.PW_txt.Name = "PW_txt";
            this.PW_txt.Size = new System.Drawing.Size(201, 21);
            this.PW_txt.TabIndex = 11;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(456, 152);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(201, 21);
            this.email_txt.TabIndex = 12;
            // 
            // tel_txt
            // 
            this.tel_txt.Location = new System.Drawing.Point(456, 188);
            this.tel_txt.Name = "tel_txt";
            this.tel_txt.Size = new System.Drawing.Size(201, 21);
            this.tel_txt.TabIndex = 13;
            // 
            // sex_lbl
            // 
            this.sex_lbl.AutoSize = true;
            this.sex_lbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sex_lbl.Location = new System.Drawing.Point(368, 229);
            this.sex_lbl.Name = "sex_lbl";
            this.sex_lbl.Size = new System.Drawing.Size(31, 12);
            this.sex_lbl.TabIndex = 14;
            this.sex_lbl.Text = "성별";
            // 
            // birth_lbl
            // 
            this.birth_lbl.AutoSize = true;
            this.birth_lbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.birth_lbl.Location = new System.Drawing.Point(368, 266);
            this.birth_lbl.Name = "birth_lbl";
            this.birth_lbl.Size = new System.Drawing.Size(57, 12);
            this.birth_lbl.TabIndex = 15;
            this.birth_lbl.Text = "생년월일";
            // 
            // birth_txt
            // 
            this.birth_txt.Location = new System.Drawing.Point(456, 263);
            this.birth_txt.Name = "birth_txt";
            this.birth_txt.Size = new System.Drawing.Size(201, 21);
            this.birth_txt.TabIndex = 16;
            // 
            // male_RBtn
            // 
            this.male_RBtn.AutoSize = true;
            this.male_RBtn.Location = new System.Drawing.Point(6, 7);
            this.male_RBtn.Name = "male_RBtn";
            this.male_RBtn.Size = new System.Drawing.Size(35, 16);
            this.male_RBtn.TabIndex = 17;
            this.male_RBtn.TabStop = true;
            this.male_RBtn.Text = "남";
            this.male_RBtn.UseVisualStyleBackColor = true;
            // 
            // female_Rbtn
            // 
            this.female_Rbtn.AutoSize = true;
            this.female_Rbtn.Location = new System.Drawing.Point(68, 7);
            this.female_Rbtn.Name = "female_Rbtn";
            this.female_Rbtn.Size = new System.Drawing.Size(35, 16);
            this.female_Rbtn.TabIndex = 18;
            this.female_Rbtn.TabStop = true;
            this.female_Rbtn.Text = "여";
            this.female_Rbtn.UseVisualStyleBackColor = true;
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(456, 76);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(201, 21);
            this.ID_txt.TabIndex = 10;
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(12, 33);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(212, 21);
            this.Search_txt.TabIndex = 20;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(245, 33);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(95, 21);
            this.Search_btn.TabIndex = 21;
            this.Search_btn.Text = "검색";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.male_RBtn);
            this.groupBox.Controls.Add(this.female_Rbtn);
            this.groupBox.Location = new System.Drawing.Point(456, 218);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(127, 23);
            this.groupBox.TabIndex = 22;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 524);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.birth_txt);
            this.Controls.Add(this.birth_lbl);
            this.Controls.Add(this.sex_lbl);
            this.Controls.Add(this.tel_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.PW_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.Tel_lbl);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.PW_lbl);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.Fix_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Profile_view);
            this.Name = "Member";
            this.Text = "회원관리 ";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Profile_view)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Profile_view;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Fix_btn;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label PW_lbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.Label Tel_lbl;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox PW_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox tel_txt;
        private System.Windows.Forms.Label sex_lbl;
        private System.Windows.Forms.Label birth_lbl;
        private System.Windows.Forms.TextBox birth_txt;
        private System.Windows.Forms.RadioButton male_RBtn;
        private System.Windows.Forms.RadioButton female_Rbtn;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Button Search_btn;
        private GroupBox groupBox;
    }
}
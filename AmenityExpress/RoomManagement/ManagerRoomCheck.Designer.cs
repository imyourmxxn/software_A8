
namespace AmenityExpress
{
    partial class ManagerRoomCheck
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 353);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 68;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(-23, 407);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 67;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(-23, 291);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 66;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(-23, 187);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 65;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-23, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 64;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(66, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 59);
            this.addButton.TabIndex = 69;
            this.addButton.Text = "신규 정보 등록";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(391, 12);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(104, 59);
            this.updateBtn.TabIndex = 70;
            this.updateBtn.Text = "객실 정보 수정";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(718, 12);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(104, 59);
            this.delBtn.TabIndex = 71;
            this.delBtn.Text = "객실 정보 삭제";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(12, 450);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(48, 38);
            this.Cancel_Btn.TabIndex = 73;
            this.Cancel_Btn.Text = "취소";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // ManagerRoomCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "ManagerRoomCheck";
            this.Text = "ManagerRoomCheck";
            this.Load += new System.EventHandler(this.RoomSearchM_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Cancel_Btn;
    }
}
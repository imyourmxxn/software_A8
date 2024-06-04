namespace AmenityExpress
{
    partial class RoomCheck
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
            this.Room_list = new System.Windows.Forms.ListView();
            this.Reserve_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Room_list
            // 
            this.Room_list.HideSelection = false;
            this.Room_list.Location = new System.Drawing.Point(38, 29);
            this.Room_list.Name = "Room_list";
            this.Room_list.Size = new System.Drawing.Size(662, 419);
            this.Room_list.TabIndex = 0;
            this.Room_list.UseCompatibleStateImageBehavior = false;
            this.Room_list.SelectedIndexChanged += new System.EventHandler(this.Room_list_SelectedIndexChanged);
            // 
            // Reserve_btn
            // 
            this.Reserve_btn.Location = new System.Drawing.Point(724, 60);
            this.Reserve_btn.Name = "Reserve_btn";
            this.Reserve_btn.Size = new System.Drawing.Size(105, 54);
            this.Reserve_btn.TabIndex = 1;
            this.Reserve_btn.Text = "예약";
            this.Reserve_btn.UseVisualStyleBackColor = true;
            this.Reserve_btn.Click += new System.EventHandler(this.Reserve_btn_Click);
            // 
            // RoomCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 477);
            this.Controls.Add(this.Reserve_btn);
            this.Controls.Add(this.Room_list);
            this.Name = "RoomCheck";
            this.Text = "RoomCheck";
            this.Load += new System.EventHandler(this.RoomCheck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Room_list;
        private System.Windows.Forms.Button Reserve_btn;
    }
}
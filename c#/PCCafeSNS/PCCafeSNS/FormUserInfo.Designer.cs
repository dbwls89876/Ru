namespace PCCafeSNS
{
    partial class FormUserInfo
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
            this.buttonUserUpdate = new System.Windows.Forms.Button();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFollow = new System.Windows.Forms.ListBox();
            this.listBoxUnFollow = new System.Windows.Forms.ListBox();
            this.buttonUnFollow = new System.Windows.Forms.Button();
            this.listBoxUserFollow = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUserUpdate
            // 
            this.buttonUserUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUserUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserUpdate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonUserUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUserUpdate.Location = new System.Drawing.Point(124, 35);
            this.buttonUserUpdate.Name = "buttonUserUpdate";
            this.buttonUserUpdate.Size = new System.Drawing.Size(102, 41);
            this.buttonUserUpdate.TabIndex = 0;
            this.buttonUserUpdate.Text = "내정보 변경";
            this.buttonUserUpdate.UseVisualStyleBackColor = false;
            this.buttonUserUpdate.Click += new System.EventHandler(this.buttonUserUpdate_Click);
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Location = new System.Drawing.Point(11, 35);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxUserImage.TabIndex = 2;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "나를 팔로우한 사람";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "나를 언팔로우한 사람";
            // 
            // listBoxFollow
            // 
            this.listBoxFollow.FormattingEnabled = true;
            this.listBoxFollow.ItemHeight = 12;
            this.listBoxFollow.Location = new System.Drawing.Point(11, 139);
            this.listBoxFollow.Name = "listBoxFollow";
            this.listBoxFollow.Size = new System.Drawing.Size(213, 88);
            this.listBoxFollow.TabIndex = 5;
            // 
            // listBoxUnFollow
            // 
            this.listBoxUnFollow.FormattingEnabled = true;
            this.listBoxUnFollow.ItemHeight = 12;
            this.listBoxUnFollow.Location = new System.Drawing.Point(9, 257);
            this.listBoxUnFollow.Name = "listBoxUnFollow";
            this.listBoxUnFollow.Size = new System.Drawing.Size(215, 88);
            this.listBoxUnFollow.TabIndex = 6;
            // 
            // buttonUnFollow
            // 
            this.buttonUnFollow.Location = new System.Drawing.Point(151, 469);
            this.buttonUnFollow.Name = "buttonUnFollow";
            this.buttonUnFollow.Size = new System.Drawing.Size(75, 23);
            this.buttonUnFollow.TabIndex = 7;
            this.buttonUnFollow.Text = "UnFollow";
            this.buttonUnFollow.UseVisualStyleBackColor = true;
            this.buttonUnFollow.Click += new System.EventHandler(this.buttonUnFollow_Click);
            // 
            // listBoxUserFollow
            // 
            this.listBoxUserFollow.FormattingEnabled = true;
            this.listBoxUserFollow.ItemHeight = 12;
            this.listBoxUserFollow.Location = new System.Drawing.Point(9, 375);
            this.listBoxUserFollow.Name = "listBoxUserFollow";
            this.listBoxUserFollow.Size = new System.Drawing.Size(215, 88);
            this.listBoxUserFollow.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "내가 팔로우한 사람";
            // 
            // FormUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxUserFollow);
            this.Controls.Add(this.buttonUnFollow);
            this.Controls.Add(this.listBoxUnFollow);
            this.Controls.Add(this.listBoxFollow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Controls.Add(this.buttonUserUpdate);
            this.Name = "FormUserInfo";
            this.Load += new System.EventHandler(this.FormUserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUserUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxFollow;
        private System.Windows.Forms.ListBox listBoxUnFollow;
        private System.Windows.Forms.Button buttonUnFollow;
        public System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.ListBox listBoxUserFollow;
        private System.Windows.Forms.Label label3;
    }
}
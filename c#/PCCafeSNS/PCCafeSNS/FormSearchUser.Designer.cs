namespace PCCafeSNS
{
    partial class FormSearchUser
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
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.buttonFollow = new System.Windows.Forms.Button();
            this.labelUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(12, 25);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(227, 21);
            this.textBoxUserID.TabIndex = 0;
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearchUser.FlatAppearance.BorderSize = 0;
            this.buttonSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearchUser.ForeColor = System.Drawing.Color.White;
            this.buttonSearchUser.Location = new System.Drawing.Point(245, 24);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(75, 21);
            this.buttonSearchUser.TabIndex = 3;
            this.buttonSearchUser.Text = "유저 검색";
            this.buttonSearchUser.UseVisualStyleBackColor = false;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // buttonFollow
            // 
            this.buttonFollow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonFollow.FlatAppearance.BorderSize = 0;
            this.buttonFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFollow.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonFollow.ForeColor = System.Drawing.Color.White;
            this.buttonFollow.Location = new System.Drawing.Point(245, 68);
            this.buttonFollow.Name = "buttonFollow";
            this.buttonFollow.Size = new System.Drawing.Size(75, 23);
            this.buttonFollow.TabIndex = 4;
            this.buttonFollow.UseVisualStyleBackColor = false;
            this.buttonFollow.Click += new System.EventHandler(this.buttonFollow_Click);
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(13, 78);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(0, 12);
            this.labelUserID.TabIndex = 5;
            // 
            // FormSearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 169);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.buttonFollow);
            this.Controls.Add(this.buttonSearchUser);
            this.Controls.Add(this.textBoxUserID);
            this.Name = "FormSearchUser";
            this.Text = "FormSearchUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.Button buttonFollow;
        private System.Windows.Forms.Label labelUserID;
    }
}
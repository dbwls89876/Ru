namespace PCCafeSNS
{
    partial class FormUserUpdate
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonUserUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.buttonImageLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "Region";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(79, 226);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(100, 21);
            this.textBoxRegion.TabIndex = 25;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(79, 199);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 21);
            this.textBoxEmail.TabIndex = 24;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(79, 169);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxPassword.TabIndex = 23;
            // 
            // buttonUserUpdate
            // 
            this.buttonUserUpdate.Location = new System.Drawing.Point(70, 268);
            this.buttonUserUpdate.Name = "buttonUserUpdate";
            this.buttonUserUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUserUpdate.TabIndex = 21;
            this.buttonUserUpdate.Text = "정보변경";
            this.buttonUserUpdate.UseVisualStyleBackColor = true;
            this.buttonUserUpdate.Click += new System.EventHandler(this.buttonUserUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "PW";
            // 
            // textBoxPasswordCheck
            // 
            this.textBoxPasswordCheck.Location = new System.Drawing.Point(79, 142);
            this.textBoxPasswordCheck.Name = "textBoxPasswordCheck";
            this.textBoxPasswordCheck.Size = new System.Drawing.Size(100, 21);
            this.textBoxPasswordCheck.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "PWCheck";
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Location = new System.Drawing.Point(70, 12);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxUserImage.TabIndex = 30;
            this.pictureBoxUserImage.TabStop = false;
            this.pictureBoxUserImage.Click += new System.EventHandler(this.pictureBoxUserImage_Click);
            // 
            // buttonImageLoad
            // 
            this.buttonImageLoad.Location = new System.Drawing.Point(70, 93);
            this.buttonImageLoad.Name = "buttonImageLoad";
            this.buttonImageLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonImageLoad.TabIndex = 31;
            this.buttonImageLoad.Text = "이미지";
            this.buttonImageLoad.UseVisualStyleBackColor = true;
            this.buttonImageLoad.Click += new System.EventHandler(this.buttonImageLoad_Click);
            // 
            // FormUserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 357);
            this.Controls.Add(this.buttonImageLoad);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPasswordCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRegion);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonUserUpdate);
            this.Controls.Add(this.label2);
            this.Name = "FormUserUpdate";
            this.Text = "FormUserUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonUserUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPasswordCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.Button buttonImageLoad;
    }
}
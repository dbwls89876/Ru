namespace PCCafeSNS
{
    partial class FormGroupmanagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGroupmessageall = new System.Windows.Forms.Button();
            this.buttonGroupdelete = new System.Windows.Forms.Button();
            this.buttonGroupmanagersecession = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMygroupname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "그룹관리 페이지";
            // 
            // buttonGroupmessageall
            // 
            this.buttonGroupmessageall.AutoSize = true;
            this.buttonGroupmessageall.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGroupmessageall.FlatAppearance.BorderSize = 0;
            this.buttonGroupmessageall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupmessageall.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGroupmessageall.ForeColor = System.Drawing.Color.White;
            this.buttonGroupmessageall.Location = new System.Drawing.Point(56, 179);
            this.buttonGroupmessageall.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGroupmessageall.Name = "buttonGroupmessageall";
            this.buttonGroupmessageall.Size = new System.Drawing.Size(150, 27);
            this.buttonGroupmessageall.TabIndex = 1;
            this.buttonGroupmessageall.Text = "그룹단체메시지";
            this.buttonGroupmessageall.UseVisualStyleBackColor = false;
            this.buttonGroupmessageall.Click += new System.EventHandler(this.buttonGroupmessageall_Click);
            // 
            // buttonGroupdelete
            // 
            this.buttonGroupdelete.AutoSize = true;
            this.buttonGroupdelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGroupdelete.FlatAppearance.BorderSize = 0;
            this.buttonGroupdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupdelete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGroupdelete.ForeColor = System.Drawing.Color.White;
            this.buttonGroupdelete.Location = new System.Drawing.Point(56, 230);
            this.buttonGroupdelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGroupdelete.Name = "buttonGroupdelete";
            this.buttonGroupdelete.Size = new System.Drawing.Size(150, 27);
            this.buttonGroupdelete.TabIndex = 2;
            this.buttonGroupdelete.Text = "그룹삭제";
            this.buttonGroupdelete.UseVisualStyleBackColor = false;
            this.buttonGroupdelete.Click += new System.EventHandler(this.buttonGroupdelete_Click);
            // 
            // buttonGroupmanagersecession
            // 
            this.buttonGroupmanagersecession.AutoSize = true;
            this.buttonGroupmanagersecession.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGroupmanagersecession.FlatAppearance.BorderSize = 0;
            this.buttonGroupmanagersecession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupmanagersecession.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGroupmanagersecession.ForeColor = System.Drawing.Color.White;
            this.buttonGroupmanagersecession.Location = new System.Drawing.Point(56, 288);
            this.buttonGroupmanagersecession.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGroupmanagersecession.Name = "buttonGroupmanagersecession";
            this.buttonGroupmanagersecession.Size = new System.Drawing.Size(150, 27);
            this.buttonGroupmanagersecession.TabIndex = 3;
            this.buttonGroupmanagersecession.Text = "그룹매니저탈퇴";
            this.buttonGroupmanagersecession.UseVisualStyleBackColor = false;
            this.buttonGroupmanagersecession.Click += new System.EventHandler(this.buttonGroupmanagersecession_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "그룹명";
            // 
            // textBoxMygroupname
            // 
            this.textBoxMygroupname.Location = new System.Drawing.Point(56, 126);
            this.textBoxMygroupname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMygroupname.Name = "textBoxMygroupname";
            this.textBoxMygroupname.Size = new System.Drawing.Size(152, 21);
            this.textBoxMygroupname.TabIndex = 5;
            // 
            // FormGroupmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 358);
            this.Controls.Add(this.textBoxMygroupname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGroupmanagersecession);
            this.Controls.Add(this.buttonGroupdelete);
            this.Controls.Add(this.buttonGroupmessageall);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGroupmanagement";
            this.Padding = new System.Windows.Forms.Padding(14, 60, 14, 13);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGroupmessageall;
        private System.Windows.Forms.Button buttonGroupdelete;
        private System.Windows.Forms.Button buttonGroupmanagersecession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMygroupname;
    }
}
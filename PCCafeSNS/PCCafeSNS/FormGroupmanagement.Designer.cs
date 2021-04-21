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
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "그룹관리 페이지";
            // 
            // buttonGroupmessageall
            // 
            this.buttonGroupmessageall.AutoSize = true;
            this.buttonGroupmessageall.Font = new System.Drawing.Font("굴림", 9F);
            this.buttonGroupmessageall.Location = new System.Drawing.Point(68, 225);
            this.buttonGroupmessageall.Name = "buttonGroupmessageall";
            this.buttonGroupmessageall.Size = new System.Drawing.Size(215, 40);
            this.buttonGroupmessageall.TabIndex = 1;
            this.buttonGroupmessageall.Text = "그룹단체메시지";
            this.buttonGroupmessageall.UseVisualStyleBackColor = true;
            this.buttonGroupmessageall.Click += new System.EventHandler(this.buttonGroupmessageall_Click);
            // 
            // buttonGroupdelete
            // 
            this.buttonGroupdelete.AutoSize = true;
            this.buttonGroupdelete.Font = new System.Drawing.Font("굴림", 9F);
            this.buttonGroupdelete.Location = new System.Drawing.Point(68, 302);
            this.buttonGroupdelete.Name = "buttonGroupdelete";
            this.buttonGroupdelete.Size = new System.Drawing.Size(215, 40);
            this.buttonGroupdelete.TabIndex = 2;
            this.buttonGroupdelete.Text = "그룹삭제";
            this.buttonGroupdelete.UseVisualStyleBackColor = true;
            this.buttonGroupdelete.Click += new System.EventHandler(this.buttonGroupdelete_Click);
            // 
            // buttonGroupmanagersecession
            // 
            this.buttonGroupmanagersecession.AutoSize = true;
            this.buttonGroupmanagersecession.Font = new System.Drawing.Font("굴림", 9F);
            this.buttonGroupmanagersecession.Location = new System.Drawing.Point(68, 388);
            this.buttonGroupmanagersecession.Name = "buttonGroupmanagersecession";
            this.buttonGroupmanagersecession.Size = new System.Drawing.Size(215, 40);
            this.buttonGroupmanagersecession.TabIndex = 3;
            this.buttonGroupmanagersecession.Text = "그룹매니저탈퇴";
            this.buttonGroupmanagersecession.UseVisualStyleBackColor = true;
            this.buttonGroupmanagersecession.Click += new System.EventHandler(this.buttonGroupmanagersecession_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "그룹명";
            // 
            // textBoxMygroupname
            // 
            this.textBoxMygroupname.Location = new System.Drawing.Point(68, 145);
            this.textBoxMygroupname.Name = "textBoxMygroupname";
            this.textBoxMygroupname.Size = new System.Drawing.Size(215, 28);
            this.textBoxMygroupname.TabIndex = 5;
            // 
            // FormGroupmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 537);
            this.Controls.Add(this.textBoxMygroupname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGroupmanagersecession);
            this.Controls.Add(this.buttonGroupdelete);
            this.Controls.Add(this.buttonGroupmessageall);
            this.Controls.Add(this.label1);
            this.Name = "FormGroupmanagement";
            this.Text = "FormGroupmanagement";
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
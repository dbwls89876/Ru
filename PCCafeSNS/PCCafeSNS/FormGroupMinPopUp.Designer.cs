namespace PCCafeSNS
{
    partial class FormGroupMinPopUp
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonMemberShipLevel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMebershipLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원아이디";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(252, 69);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(180, 28);
            this.textBoxUserName.TabIndex = 1;
            // 
            // buttonMemberShipLevel
            // 
            this.buttonMemberShipLevel.Location = new System.Drawing.Point(94, 472);
            this.buttonMemberShipLevel.Name = "buttonMemberShipLevel";
            this.buttonMemberShipLevel.Size = new System.Drawing.Size(359, 47);
            this.buttonMemberShipLevel.TabIndex = 2;
            this.buttonMemberShipLevel.Text = "등급 조절하기";
            this.buttonMemberShipLevel.UseVisualStyleBackColor = true;
            this.buttonMemberShipLevel.Click += new System.EventHandler(this.buttonMemberShipLevel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "회원등급";
            // 
            // textBoxMebershipLevel
            // 
            this.textBoxMebershipLevel.Location = new System.Drawing.Point(252, 178);
            this.textBoxMebershipLevel.Name = "textBoxMebershipLevel";
            this.textBoxMebershipLevel.Size = new System.Drawing.Size(180, 28);
            this.textBoxMebershipLevel.TabIndex = 4;
            // 
            // FormGroupMinPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 681);
            this.Controls.Add(this.textBoxMebershipLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMemberShipLevel);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label1);
            this.Name = "FormGroupMinPopUp";
            this.Text = "FormGroupMinPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonMemberShipLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMebershipLevel;
    }
}
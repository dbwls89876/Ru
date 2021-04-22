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
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원아이디";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(130, 86);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(127, 21);
            this.textBoxUserName.TabIndex = 1;
            // 
            // buttonMemberShipLevel
            // 
            this.buttonMemberShipLevel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonMemberShipLevel.FlatAppearance.BorderSize = 0;
            this.buttonMemberShipLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMemberShipLevel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonMemberShipLevel.ForeColor = System.Drawing.Color.White;
            this.buttonMemberShipLevel.Location = new System.Drawing.Point(54, 226);
            this.buttonMemberShipLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMemberShipLevel.Name = "buttonMemberShipLevel";
            this.buttonMemberShipLevel.Size = new System.Drawing.Size(251, 31);
            this.buttonMemberShipLevel.TabIndex = 2;
            this.buttonMemberShipLevel.Text = "등급 조절하기";
            this.buttonMemberShipLevel.UseVisualStyleBackColor = false;
            this.buttonMemberShipLevel.Click += new System.EventHandler(this.buttonMemberShipLevel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "회원등급";
            // 
            // textBoxMebershipLevel
            // 
            this.textBoxMebershipLevel.Location = new System.Drawing.Point(130, 159);
            this.textBoxMebershipLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMebershipLevel.Name = "textBoxMebershipLevel";
            this.textBoxMebershipLevel.Size = new System.Drawing.Size(127, 21);
            this.textBoxMebershipLevel.TabIndex = 4;
            // 
            // FormGroupMinPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 294);
            this.Controls.Add(this.textBoxMebershipLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMemberShipLevel);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGroupMinPopUp";
            this.Padding = new System.Windows.Forms.Padding(14, 40, 14, 13);
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
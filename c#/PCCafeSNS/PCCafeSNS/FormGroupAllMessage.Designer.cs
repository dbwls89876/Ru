namespace PCCafeSNS
{
    partial class FormGroupAllMessage
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
            this.buttonSendGroupMessage = new System.Windows.Forms.Button();
            this.textBoxGroupMessageContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "모든 그룹원들에게 메시지";
            // 
            // buttonSendGroupMessage
            // 
            this.buttonSendGroupMessage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSendGroupMessage.FlatAppearance.BorderSize = 0;
            this.buttonSendGroupMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendGroupMessage.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.buttonSendGroupMessage.ForeColor = System.Drawing.Color.White;
            this.buttonSendGroupMessage.Location = new System.Drawing.Point(433, 77);
            this.buttonSendGroupMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSendGroupMessage.Name = "buttonSendGroupMessage";
            this.buttonSendGroupMessage.Size = new System.Drawing.Size(87, 174);
            this.buttonSendGroupMessage.TabIndex = 1;
            this.buttonSendGroupMessage.Text = "전송";
            this.buttonSendGroupMessage.UseVisualStyleBackColor = false;
            this.buttonSendGroupMessage.Click += new System.EventHandler(this.buttonSendGroupMessage_Click);
            // 
            // textBoxGroupMessageContent
            // 
            this.textBoxGroupMessageContent.Location = new System.Drawing.Point(58, 77);
            this.textBoxGroupMessageContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGroupMessageContent.Multiline = true;
            this.textBoxGroupMessageContent.Name = "textBoxGroupMessageContent";
            this.textBoxGroupMessageContent.Size = new System.Drawing.Size(346, 175);
            this.textBoxGroupMessageContent.TabIndex = 2;
            // 
            // FormGroupAllMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 324);
            this.Controls.Add(this.textBoxGroupMessageContent);
            this.Controls.Add(this.buttonSendGroupMessage);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGroupAllMessage";
            this.Padding = new System.Windows.Forms.Padding(14, 40, 14, 13);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSendGroupMessage;
        private System.Windows.Forms.TextBox textBoxGroupMessageContent;
    }
}
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
            this.label1.Location = new System.Drawing.Point(139, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "모든 그룹원들에게 메시지";
            // 
            // buttonSendGroupMessage
            // 
            this.buttonSendGroupMessage.Font = new System.Drawing.Font("굴림", 13F);
            this.buttonSendGroupMessage.Location = new System.Drawing.Point(619, 115);
            this.buttonSendGroupMessage.Name = "buttonSendGroupMessage";
            this.buttonSendGroupMessage.Size = new System.Drawing.Size(124, 261);
            this.buttonSendGroupMessage.TabIndex = 1;
            this.buttonSendGroupMessage.Text = "전송";
            this.buttonSendGroupMessage.UseVisualStyleBackColor = true;
            this.buttonSendGroupMessage.Click += new System.EventHandler(this.buttonSendGroupMessage_Click);
            // 
            // textBoxGroupMessageContent
            // 
            this.textBoxGroupMessageContent.Location = new System.Drawing.Point(83, 115);
            this.textBoxGroupMessageContent.Multiline = true;
            this.textBoxGroupMessageContent.Name = "textBoxGroupMessageContent";
            this.textBoxGroupMessageContent.Size = new System.Drawing.Size(493, 261);
            this.textBoxGroupMessageContent.TabIndex = 2;
            // 
            // FormGroupAllMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 486);
            this.Controls.Add(this.textBoxGroupMessageContent);
            this.Controls.Add(this.buttonSendGroupMessage);
            this.Controls.Add(this.label1);
            this.Name = "FormGroupAllMessage";
            this.Text = "FormGroupAllMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSendGroupMessage;
        private System.Windows.Forms.TextBox textBoxGroupMessageContent;
    }
}
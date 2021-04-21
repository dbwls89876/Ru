namespace PCCafeSNS
{
    partial class FormWriteBoard
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonAttachPicture = new System.Windows.Forms.Button();
            this.pictureAttach = new System.Windows.Forms.PictureBox();
            this.richTextBoxContents = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAttach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "내용";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(91, 45);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(469, 21);
            this.textBoxTitle.TabIndex = 2;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(485, 375);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "작성";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonAttachPicture
            // 
            this.buttonAttachPicture.Location = new System.Drawing.Point(137, 366);
            this.buttonAttachPicture.Name = "buttonAttachPicture";
            this.buttonAttachPicture.Size = new System.Drawing.Size(75, 23);
            this.buttonAttachPicture.TabIndex = 5;
            this.buttonAttachPicture.Text = "사진 첨부";
            this.buttonAttachPicture.UseVisualStyleBackColor = true;
            this.buttonAttachPicture.Click += new System.EventHandler(this.buttonAttachPicture_Click);
            // 
            // pictureAttach
            // 
            this.pictureAttach.Location = new System.Drawing.Point(91, 366);
            this.pictureAttach.Name = "pictureAttach";
            this.pictureAttach.Size = new System.Drawing.Size(40, 32);
            this.pictureAttach.TabIndex = 6;
            this.pictureAttach.TabStop = false;
            this.pictureAttach.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBoxContents
            // 
            this.richTextBoxContents.Location = new System.Drawing.Point(94, 111);
            this.richTextBoxContents.Name = "richTextBoxContents";
            this.richTextBoxContents.Size = new System.Drawing.Size(466, 249);
            this.richTextBoxContents.TabIndex = 7;
            this.richTextBoxContents.Text = "";
            // 
            // FormWriteBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.richTextBoxContents);
            this.Controls.Add(this.pictureAttach);
            this.Controls.Add(this.buttonAttachPicture);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormWriteBoard";
            this.Text = "FormWriteBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWriteBoard_FormClosing);
            this.Load += new System.EventHandler(this.FormWriteBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAttach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonAttachPicture;
        private System.Windows.Forms.PictureBox pictureAttach;
        private System.Windows.Forms.RichTextBox richTextBoxContents;
    }
}
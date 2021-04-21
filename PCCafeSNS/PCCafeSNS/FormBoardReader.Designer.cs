namespace PCCafeSNS
{
    partial class FormBoardReader
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxContents = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWriter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWrittenDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWriter = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "제목";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(58, 22);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(273, 21);
            this.textBoxTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "내용";
            // 
            // richTextBoxContents
            // 
            this.richTextBoxContents.Location = new System.Drawing.Point(345, 49);
            this.richTextBoxContents.Name = "richTextBoxContents";
            this.richTextBoxContents.ReadOnly = true;
            this.richTextBoxContents.Size = new System.Drawing.Size(273, 267);
            this.richTextBoxContents.TabIndex = 4;
            this.richTextBoxContents.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(58, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 266);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnWriter,
            this.columnContents,
            this.columnWrittenDate});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 341);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 91);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "No.";
            // 
            // columnWriter
            // 
            this.columnWriter.Text = "작성자";
            // 
            // columnContents
            // 
            this.columnContents.Text = "댓글";
            this.columnContents.Width = 325;
            // 
            // columnWrittenDate
            // 
            this.columnWrittenDate.Text = "날짜";
            this.columnWrittenDate.Width = 161;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 438);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "댓글 등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(624, 341);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(62, 23);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "새로고침";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "작성자";
            // 
            // textBoxWriter
            // 
            this.textBoxWriter.Location = new System.Drawing.Point(391, 22);
            this.textBoxWriter.Name = "textBoxWriter";
            this.textBoxWriter.ReadOnly = true;
            this.textBoxWriter.Size = new System.Drawing.Size(227, 21);
            this.textBoxWriter.TabIndex = 11;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(625, 19);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(61, 23);
            this.buttonModify.TabIndex = 12;
            this.buttonModify.Text = "수정";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Visible = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // FormBoardReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 521);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textBoxWriter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxContents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Name = "FormBoardReader";
            this.Text = "FormBoardReader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBoardReader_FormClosing);
            this.Load += new System.EventHandler(this.FormBoardReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxContents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnWriter;
        private System.Windows.Forms.ColumnHeader columnContents;
        private System.Windows.Forms.ColumnHeader columnWrittenDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWriter;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.ColumnHeader columnNumber;
    }
}
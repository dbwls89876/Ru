namespace PCCafeSNS
{
    partial class FormBoard
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
            this.txtSearchContents = new System.Windows.Forms.TextBox();
            this.listViewPost = new System.Windows.Forms.ListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWriter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxFollower = new System.Windows.Forms.CheckBox();
            this.buttonWriteBoard = new System.Windows.Forms.Button();
            this.comboBoxKeyword = new System.Windows.Forms.ComboBox();
            this.checkBoxMine = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSearchContents
            // 
            this.txtSearchContents.Location = new System.Drawing.Point(183, 22);
            this.txtSearchContents.Name = "txtSearchContents";
            this.txtSearchContents.Size = new System.Drawing.Size(450, 21);
            this.txtSearchContents.TabIndex = 1;
            // 
            // listViewPost
            // 
            this.listViewPost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnTitle,
            this.columnWriter,
            this.columnHits,
            this.columnDate});
            this.listViewPost.FullRowSelect = true;
            this.listViewPost.HideSelection = false;
            this.listViewPost.Location = new System.Drawing.Point(56, 94);
            this.listViewPost.Name = "listViewPost";
            this.listViewPost.Size = new System.Drawing.Size(669, 293);
            this.listViewPost.TabIndex = 5;
            this.listViewPost.UseCompatibleStateImageBehavior = false;
            this.listViewPost.View = System.Windows.Forms.View.Details;
            this.listViewPost.SelectedIndexChanged += new System.EventHandler(this.listViewPost_SelectedIndexChanged);
            this.listViewPost.DoubleClick += new System.EventHandler(this.listViewPost_DoubleClick);
            this.listViewPost.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewPost_MouseClick);
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "No.";
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "제목";
            this.columnTitle.Width = 289;
            // 
            // columnWriter
            // 
            this.columnWriter.Text = "작성자";
            // 
            // columnHits
            // 
            this.columnHits.Text = "조회수";
            // 
            // columnDate
            // 
            this.columnDate.Text = "작성일자";
            this.columnDate.Width = 193;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(650, 22);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxFollower
            // 
            this.checkBoxFollower.AutoSize = true;
            this.checkBoxFollower.Location = new System.Drawing.Point(56, 65);
            this.checkBoxFollower.Name = "checkBoxFollower";
            this.checkBoxFollower.Size = new System.Drawing.Size(116, 16);
            this.checkBoxFollower.TabIndex = 7;
            this.checkBoxFollower.Text = "팔로우 한 사람만";
            this.checkBoxFollower.UseVisualStyleBackColor = true;
            // 
            // buttonWriteBoard
            // 
            this.buttonWriteBoard.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonWriteBoard.FlatAppearance.BorderSize = 0;
            this.buttonWriteBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWriteBoard.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonWriteBoard.ForeColor = System.Drawing.Color.White;
            this.buttonWriteBoard.Location = new System.Drawing.Point(650, 65);
            this.buttonWriteBoard.Name = "buttonWriteBoard";
            this.buttonWriteBoard.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteBoard.TabIndex = 8;
            this.buttonWriteBoard.Text = "작성";
            this.buttonWriteBoard.UseVisualStyleBackColor = false;
            this.buttonWriteBoard.Click += new System.EventHandler(this.buttonWriteBoard_Click);
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Items.AddRange(new object[] {
            "제목",
            "내용",
            "작성자"});
            this.comboBoxKeyword.Location = new System.Drawing.Point(56, 22);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(121, 20);
            this.comboBoxKeyword.TabIndex = 9;
            this.comboBoxKeyword.Text = "제목";
            // 
            // checkBoxMine
            // 
            this.checkBoxMine.AutoSize = true;
            this.checkBoxMine.Location = new System.Drawing.Point(183, 65);
            this.checkBoxMine.Name = "checkBoxMine";
            this.checkBoxMine.Size = new System.Drawing.Size(80, 16);
            this.checkBoxMine.TabIndex = 10;
            this.checkBoxMine.Text = "내 글 보기";
            this.checkBoxMine.UseVisualStyleBackColor = true;
            // 
            // FormBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.checkBoxMine);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.buttonWriteBoard);
            this.Controls.Add(this.checkBoxFollower);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listViewPost);
            this.Controls.Add(this.txtSearchContents);
            this.Name = "FormBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBoard_FormClosing);
            this.Load += new System.EventHandler(this.FormBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchContents;
        private System.Windows.Forms.ListView listViewPost;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnHits;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxFollower;
        private System.Windows.Forms.ColumnHeader columnWriter;
        private System.Windows.Forms.Button buttonWriteBoard;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.CheckBox checkBoxMine;
    }
}
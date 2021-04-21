namespace PCCafeSNS
{
    partial class FormGroupBoard
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
            this.dataGridViewGroupBoard = new System.Windows.Forms.DataGridView();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGroupBoard
            // 
            this.dataGridViewGroupBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupBoard.Location = new System.Drawing.Point(99, 336);
            this.dataGridViewGroupBoard.Name = "dataGridViewGroupBoard";
            this.dataGridViewGroupBoard.RowTemplate.Height = 30;
            this.dataGridViewGroupBoard.Size = new System.Drawing.Size(581, 497);
            this.dataGridViewGroupBoard.TabIndex = 2;
            this.dataGridViewGroupBoard.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGroupBoard_CellMouseDoubleClick);
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxGroupName.Location = new System.Drawing.Point(175, 82);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(391, 42);
            this.textBoxGroupName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(105, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "그룹게시판";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(555, 259);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(118, 30);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "새로고침";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(382, 259);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(118, 30);
            this.buttonWrite.TabIndex = 7;
            this.buttonWrite.Text = "그룹 글쓰기";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // FormGroupBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 887);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.dataGridViewGroupBoard);
            this.Name = "FormGroupBoard";
            this.Text = "FormGroupBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGroupBoard;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonWrite;
    }
}
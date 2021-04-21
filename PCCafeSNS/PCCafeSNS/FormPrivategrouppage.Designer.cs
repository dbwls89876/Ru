namespace PCCafeSNS
{
    partial class FormPrivategrouppage
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
            this.textBoxGroupname = new System.Windows.Forms.TextBox();
            this.buttonGroupjoin = new System.Windows.Forms.Button();
            this.dataGridViewGroupuserlist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchgroupuser = new System.Windows.Forms.TextBox();
            this.buttonSearchgroupuser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrivategroupUserlistRefresh = new System.Windows.Forms.Button();
            this.buttonSecession = new System.Windows.Forms.Button();
            this.buttonGoGroupBoard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupuserlist)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxGroupname
            // 
            this.textBoxGroupname.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxGroupname.Location = new System.Drawing.Point(146, 54);
            this.textBoxGroupname.Name = "textBoxGroupname";
            this.textBoxGroupname.Size = new System.Drawing.Size(229, 42);
            this.textBoxGroupname.TabIndex = 0;
            // 
            // buttonGroupjoin
            // 
            this.buttonGroupjoin.Location = new System.Drawing.Point(444, 61);
            this.buttonGroupjoin.Name = "buttonGroupjoin";
            this.buttonGroupjoin.Size = new System.Drawing.Size(148, 35);
            this.buttonGroupjoin.TabIndex = 2;
            this.buttonGroupjoin.Text = "가입하기";
            this.buttonGroupjoin.UseVisualStyleBackColor = true;
            this.buttonGroupjoin.Click += new System.EventHandler(this.buttonGroupjoin_Click);
            // 
            // dataGridViewGroupuserlist
            // 
            this.dataGridViewGroupuserlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupuserlist.Location = new System.Drawing.Point(42, 351);
            this.dataGridViewGroupuserlist.Name = "dataGridViewGroupuserlist";
            this.dataGridViewGroupuserlist.RowTemplate.Height = 30;
            this.dataGridViewGroupuserlist.Size = new System.Drawing.Size(550, 393);
            this.dataGridViewGroupuserlist.TabIndex = 3;
            this.dataGridViewGroupuserlist.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGroupuserlist_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "회원리스트";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSearchgroupuser
            // 
            this.textBoxSearchgroupuser.Location = new System.Drawing.Point(146, 198);
            this.textBoxSearchgroupuser.Name = "textBoxSearchgroupuser";
            this.textBoxSearchgroupuser.Size = new System.Drawing.Size(229, 28);
            this.textBoxSearchgroupuser.TabIndex = 5;
            // 
            // buttonSearchgroupuser
            // 
            this.buttonSearchgroupuser.Location = new System.Drawing.Point(444, 192);
            this.buttonSearchgroupuser.Name = "buttonSearchgroupuser";
            this.buttonSearchgroupuser.Size = new System.Drawing.Size(148, 37);
            this.buttonSearchgroupuser.TabIndex = 6;
            this.buttonSearchgroupuser.Text = "검색하기";
            this.buttonSearchgroupuser.UseVisualStyleBackColor = true;
            this.buttonSearchgroupuser.Click += new System.EventHandler(this.buttonSearchgroupuser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "회원명";
            // 
            // buttonPrivategroupUserlistRefresh
            // 
            this.buttonPrivategroupUserlistRefresh.Location = new System.Drawing.Point(444, 290);
            this.buttonPrivategroupUserlistRefresh.Name = "buttonPrivategroupUserlistRefresh";
            this.buttonPrivategroupUserlistRefresh.Size = new System.Drawing.Size(148, 29);
            this.buttonPrivategroupUserlistRefresh.TabIndex = 8;
            this.buttonPrivategroupUserlistRefresh.Text = "새로고침";
            this.buttonPrivategroupUserlistRefresh.UseVisualStyleBackColor = true;
            this.buttonPrivategroupUserlistRefresh.Click += new System.EventHandler(this.buttonPrivategroupUserlistRefresh_Click);
            // 
            // buttonSecession
            // 
            this.buttonSecession.Location = new System.Drawing.Point(444, 124);
            this.buttonSecession.Name = "buttonSecession";
            this.buttonSecession.Size = new System.Drawing.Size(148, 35);
            this.buttonSecession.TabIndex = 9;
            this.buttonSecession.Text = "탈퇴하기";
            this.buttonSecession.UseVisualStyleBackColor = true;
            this.buttonSecession.Click += new System.EventHandler(this.buttonSecession_Click);
            // 
            // buttonGoGroupBoard
            // 
            this.buttonGoGroupBoard.Font = new System.Drawing.Font("굴림", 13F);
            this.buttonGoGroupBoard.Location = new System.Drawing.Point(42, 787);
            this.buttonGoGroupBoard.Name = "buttonGoGroupBoard";
            this.buttonGoGroupBoard.Size = new System.Drawing.Size(550, 44);
            this.buttonGoGroupBoard.TabIndex = 10;
            this.buttonGoGroupBoard.Text = "게시판으로 이동하기";
            this.buttonGoGroupBoard.UseVisualStyleBackColor = true;
            this.buttonGoGroupBoard.Click += new System.EventHandler(this.buttonGoGroupBoard_Click);
            // 
            // FormPrivategrouppage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 878);
            this.Controls.Add(this.buttonGoGroupBoard);
            this.Controls.Add(this.buttonSecession);
            this.Controls.Add(this.buttonPrivategroupUserlistRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchgroupuser);
            this.Controls.Add(this.textBoxSearchgroupuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewGroupuserlist);
            this.Controls.Add(this.buttonGroupjoin);
            this.Controls.Add(this.textBoxGroupname);
            this.Name = "FormPrivategrouppage";
            this.Text = "FormPrivategrouppage";
            this.Load += new System.EventHandler(this.FormPrivategrouppage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupuserlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGroupname;
        private System.Windows.Forms.Button buttonGroupjoin;
        private System.Windows.Forms.DataGridView dataGridViewGroupuserlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchgroupuser;
        private System.Windows.Forms.Button buttonSearchgroupuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrivategroupUserlistRefresh;
        private System.Windows.Forms.Button buttonSecession;
        private System.Windows.Forms.Button buttonGoGroupBoard;
    }
}
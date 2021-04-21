namespace PCCafeSNS
{
    partial class FormGroupmain
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
            this.buttonGroupCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGrouplist = new System.Windows.Forms.DataGridView();
            this.textBoxMyGroupname = new System.Windows.Forms.TextBox();
            this.textBoxGroupSearchKeword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGroupSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그룹매니저권한ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그룹관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRfreshgrouplist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrouplist)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGroupCreate
            // 
            this.buttonGroupCreate.Location = new System.Drawing.Point(648, 71);
            this.buttonGroupCreate.Name = "buttonGroupCreate";
            this.buttonGroupCreate.Size = new System.Drawing.Size(126, 42);
            this.buttonGroupCreate.TabIndex = 0;
            this.buttonGroupCreate.Text = "그룹생성";
            this.buttonGroupCreate.UseVisualStyleBackColor = true;
            this.buttonGroupCreate.Click += new System.EventHandler(this.buttonGroupCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "내그룹";
            // 
            // dataGridViewGrouplist
            // 
            this.dataGridViewGrouplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrouplist.Location = new System.Drawing.Point(66, 273);
            this.dataGridViewGrouplist.Name = "dataGridViewGrouplist";
            this.dataGridViewGrouplist.RowTemplate.Height = 30;
            this.dataGridViewGrouplist.Size = new System.Drawing.Size(708, 316);
            this.dataGridViewGrouplist.TabIndex = 2;
            this.dataGridViewGrouplist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrouplist_CellDoubleClick);
            // 
            // textBoxMyGroupname
            // 
            this.textBoxMyGroupname.Location = new System.Drawing.Point(200, 80);
            this.textBoxMyGroupname.Name = "textBoxMyGroupname";
            this.textBoxMyGroupname.Size = new System.Drawing.Size(152, 28);
            this.textBoxMyGroupname.TabIndex = 3;
            // 
            // textBoxGroupSearchKeword
            // 
            this.textBoxGroupSearchKeword.Location = new System.Drawing.Point(66, 165);
            this.textBoxGroupSearchKeword.Name = "textBoxGroupSearchKeword";
            this.textBoxGroupSearchKeword.Size = new System.Drawing.Size(438, 28);
            this.textBoxGroupSearchKeword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "그룹리스트";
            // 
            // buttonGroupSearch
            // 
            this.buttonGroupSearch.Location = new System.Drawing.Point(648, 156);
            this.buttonGroupSearch.Name = "buttonGroupSearch";
            this.buttonGroupSearch.Size = new System.Drawing.Size(126, 42);
            this.buttonGroupSearch.TabIndex = 6;
            this.buttonGroupSearch.Text = "그룹검색";
            this.buttonGroupSearch.UseVisualStyleBackColor = true;
            this.buttonGroupSearch.Click += new System.EventHandler(this.buttonGroupSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그룹매니저권한ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // 그룹매니저권한ToolStripMenuItem
            // 
            this.그룹매니저권한ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그룹관리ToolStripMenuItem});
            this.그룹매니저권한ToolStripMenuItem.Name = "그룹매니저권한ToolStripMenuItem";
            this.그룹매니저권한ToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.그룹매니저권한ToolStripMenuItem.Text = "그룹매니저권한";
            // 
            // 그룹관리ToolStripMenuItem
            // 
            this.그룹관리ToolStripMenuItem.Name = "그룹관리ToolStripMenuItem";
            this.그룹관리ToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.그룹관리ToolStripMenuItem.Text = "그룹관리";
            this.그룹관리ToolStripMenuItem.Click += new System.EventHandler(this.그룹관리ToolStripMenuItem_Click_1);
            // 
            // buttonRfreshgrouplist
            // 
            this.buttonRfreshgrouplist.Location = new System.Drawing.Point(648, 219);
            this.buttonRfreshgrouplist.Name = "buttonRfreshgrouplist";
            this.buttonRfreshgrouplist.Size = new System.Drawing.Size(126, 38);
            this.buttonRfreshgrouplist.TabIndex = 8;
            this.buttonRfreshgrouplist.Text = "새로고침";
            this.buttonRfreshgrouplist.UseVisualStyleBackColor = true;
            this.buttonRfreshgrouplist.Click += new System.EventHandler(this.buttonRfreshgrouplist_Click);
            // 
            // FormGroupmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 628);
            this.Controls.Add(this.buttonRfreshgrouplist);
            this.Controls.Add(this.buttonGroupSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGroupSearchKeword);
            this.Controls.Add(this.textBoxMyGroupname);
            this.Controls.Add(this.dataGridViewGrouplist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGroupCreate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGroupmain";
            this.Text = "Groupmain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrouplist)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGroupCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGrouplist;
        private System.Windows.Forms.TextBox textBoxMyGroupname;
        private System.Windows.Forms.TextBox textBoxGroupSearchKeword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGroupSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그룹매니저권한ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그룹관리ToolStripMenuItem;
        private System.Windows.Forms.Button buttonRfreshgrouplist;
    }
}
namespace CoffeeShop
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCoffeeMonthSale = new System.Windows.Forms.DataGridView();
            this.dataGridViewCoffeeDailySale = new System.Windows.Forms.DataGridView();
            this.dataGridViewUserSale = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.buttonLoguot = new System.Windows.Forms.Button();
            this.labelLoginState = new System.Windows.Forms.Label();
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저널조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffeeMonthSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffeeDailySale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSale)).BeginInit();
            this.menuStripAdmin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(35, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 195);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "관리자용 화면";
            // 
            // dataGridViewCoffeeMonthSale
            // 
            this.dataGridViewCoffeeMonthSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoffeeMonthSale.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewCoffeeMonthSale.Name = "dataGridViewCoffeeMonthSale";
            this.dataGridViewCoffeeMonthSale.RowTemplate.Height = 23;
            this.dataGridViewCoffeeMonthSale.Size = new System.Drawing.Size(685, 126);
            this.dataGridViewCoffeeMonthSale.TabIndex = 8;
            // 
            // dataGridViewCoffeeDailySale
            // 
            this.dataGridViewCoffeeDailySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoffeeDailySale.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewCoffeeDailySale.Name = "dataGridViewCoffeeDailySale";
            this.dataGridViewCoffeeDailySale.RowTemplate.Height = 23;
            this.dataGridViewCoffeeDailySale.Size = new System.Drawing.Size(685, 125);
            this.dataGridViewCoffeeDailySale.TabIndex = 3;
            // 
            // dataGridViewUserSale
            // 
            this.dataGridViewUserSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserSale.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewUserSale.Name = "dataGridViewUserSale";
            this.dataGridViewUserSale.RowTemplate.Height = 23;
            this.dataGridViewUserSale.Size = new System.Drawing.Size(685, 125);
            this.dataGridViewUserSale.TabIndex = 0;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // buttonLoguot
            // 
            this.buttonLoguot.Location = new System.Drawing.Point(725, 1);
            this.buttonLoguot.Name = "buttonLoguot";
            this.buttonLoguot.Size = new System.Drawing.Size(75, 23);
            this.buttonLoguot.TabIndex = 7;
            this.buttonLoguot.Text = "로그아웃";
            this.buttonLoguot.UseVisualStyleBackColor = true;
            this.buttonLoguot.Click += new System.EventHandler(this.buttonLoguot_Click);
            // 
            // labelLoginState
            // 
            this.labelLoginState.AutoSize = true;
            this.labelLoginState.Location = new System.Drawing.Point(465, 19);
            this.labelLoginState.Name = "labelLoginState";
            this.labelLoginState.Size = new System.Drawing.Size(0, 12);
            this.labelLoginState.TabIndex = 8;
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.logToolStripMenuItem,
            this.메뉴관리ToolStripMenuItem,
            this.저널조회ToolStripMenuItem});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(800, 24);
            this.menuStripAdmin.TabIndex = 9;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.logToolStripMenuItem.Text = "로그";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loginToolStripMenuItem.Text = "login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logoutToolStripMenuItem.Text = "logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // 메뉴관리ToolStripMenuItem
            // 
            this.메뉴관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.메뉴수정ToolStripMenuItem});
            this.메뉴관리ToolStripMenuItem.Name = "메뉴관리ToolStripMenuItem";
            this.메뉴관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.메뉴관리ToolStripMenuItem.Text = "메뉴관리";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem2.Text = "메뉴 추가";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 메뉴수정ToolStripMenuItem
            // 
            this.메뉴수정ToolStripMenuItem.Name = "메뉴수정ToolStripMenuItem";
            this.메뉴수정ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.메뉴수정ToolStripMenuItem.Text = "메뉴 수정";
            this.메뉴수정ToolStripMenuItem.Click += new System.EventHandler(this.메뉴수정ToolStripMenuItem_Click);
            // 
            // 저널조회ToolStripMenuItem
            // 
            this.저널조회ToolStripMenuItem.Name = "저널조회ToolStripMenuItem";
            this.저널조회ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.저널조회ToolStripMenuItem.Text = "저널 조회";
            this.저널조회ToolStripMenuItem.Click += new System.EventHandler(this.저널조회ToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(44, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 139);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캐셔용 화면";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 165);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewUserSale);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "사용자별 일일 판매";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewCoffeeDailySale);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "커피종류별 일일 판매";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewCoffeeMonthSale);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(697, 161);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "커피종류별 월별 누적 판매";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelLoginState);
            this.Controls.Add(this.buttonLoguot);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStripAdmin);
            this.MainMenuStrip = this.menuStripAdmin;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffeeMonthSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffeeDailySale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSale)).EndInit();
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Button buttonLoguot;
        private System.Windows.Forms.Label labelLoginState;
        private System.Windows.Forms.DataGridView dataGridViewUserSale;
        private System.Windows.Forms.DataGridView dataGridViewCoffeeDailySale;
        private System.Windows.Forms.DataGridView dataGridViewCoffeeMonthSale;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 메뉴수정ToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem 저널조회ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}


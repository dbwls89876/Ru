namespace PCCafeSNS
{
    partial class FormMain
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
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.buttonBoard = new System.Windows.Forms.Button();
            this.buttonClub = new System.Windows.Forms.Button();
            this.buttonNotice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewRecentPost = new System.Windows.Forms.ListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRecentComment = new System.Windows.Forms.ListView();
            this.columnRecentNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.listViewGameRank = new System.Windows.Forms.ListView();
            this.columnGame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRatio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUserInfo.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.buttonUserInfo.FlatAppearance.BorderSize = 0;
            this.buttonUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.buttonUserInfo.ForeColor = System.Drawing.Color.White;
            this.buttonUserInfo.Location = new System.Drawing.Point(467, 93);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonUserInfo.TabIndex = 0;
            this.buttonUserInfo.Text = "내정보";
            this.buttonUserInfo.UseVisualStyleBackColor = false;
            this.buttonUserInfo.Click += new System.EventHandler(this.buttonUserInfo_Click);
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Location = new System.Drawing.Point(467, 12);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxUserImage.TabIndex = 1;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearchUser.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.buttonSearchUser.FlatAppearance.BorderSize = 0;
            this.buttonSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSearchUser.ForeColor = System.Drawing.Color.White;
            this.buttonSearchUser.Location = new System.Drawing.Point(467, 122);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(75, 40);
            this.buttonSearchUser.TabIndex = 2;
            this.buttonSearchUser.Text = "유저 검색";
            this.buttonSearchUser.UseVisualStyleBackColor = false;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // buttonBoard
            // 
            this.buttonBoard.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonBoard.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.buttonBoard.FlatAppearance.BorderSize = 0;
            this.buttonBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBoard.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.buttonBoard.ForeColor = System.Drawing.Color.White;
            this.buttonBoard.Location = new System.Drawing.Point(87, 384);
            this.buttonBoard.Name = "buttonBoard";
            this.buttonBoard.Size = new System.Drawing.Size(75, 23);
            this.buttonBoard.TabIndex = 4;
            this.buttonBoard.Text = "게시판";
            this.buttonBoard.UseVisualStyleBackColor = false;
            this.buttonBoard.Click += new System.EventHandler(this.buttonBoard_Click);
            // 
            // buttonClub
            // 
            this.buttonClub.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonClub.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.buttonClub.FlatAppearance.BorderSize = 0;
            this.buttonClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClub.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.buttonClub.ForeColor = System.Drawing.Color.White;
            this.buttonClub.Location = new System.Drawing.Point(238, 384);
            this.buttonClub.Name = "buttonClub";
            this.buttonClub.Size = new System.Drawing.Size(75, 23);
            this.buttonClub.TabIndex = 5;
            this.buttonClub.Text = "클럽";
            this.buttonClub.UseVisualStyleBackColor = false;
            this.buttonClub.Click += new System.EventHandler(this.buttonClub_Click);
            // 
            // buttonNotice
            // 
            this.buttonNotice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonNotice.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.buttonNotice.FlatAppearance.BorderSize = 0;
            this.buttonNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotice.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.buttonNotice.ForeColor = System.Drawing.Color.White;
            this.buttonNotice.Location = new System.Drawing.Point(414, 384);
            this.buttonNotice.Name = "buttonNotice";
            this.buttonNotice.Size = new System.Drawing.Size(75, 23);
            this.buttonNotice.TabIndex = 6;
            this.buttonNotice.Text = "알림";
            this.buttonNotice.UseVisualStyleBackColor = false;
            this.buttonNotice.Click += new System.EventHandler(this.buttonNotice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "최근에 쓴 글";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "최근에 쓴 댓글";
            // 
            // listViewRecentPost
            // 
            this.listViewRecentPost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnTitle});
            this.listViewRecentPost.FullRowSelect = true;
            this.listViewRecentPost.HideSelection = false;
            this.listViewRecentPost.Location = new System.Drawing.Point(40, 175);
            this.listViewRecentPost.Name = "listViewRecentPost";
            this.listViewRecentPost.Size = new System.Drawing.Size(397, 77);
            this.listViewRecentPost.TabIndex = 11;
            this.listViewRecentPost.UseCompatibleStateImageBehavior = false;
            this.listViewRecentPost.View = System.Windows.Forms.View.Details;
            this.listViewRecentPost.DoubleClick += new System.EventHandler(this.listViewRecentPost_DoubleClick);
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "No.";
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "제목";
            this.columnTitle.Width = 324;
            // 
            // listViewRecentComment
            // 
            this.listViewRecentComment.BackColor = System.Drawing.Color.White;
            this.listViewRecentComment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRecentNumber,
            this.columnComment});
            this.listViewRecentComment.FullRowSelect = true;
            this.listViewRecentComment.HideSelection = false;
            this.listViewRecentComment.Location = new System.Drawing.Point(40, 286);
            this.listViewRecentComment.Name = "listViewRecentComment";
            this.listViewRecentComment.Size = new System.Drawing.Size(397, 72);
            this.listViewRecentComment.TabIndex = 12;
            this.listViewRecentComment.UseCompatibleStateImageBehavior = false;
            this.listViewRecentComment.View = System.Windows.Forms.View.Details;
            this.listViewRecentComment.DoubleClick += new System.EventHandler(this.listViewRecentComment_DoubleClick);
            // 
            // columnRecentNumber
            // 
            this.columnRecentNumber.Text = "No.";
            // 
            // columnComment
            // 
            this.columnComment.Text = "댓글";
            this.columnComment.Width = 318;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "PC방 점유율";
            // 
            // listViewGameRank
            // 
            this.listViewGameRank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnGame,
            this.columnGenre,
            this.columnRatio});
            this.listViewGameRank.HideSelection = false;
            this.listViewGameRank.Location = new System.Drawing.Point(40, 41);
            this.listViewGameRank.Name = "listViewGameRank";
            this.listViewGameRank.Size = new System.Drawing.Size(397, 97);
            this.listViewGameRank.TabIndex = 15;
            this.listViewGameRank.UseCompatibleStateImageBehavior = false;
            this.listViewGameRank.View = System.Windows.Forms.View.Details;
            // 
            // columnGame
            // 
            this.columnGame.Text = "게임 이름";
            this.columnGame.Width = 244;
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "장르";
            this.columnGenre.Width = 82;
            // 
            // columnRatio
            // 
            this.columnRatio.Text = "점유율";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(12, 11);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 16;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 472);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.listViewGameRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewRecentComment);
            this.Controls.Add(this.listViewRecentPost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNotice);
            this.Controls.Add(this.buttonClub);
            this.Controls.Add(this.buttonBoard);
            this.Controls.Add(this.buttonSearchUser);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Controls.Add(this.buttonUserInfo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.Button buttonBoard;
        private System.Windows.Forms.Button buttonClub;
        private System.Windows.Forms.Button buttonNotice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewRecentPost;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ListView listViewRecentComment;
        private System.Windows.Forms.ColumnHeader columnRecentNumber;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewGameRank;
        private System.Windows.Forms.ColumnHeader columnGame;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.ColumnHeader columnRatio;
        private System.Windows.Forms.Button buttonLogout;
    }
}


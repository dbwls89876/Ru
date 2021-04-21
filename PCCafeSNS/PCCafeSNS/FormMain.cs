using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PCCafeSNS
{
    public partial class FormMain : Form
    {
        private bool closing = false;
        RankPCGame RPG;
        Thread ranking;
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(string ID)
        {
            InitializeComponent();
            
        }

        private void UpdateImage()
        {
            if (User.image != null)
            {
                pictureBoxUserImage.Image = User.image;
                pictureBoxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void MakeHome()
        {

        }

        private void buttonUserInfo_Click(object sender, EventArgs e)
        {
            FormUserInfo fui = new FormUserInfo();
            fui.Show();
            buttonUserInfo.Enabled = false;
            fui.FormClosing += delegate (object s, FormClosingEventArgs E)
            {
                if(!closing)
                {
                    buttonUserInfo.Enabled = true;
                    UpdateImage();
                }
            };
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            FormSearchUser fsu = new FormSearchUser();
            fsu.Show();
            buttonSearchUser.Enabled = false;
            fsu.FormClosing+= delegate (object s, FormClosingEventArgs E)
            {
                if(!closing)
                    buttonSearchUser.Enabled = true;
            };
        }
        

        private void buttonBoard_Click(object sender, EventArgs e)
        {
            FormBoard fb = new FormBoard();
            fb.Show();
            buttonBoard.Enabled = false;
            fb.FormClosing += delegate (object s, FormClosingEventArgs E)
              {
                  if(buttonBoard!=null)
                      buttonBoard.Enabled = true;
              };
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshComment();
            RefreshPost();
            UpdateImage();
            RefreshGameRank();


        }

        private void RefreshComment()
        {
            DataTable dt = DBManager.getInstance().Query($"SELECT commentID,contents FROM COMMENT WHERE userID='{User.ID}' ORDER BY writtenDate DESC Limit 2");
            listViewRecentComment.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                string[] values = { dr["commentID"].ToString(), dr["contents"].ToString() };
                listViewRecentComment.Items.Add(new ListViewItem(values));
            }
        }

        private void RefreshPost()
        {
            DataTable dt = DBManager.getInstance().Query($"SELECT boardID, title FROM BOARD WHERE userID='{User.ID}' ORDER BY writtenDate DESC Limit 2");
            listViewRecentPost.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string[] values = { dr["boardID"].ToString(), dr["title"].ToString() };
                listViewRecentPost.Items.Add(new ListViewItem(values));
            }
        }
        
        private void RefreshGameRank()
        {
            RPG = new RankPCGame();
            ranking = new Thread(CheckRanking);
            ranking.Start();
        }

        private void CheckRanking()
        {
            while(true)
            {
                if(RPG.isComplete())
                {
                    this.Invoke(new Action(delegate ()
                    {
                        foreach (var item in RPG.getList())
                        {
                            listViewGameRank.Items.Add(new ListViewItem(item));
                        }
                    }));
                    
                    break;
                }
            }
        }

        private void listViewRecentPost_DoubleClick(object sender, EventArgs e)
        {
            FormBoardReader fbr = new FormBoardReader(Int32.Parse(listViewRecentPost.FocusedItem.SubItems[0].Text));
            fbr.Show();
            fbr.FormClosing += delegate (object S, FormClosingEventArgs E)
              {
                  if(!closing)
                  {
                      RefreshPost();
                      RefreshComment();
                  }
                      
              };
        }

        private void listViewRecentComment_DoubleClick(object sender, EventArgs e)
        {
            DataTable dt = DBManager.getInstance().Query($"SELECT boardID FROM COMMENT WHERE userID='{User.ID}' AND commentID={listViewRecentComment.FocusedItem.SubItems[0].Text}");
            FormBoardReader fbr = new FormBoardReader(Int32.Parse(dt.Rows[0]["boardID"].ToString()));
            fbr.Show();
            fbr.FormClosing += delegate (object S, FormClosingEventArgs E)
            {
                if(!closing)
                {
                    RefreshPost();
                    RefreshComment();
                }
            };
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
        }

        private void buttonNotice_Click(object sender, EventArgs e)
        {
            buttonNotice.Enabled = false;
            FormMessage fn = new FormMessage();
            fn.Show();
            fn.FormClosing += delegate (object S, FormClosingEventArgs E)
            {
                if(!closing)
                {
                    buttonNotice.Enabled = true;
                }
            };
        }

        private void buttonClub_Click(object sender, EventArgs e)
        {
            buttonClub.Enabled = false;
            FormGroupmain fg = new FormGroupmain();
            fg.Show();
            fg.FormClosing += delegate (object S, FormClosingEventArgs E)
              {
                  if(!closing)
                  {
                      buttonClub.Enabled = true;
                  }
              };
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            User.empty();
            Close();
        }
    }
}

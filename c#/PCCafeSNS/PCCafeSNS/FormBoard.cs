using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PCCafeSNS
{
    public partial class FormBoard : MetroForm
    {
        private bool closing=false;
        string ClubID;
        ContextMenu menu = new ContextMenu();
        
        public FormBoard(string ClubID="없음")
        {
            InitializeComponent();
            this.ClubID = ClubID;     
        }

        private void Init()
        {
            AddList($"SELECT BOARD.boardID, title, ifnull(commentCount,0) as commentCount ,writtenDate, userID, hit FROM BOARD LEFT JOIN (SELECT COMMENT.boardID, COUNT(*) as commentCount FROM COMMENT GROUP BY COMMENT.boardID) as C ON BOARD.boardID=C.boardID WHERE clubID='{ClubID}' ORDER BY writtenDate DESC");
        }

        private void AddList(string Query)
        {
            listViewPost.Update();
            listViewPost.Items.Clear();
            DataTable dt = DBManager.getInstance().Query(Query);
            foreach (DataRow dr in dt.Rows)
            {
                string[] items = { dr["boardID"].ToString(), dr["title"].ToString() + " (" + dr["commentCount"].ToString() + ")", dr["userID"].ToString(), dr["hit"].ToString(), dr["writtenDate"].ToString() };
                ListViewItem listViewItem = new ListViewItem(items);
                listViewItem.Focused = true;
                listViewPost.Items.Add(new ListViewItem(items));
            }
            listViewPost.EndUpdate();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(txtSearchContents.Text=="")
            {
                if(checkBoxFollower.Checked)
                {
                    if(checkBoxMine.Checked)
                    {
                        AddList($"SELECT BOARD.boardID, title, ifnull(commentCount,0) as commentCount ,writtenDate, BOARD.userID as userID, hit FROM BOARD LEFT JOIN (SELECT COMMENT.boardID, COUNT(*) as commentCount " +
                        $"FROM COMMENT GROUP BY COMMENT.boardID) as C ON BOARD.boardID=C.boardID " +
                        $"WHERE clubID='{ClubID}' AND BOARD.userID='{User.ID}' OR BOARD.userID IN (SELECT followerID FROM FOLLOWER WHERE FOLLOWER.userID='{User.ID}' AND state=1)");
                    }
                    else
                    {
                        AddList($"SELECT BOARD.boardID, title, ifnull(commentCount,0) as commentCount ,writtenDate, BOARD.userID as userID, hit FROM BOARD LEFT JOIN (SELECT COMMENT.boardID, COUNT(*) as commentCount " +
                        $"FROM COMMENT GROUP BY COMMENT.boardID) as C ON BOARD.boardID=C.boardID " +
                        $"WHERE clubID='{ClubID}' AND BOARD.userID IN (SELECT followerID FROM FOLLOWER WHERE FOLLOWER.userID='{User.ID}' AND state=1)");
                    }

                }
                else
                {
                    if(checkBoxMine.Checked)
                    {
                        AddList($"SELECT BOARD.boardID, title, ifnull(commentCount,0) as commentCount ,writtenDate, BOARD.userID as userID, hit FROM BOARD LEFT JOIN (SELECT COMMENT.boardID, COUNT(*) as commentCount " +
                        $"FROM COMMENT GROUP BY COMMENT.boardID) as C ON BOARD.boardID=C.boardID " +
                        $"WHERE clubID='{ClubID}' AND BOARD.userID='{User.ID}'");
                    }
                    else
                       Init();
                }
                    
            }
            else
            {
                string Keyword = comboBoxKeyword.Text;
                if (Keyword == "제목")
                {
                    Keyword = "title";
                }
                else if (Keyword == "작성자")
                {
                    Keyword = "userID";
                }
                else if (Keyword == "내용")
                {
                    Keyword = "contents";
                }
                if (checkBoxFollower.Checked)
                {
                    if(checkBoxMine.Checked)
                    {
                        AddList($"SELECT BOARD.boardID, title, ifnull(commentCount,0) as commentCount ,writtenDate, BOARD.userID as userID, hit FROM BOARD LEFT JOIN (SELECT COMMENT.boardID, COUNT(*) as commentCount " +
                        $"FROM COMMENT GROUP BY COMMENT.boardID) as C ON BOARD.boardID=C.boardID " +
                        $"WHERE clubID='{ClubID}' AND BOARD.{Keyword} LIKE '%{txtSearchContents.Text}%' AND BOARD.userID='{User.ID}' OR BOARD.userID IN (SELECT followerID FROM FOLLOWER WHERE FOLLOWER.userID='{User.ID}' AND state=1)");
                    }
                    else
                    {
                        AddList($"SELECT BOARD.boardID, title, ifnull(commentCount,0) as commentCount ,writtenDate, BOARD.userID as userID, hit FROM BOARD LEFT JOIN (SELECT COMMENT.boardID, COUNT(*) as commentCount " +
                        $"FROM COMMENT GROUP BY COMMENT.boardID) as C ON BOARD.boardID=C.boardID " +
                        $"WHERE clubID='{ClubID}' AND BOARD.{Keyword} LIKE '%{txtSearchContents.Text}%' AND BOARD.userID IN (SELECT followerID FROM FOLLOWER WHERE FOLLOWER.userID='{User.ID}' AND state=1)");
                    }
                    
                }
                else
                {
                    if(checkBoxMine.Checked)
                    {
                        AddList($"SELECT BOARD.boardID, title, ifnull(commentCount,0) as commentCount ,writtenDate, BOARD.userID as userID, hit FROM BOARD LEFT JOIN (SELECT COMMENT.boardID, COUNT(*) as commentCount " +
                        $"FROM COMMENT GROUP BY COMMENT.boardID) as C ON BOARD.boardID=C.boardID " +
                        $"WHERE clubID='{ClubID}' AND BOARD.userID='{User.ID}' AND BOARD.{Keyword} LIKE '%{txtSearchContents.Text}%'");
                    }
                    else
                    {
                        AddList($"SELECT BOARD.boardID, title, ifnull(commentCount,0) as commentCount ,writtenDate, BOARD.userID as userID, hit FROM BOARD LEFT JOIN (SELECT COMMENT.boardID, COUNT(*) as commentCount " +
                        $"FROM COMMENT GROUP BY COMMENT.boardID) as C ON BOARD.boardID=C.boardID " +
                        $"WHERE clubID='{ClubID}' AND BOARD.{Keyword} LIKE '%{txtSearchContents.Text}%'");
                    }
                    
                }
                
                
            }
            

        }

        private void listViewPost_DoubleClick(object sender, EventArgs e)
        {
            FormBoardReader fbr = new FormBoardReader(Int32.Parse(listViewPost.FocusedItem.SubItems[0].Text));
            fbr.Show();
            fbr.FormClosing += FormClosingRefresh;
        }

        private void FormClosingRefresh(object sender, FormClosingEventArgs e)
        {
            if(!closing)
                buttonSearch_Click(sender, e);
        }
        

        private void buttonWriteBoard_Click(object sender, EventArgs e)
        {
            FormWriteBoard fw = new FormWriteBoard(ClubID);
            fw.Show();
            fw.FormClosing += FormClosingRefresh;
        }

        private void FormBoard_Load(object sender, EventArgs e)
        {
            Init();
            MenuItem modifyMenu = new MenuItem();
            MenuItem deleteMenu = new MenuItem();

            modifyMenu.Text = "수정하기";
            deleteMenu.Text = "삭제하기";
            modifyMenu.Click+= delegate (object S, EventArgs E)
              {
                FormWriteBoard fwb = new FormWriteBoard("없음", true, Int32.Parse(listViewPost.FocusedItem.SubItems[0].Text));
                fwb.Show();
                  fwb.FormClosing += FormClosingRefresh;
              };
            deleteMenu.Click += delegate (object S, EventArgs E)
              {
                  if(MessageBox.Show("게시글을 삭제합니다.", "게시글 삭제",MessageBoxButtons.YesNo)==DialogResult.Yes)
                  {
                      int boardID = Int32.Parse(listViewPost.FocusedItem.SubItems[0].Text);
                      DBManager.getInstance().nonQuery($"DELETE FROM BOARD WHERE boardID={boardID}");
                      DBManager.getInstance().nonQuery($"DELETE FROM PICTURE WHERE boardID={boardID}");
                      buttonSearch_Click(S, E);
                  }
              };
            menu.MenuItems.Add(modifyMenu);
            menu.MenuItems.Add(deleteMenu);
        }

        private void listViewPost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewPost_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if(User.ID==listViewPost.FocusedItem.SubItems[2].Text)
                {
                    if (listViewPost.FocusedItem.Bounds.Contains(e.Location))
                    {
                        menu.Show(listViewPost, new Point(e.X,e.Y));
                    }
                }
                
            }
        }

        private void FormBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
        }
    }
}

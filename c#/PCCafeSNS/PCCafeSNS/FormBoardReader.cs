using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;

namespace PCCafeSNS
{
    public partial class FormBoardReader : MetroForm
    {
        int boardID;
        bool closing = false;
        ContextMenu menu = new ContextMenu();
        public FormBoardReader(int boardID)
        {
            this.boardID = boardID;
            InitializeComponent();
            
            
        }

        private void loadPost()
        {
            DataTable dt = DBManager.getInstance().Query($"SELECT title, contents, userID, picture FROM BOARD LEFT JOIN PICTURE ON BOARD.boardID=PICTURE.boardID WHERE BOARD.boardID={boardID}");

            textBoxTitle.Text = dt.Rows[0]["title"].ToString();
            textBoxWriter.Text = dt.Rows[0]["userID"].ToString();
            if(textBoxWriter.Text==User.ID)
            {
                buttonModify.Visible = true;
            }
            richTextBoxContents.Text = dt.Rows[0]["contents"].ToString();
            
            if (dt.Rows[0]["picture"] == System.DBNull.Value)
            {
                return;
            }
            Byte[] byteBLOBData;
            byteBLOBData = (Byte[])dt.Rows[0]["picture"];
            MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromStream(stmBLOBData);
            stmBLOBData.Close();
        }

        private void loadComment()
        {
            DataTable dt = DBManager.getInstance().Query($"SELECT commentID, userID, contents, writtenDate FROM COMMENT WHERE COMMENT.boardID={boardID} ORDER BY writtenDate ASC");

            listView1.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                string[] item = { dr["commentID"].ToString(), dr["userID"].ToString(), dr["contents"].ToString(), dr["writtenDate"].ToString() };
                listView1.Items.Add(new ListViewItem(item));
            }

        }

        private void FormBoardReader_Load(object sender, EventArgs e)
        {
            loadPost();
            loadComment();
            MenuItem modifyMenu = new MenuItem();
            MenuItem deleteMenu = new MenuItem();

            TextBox tbModify = new TextBox();
            tbModify.Location = new System.Drawing.Point(58, 438);
            tbModify.Name = "tbModify";
            tbModify.Size = new System.Drawing.Size(479, 21);
            tbModify.TabIndex = 7;
            tbModify.Visible = false;
            tbModify.KeyDown += delegate (object S, KeyEventArgs E)
              {
                  if(E.KeyCode==Keys.Enter)
                  {
                      DBManager.getInstance().nonQuery($"UPDATE COMMENT SET contents='{tbModify.Text}' WHERE commentID={listView1.FocusedItem.SubItems[0].Text}");
                      loadComment();
                      tbModify.Visible = false;
                      tbModify.Text = "";
                  }
                  else if(E.KeyCode==Keys.Escape)
                  {
                      tbModify.Visible = false;
                      tbModify.Text = "";
                  }
              };
            this.Controls.Add(tbModify);
            modifyMenu.Text = "수정하기";
            deleteMenu.Text = "삭제하기";
            menu.MenuItems.Add(modifyMenu);
            menu.MenuItems.Add(deleteMenu);
            modifyMenu.Click += delegate (object S, EventArgs E)
            {
                tbModify.Location = new Point(200, PointToClient(MousePosition).Y);
                tbModify.BringToFront();
                tbModify.Visible = true;
            };
            deleteMenu.Click += delegate (object S, EventArgs E)
            {
                if (MessageBox.Show("댓글을 삭제합니다.", "게시글 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBManager.getInstance().nonQuery($"DELETE FROM COMMENT WHERE boardID={boardID} AND commentID={listView1.FocusedItem.SubItems[0].Text}");
                    loadComment();
                }
            };

            DBManager.getInstance().nonQuery($"UPDATE BOARD SET hit=hit+1 WHERE boardID={boardID}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("댓글을 입력 해주세요.");
                return;
            }
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DBManager.getInstance().nonQuery($"INSERT INTO COMMENT(boardID, contents, writtenDate, userID) VALUES({boardID},'{textBox1.Text}','{time}','{User.ID}')");
            textBox1.Text = "";
            loadComment();
        }
        

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (User.ID == listView1.FocusedItem.SubItems[1].Text)
                {
                    if (listView1.FocusedItem.Bounds.Contains(e.Location))
                    {
                        menu.Show(listView1, new Point(e.X, e.Y));
                    }
                }

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadComment();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            DataTable dt = DBManager.getInstance().Query($"SELECT clubID FROM BOARD WHERE boardID={boardID}");
            FormWriteBoard fwb = new FormWriteBoard(dt.Rows[0]["clubID"].ToString(), true, boardID);
            fwb.Show();
            fwb.FormClosing += delegate (object S, FormClosingEventArgs E)
              {
                  if (!closing)
                  {
                      loadPost();
                      loadComment();
                  }
              };
        }

        private void FormBoardReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            DataTable dt = DBManager.getInstance().Query($"SELECT userID FROM USER WHERE userID='{listView1.FocusedItem.SubItems[1].Text}'");
            if(dt.Rows[0]["userID"].ToString()!=User.ID)
            {
                FormStatus fs = new FormStatus(dt.Rows[0]["userID"].ToString());
                fs.Show();
            }
        }
    }
}

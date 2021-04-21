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

namespace PCCafeSNS
{
    public partial class FormWriteBoard : Form
    {
        string ClubID;
        bool modify = false;
        int boardID = -1;
        DataTable BeforeData;
        MemoryStream stmBLOBData;
        public FormWriteBoard(string ClubID="없음", bool modify=false, int boardID=-1)
        {
            InitializeComponent();
            this.ClubID = ClubID;
            this.modify = modify;
            this.boardID = boardID;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (!modify)
                {
                    string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    DBManager.getInstance().nonQuery($"INSERT INTO BOARD(title,contents,writtenDate,userID,clubID,hit) " +
                        $"VALUES('{textBoxTitle.Text}','{richTextBoxContents.Text}','{time}','{User.ID}','{ClubID}',0)");

                    if (pictureAttach.Image != null)
                    {
                        byte[] bImage = new byte[stmBLOBData.Length];
                        stmBLOBData.Read(bImage, 0, (int)stmBLOBData.Length);
                        DataTable dt = DBManager.getInstance().Query($"SELECT boardID FROM BOARD WHERE writtenDate='{time}' AND userID='{User.ID}'");
                        DBManager.getInstance().nonQuery($"INSERT INTO PICTURE(picture, boardID) VALUES(@image, {dt.Rows[0]["boardID"].ToString()})", bImage);
                        stmBLOBData.Close();
                    }
                }
                else
                {
                    string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    DBManager.getInstance().nonQuery($"UPDATE BOARD SET title='{textBoxTitle.Text}',contents='{richTextBoxContents.Text}',writtenDate='{time}',userID='{User.ID}',clubID='{ClubID}' WHERE boardID={boardID}");

                    if (pictureAttach.Image != null)
                    {
                        byte[] bImage = new byte[stmBLOBData.Length];
                        stmBLOBData.Read(bImage, 0, (int)stmBLOBData.Length);
                        if (BeforeData.Rows[0]["picture"] == System.DBNull.Value)
                        {
                            DBManager.getInstance().nonQuery($"INSERT INTO PICTURE (picture, boardID) VALUES(@image,{boardID})", bImage);
                        }
                        else
                        {
                            DBManager.getInstance().nonQuery($"UPDATE PICTURE SET picture=@image", bImage);
                        }
                        stmBLOBData.Close();
                    }
                    else
                    {
                        DBManager.getInstance().nonQuery($"DELETE FROM PICTURE WHERE boardID={boardID}");
                    }
                }
            }
            catch(Exception Event)
            {
                MessageBox.Show(Event.Message);
                return;
            }
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureAttach.Image = null;
            pictureAttach.Tag = "";
            if(stmBLOBData!=null)
            {
                stmBLOBData.Dispose();
                stmBLOBData = null;
            }
        }

        private void buttonAttachPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap Picture = new Bitmap(ofd.FileName);
                Image dest = new Bitmap(Picture, pictureAttach.Width, pictureAttach.Height);
                ImageConverter converter = new ImageConverter();
                stmBLOBData = new MemoryStream((byte[])converter.ConvertTo(Picture, typeof(byte[])));
                pictureAttach.Image = dest;
                pictureAttach.Tag = ofd.FileName;
            }
            else
                return;
        }

        private void FormWriteBoard_Load(object sender, EventArgs e)
        {
            if(modify)
            {
                buttonPost.Text = "수정";
                if (boardID == -1)
                {
                    MessageBox.Show("매개변수에 boardID가 들어가야합니다.");
                    this.Close();
                }
                BeforeData = DBManager.getInstance().Query($"SELECT title, contents, picture, hit FROM BOARD LEFT JOIN PICTURE ON BOARD.boardID=PICTURE.boardID WHERE BOARD.boardID={boardID}");
                
                textBoxTitle.Text = BeforeData.Rows[0]["title"].ToString();
                richTextBoxContents.Text = BeforeData.Rows[0]["contents"].ToString();

                if (BeforeData.Rows[0]["picture"] == System.DBNull.Value)
                {
                    return;
                }
                Byte[] byteBLOBData;
                byteBLOBData = (Byte[])BeforeData.Rows[0]["picture"];
                stmBLOBData = new MemoryStream(byteBLOBData);
                pictureAttach.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureAttach.Image = Image.FromStream(stmBLOBData);
                
                
            }
        }

        private void FormWriteBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(stmBLOBData!=null)
                stmBLOBData.Dispose();
        }
    }
}

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
    public partial class FormStatus : MetroForm
    {
        enum State
        {
            follow,
            unfollow,
            nothing
        }
        State state;
        string ID="";
        public FormStatus(string ID)
        {
            this.ID = ID;
            InitializeComponent();
            DataTable dt = DBManager.getInstance().Query($"SELECT image, userID, Email, region FROM USER LEFT JOIN REGION ON REGION.ID=USER.regionID WHERE userID='{ID}'");

            textBoxID.Text=dt.Rows[0]["userID"].ToString();
            textBoxEmail.Text = dt.Rows[0]["Email"].ToString();
            textBoxRegion.Text = dt.Rows[0]["region"].ToString();
            
            if (dt.Rows[0]["image"] != System.DBNull.Value)
            {
                Byte[] byteBLOBData;
                byteBLOBData = (Byte[])dt.Rows[0]["image"];
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromStream(stmBLOBData);
                stmBLOBData.Close();
                
            }
            dt = DBManager.getInstance().Query($"SELECT state FROM USER LEFT JOIN FOLLOWER ON FOLLOWER.userID=USER.userID WHERE USER.userID='{User.ID}' AND followerID='{ID}'");

            if (dt.Rows[0]["state"] == System.DBNull.Value)
            {
                buttonFollow.Text = "팔로우";
                state = State.nothing;
            }
            else
            {
                if(dt.Rows[0]["state"].ToString()=="1")
                {
                    buttonFollow.Text = "언팔로우";
                    state = State.follow;
                }
                else
                {
                    buttonFollow.Text = "팔로우";
                    state = State.unfollow;
                }
            }

            
        }

        private void buttonFollow_Click(object sender, EventArgs e)
        {
            if(state==State.nothing)
            {
                DBManager.getInstance().nonQuery($"INSERT INTO FOLLOWER (userID, followerID, state) VALUES('{User.ID}','{ID}',1)");
                state = State.follow;
                buttonFollow.Text = "언팔로우";
            }
            else if(state==State.unfollow)
            {
                DBManager.getInstance().nonQuery($"UPDATE FOLLOWER SET state=1 WHERE userID='{User.ID}' AND followerID='{ID}'");
                state = State.follow;
                buttonFollow.Text = "언팔로우";
            }
            else
            {
                DBManager.getInstance().nonQuery($"UPDATE FOLLOWER SET state=0 WHERE userID='{User.ID}' AND followerID='{ID}'");
                state = State.unfollow;
                buttonFollow.Text = "팔로우";
            }
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            FormMessageSend fms = new FormMessageSend(ID);
            fms.Show();

        }
    }
}

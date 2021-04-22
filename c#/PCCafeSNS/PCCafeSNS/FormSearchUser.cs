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
    public partial class FormSearchUser : MetroForm
    {
        
        public FormSearchUser()
        {
            InitializeComponent();
            buttonFollow.Visible = false;
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT userID FROM USER " // 유저 검색
            +"WHERE userID = '{0}'", textBoxUserID.Text);
            DataTable dt = DBManager.getInstance().Query(query);
            DataRow dr = dt.Rows[0];
            labelUserID.Text = dr["userID"].ToString();

            if (labelUserID.Text.Equals("") != true)
            {
                dr = null;
                query = string.Format("SELECT * FROM FOLLOWER"
                    + " WHERE userID = '{0}' AND followerID = '{1}'"
                    , User.ID, labelUserID.Text);
                dr = DBManager.getInstance().rowQuery(query);
                buttonFollow.Visible = true;
                if (dr == null || dr["state"].ToString().Equals("0"))
                {
                    buttonFollow.Text = "UnFollow";
                }
                else if (dr["state"].ToString().Equals("1"))
                    buttonFollow.Text = "Follow";
            }
            else
                MessageBox.Show("해당유저가 존재하지않습니다.");
        }

        private void buttonFollow_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM FOLLOWER WHERE userID = '{0}' AND followerID = '{1}'"
                , User.ID, textBoxUserID.Text);
            
            DataRow dr = DBManager.getInstance().rowQuery(query);
            if (dr == null)
            {
                query = string.Format("INSERT INTO FOLLOWER (userID, followerID, state) VALUES ('{0}', '{1}', '{2}')"
                    , User.ID, labelUserID.Text, 1);

                DBManager.getInstance().nonQuery(query);
                buttonFollow.Text = "Follow";
            }
            else if (buttonFollow.Text.Equals("Follow"))
            {
                query = string.Format("UPDATE FOLLOWER SET state = 0 WHERE userID = '{0}' AND followerID = '{1}'"
                    , User.ID, labelUserID.Text);
                DBManager.getInstance().nonQuery(query);
                buttonFollow.Text = "UnFollow";
            }
            else if (buttonFollow.Text.Equals("UnFollow"))
            {
                query = string.Format("UPDATE FOLLOWER SET state = 1 WHERE userID = '{0}' AND followerID = '{1}'"
                    , User.ID, labelUserID.Text);
                DBManager.getInstance().nonQuery(query);
                buttonFollow.Text = "Follow";
            }
        }
    }
}

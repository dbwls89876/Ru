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
            string query = string.Format("SELECT userID FROM USER " // 유저 아이디를 검색해 유저를 찾는다.
            +"WHERE userID LIKE '%{0}%'", textBoxUserID.Text);
            DataTable dt = DBManager.getInstance().Query(query);

            //데이터가 없거나 빈칸일 경우 등의 예외처리
            try
            {
                DataRow dr = dt.Rows[0];
                labelUserID.Text = dr["userID"].ToString();
                    dr = null;
                    query = string.Format("SELECT * FROM FOLLOWER"  // 팔로우 상태인지 확인한다.
                        + " WHERE userID = '{0}' AND followerID = '{1}'"
                        , User.ID, labelUserID.Text);
                    dr = DBManager.getInstance().rowQuery(query);
                    buttonFollow.Visible = true;
                    if (dr == null || dr["state"].ToString().Equals("0")) // 팔로우 상태라면 버튼의 text가 UnFollow로 설정된다.
                    {
                        buttonFollow.Text = "UnFollow";
                    }
                    else if (dr["state"].ToString().Equals("1")) //비 팔로우 상태라면 버튼의 text가 Follow로 설정된다.
                        buttonFollow.Text = "Follow";

            }catch(Exception ex)
            {
                MessageBox.Show("해당 유저가 존재하지않습니다.");
            }

            
        }

        private void buttonFollow_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM FOLLOWER WHERE userID = '{0}' AND followerID = '{1}'"   // Follow/UnFollow 버튼을 클릭할 시에 팔로워 정보를 가져온다
                , User.ID, textBoxUserID.Text);
            
            DataRow dr = DBManager.getInstance().rowQuery(query);
            if (dr == null)
            {
                query = string.Format("INSERT INTO FOLLOWER (userID, followerID, state) VALUES ('{0}', '{1}', '{2}')" // 팔로워 정보가 없다면 새로운 값이 생성된다.
                    , User.ID, labelUserID.Text, 1);

                DBManager.getInstance().nonQuery(query);
                buttonFollow.Text = "Follow";
            }
            else if (buttonFollow.Text.Equals("Follow"))
            {
                query = string.Format("UPDATE FOLLOWER SET state = 0 WHERE userID = '{0}' AND followerID = '{1}'" // 팔로워 정보가 있으나 비 팔로우 상태라면 팔로우 상태로 변하게 된다.
                    , User.ID, labelUserID.Text);
                DBManager.getInstance().nonQuery(query);
                buttonFollow.Text = "UnFollow";
            }
            else if (buttonFollow.Text.Equals("UnFollow"))
            {
                query = string.Format("UPDATE FOLLOWER SET state = 1 WHERE userID = '{0}' AND followerID = '{1}'" // 팔로워 정보가 있으며 팔로우 상태일 때 비 팔로우 상태로 변하게 된다.
                    , User.ID, labelUserID.Text);
                DBManager.getInstance().nonQuery(query);
                buttonFollow.Text = "Follow";
            }
        }
    }
}

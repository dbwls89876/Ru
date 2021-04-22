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
    public partial class FormUserInfo : MetroForm
    {
        
        public FormUserInfo()
        {
            InitializeComponent();
            if (User.image != null)
                pictureBoxUserImage.Image = User.image;
            
            string query = string.Format("SELECT userID FROM FOLLOWER WHERE followerID = '{0}' AND state = 1", User.ID);
            DataTable dt = DBManager.getInstance().Query(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {

                    string str = string.Format("{0}", row["userID"]);
                    listBoxFollow.Items.Add(str);
                }
            }
            dt = null;
            query = string.Format("SELECT userID FROM FOLLOWER WHERE followerID = '{0}' AND state = 0", User.ID);
            dt = DBManager.getInstance().Query(query);
            if (dt != null)
            {                
                foreach (DataRow row in dt.Rows)
                {
                    string str = string.Format("{0}", row["userID"]);
                    listBoxUnFollow.Items.Add(str);
                }
            }

            dt = null;
            query = string.Format("SELECT followerID FROM FOLLOWER WHERE userID = '{0}' AND state = 1", User.ID);
            dt = DBManager.getInstance().Query(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string str = string.Format("{0}", row["followerID"]);
                    listBoxUserFollow.Items.Add(str);
                }
            }

        }

        private void updateImage()
        {
            pictureBoxUserImage.Image = User.image;
            pictureBoxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonUnFollow_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE FOLLOWER SET state = 0 WHERE userID = '{0}' AND followerID = '{1}'"
                    , User.ID, listBoxUserFollow.SelectedItem.ToString());
            DBManager.getInstance().nonQuery(query);
            listBoxUserFollow.Items.RemoveAt(listBoxUserFollow.SelectedIndex);
        }

        private void buttonUserUpdate_Click(object sender, EventArgs e)
        {
            buttonUserUpdate.Enabled = false;
            FormUserUpdate fuu = new FormUserUpdate(this);
            fuu.Show();
            fuu.FormClosing += delegate (object S, FormClosingEventArgs E)
              {
                  buttonUserUpdate.Enabled = true;
                  updateImage();
              };
        }


        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            updateImage();
        }
    }
}

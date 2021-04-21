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
    public partial class FormUserUpdate : Form
    {
        FormUserInfo fui;
        Bitmap Picture=null;
        public FormUserUpdate(FormUserInfo _fui)
        {
            InitializeComponent();
            fui = _fui;
            textBoxEmail.Text = User.Email;
            textBoxRegion.Text = User.region;
            pictureBoxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUserImage.Image = User.image;
            
        }

        private void buttonImageLoad_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Picture = new Bitmap(FD.FileName);
                Image dest = new Bitmap(Picture,pictureBoxUserImage.Width,pictureBoxUserImage.Height);
                
                pictureBoxUserImage.Image = dest;
                
            }
        }

        private void buttonUserUpdate_Click(object sender, EventArgs e)
        {
            if (User.password.Equals(textBoxPassword.Text))
            {

                ImageConverter converter = new ImageConverter();
                MemoryStream stmBLOBData = new MemoryStream((byte[])converter.ConvertTo(Picture, typeof(byte[])));
                byte[] binaryImage = new byte[stmBLOBData.Length];
                stmBLOBData.Read(binaryImage, 0, (int)stmBLOBData.Length);

                string query = string.Format("UPDATE USER SET password = '{0}', Email = '{1}', regionID = '{2}', image = @image"
                    +" WHERE userID = '{3}'", textBoxPassword.Text, textBoxEmail.Text
                    , textBoxRegion.Text, User.ID);
                
                DBManager.getInstance().nonQuery(query,binaryImage);
                User.image = Picture;
                MessageBox.Show("수정완료");

                Close();
            }
            else
                MessageBox.Show("비밀번호가 틀렸습니다.");
        }

        private void pictureBoxUserImage_Click(object sender, EventArgs e)
        {
            pictureBoxUserImage.Image = null;
        }
    }
}

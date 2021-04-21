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
    public partial class FormLogin : MetroForm
    {
        User user;
        FormMain fm;
        public FormLogin()
        {
            InitializeComponent();
            user = new User();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Equals("")|| textBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("아이디나 패스워드를 입력하지 않으셨습니다.");
            }
            else{
                int login = user.login(textBoxID.Text, textBoxPassword.Text); // 1이 리턴될때 로그인, 0 리턴시 x
                if (login == 1)
                {
                    fm = new FormMain(textBoxID.Text);
                    fm.Show();
                    this.Visible = false;
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister fr = new FormRegister();
            fr.Show();
        }
    }
}

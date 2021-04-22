using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class LoginForm : Form
    {
        Login login;

        

        public LoginForm()
        {
            InitializeComponent();

            login = new Login();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            login.loginCheck(textBoxID.Text, textBoxPassword.Text);
            
            
            this.Visible = false;
            
            Form1 form = new Form1(login.loginID, textBoxID.Text);
            
            
            form.Owner = this;
            form.Show();
            
        }
    }
}

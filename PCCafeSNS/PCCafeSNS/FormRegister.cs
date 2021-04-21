using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCafeSNS
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO USER (userID, Email, password, regionID) VALUES ('{0}', '{1}', '{2}', '{3}')"
                ,textBoxID.Text, textBoxRegion.Text, textBoxPassword.Text, textBoxEmail.Text);
            DBManager.getInstance().nonQuery(query);
            MessageBox.Show("가입되었습니다.");
            Close();
        }
    }
}

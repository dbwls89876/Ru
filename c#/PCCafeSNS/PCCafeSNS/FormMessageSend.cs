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
    public partial class FormMessageSend : MetroForm
    {
        string ID;
        public FormMessageSend(string ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DBManager.getInstance().nonQuery($"INSERT INTO MESSAGE (senderID, receiverID, content, sendTime) VALUES('{User.ID}','{ID}','{richTextBox1.Text}','{time}')");
            MessageBox.Show("전송완료.");
            this.Close();
        }
    }
}

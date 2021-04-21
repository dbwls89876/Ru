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
    public partial class FormGroupBoardWrite : Form
    {
        public FormGroupBoardWrite()
        {
            InitializeComponent();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            //그룹 글쓰기
            string user = User.ID;
            string title = textBoxTitle.Text;
            string content = textBoxContent.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string groupname = FormGroupmain.Selectedgroupname;
            int hit = 0;

            string query = $"INSERT INTO BOARD(title,contents,writtenDate,userID,clubID,hit) values('{title}','{content}','{date}','{user}','{groupname}',{hit})";
            DBManager.getInstance().nonQuery(query);

        }
    }
}

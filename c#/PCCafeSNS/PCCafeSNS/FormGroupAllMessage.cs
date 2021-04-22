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
    public partial class FormGroupAllMessage : MetroForm
    {
        public FormGroupAllMessage()
        {
            InitializeComponent();
        }

        private void buttonSendGroupMessage_Click(object sender, EventArgs e)
        {
            //그룹 회원 모두에게 그룹 장이 메시지 보내기.

            string senderID = User.ID;
            string receiverID = "";
            string content = textBoxGroupMessageContent.Text;

            //그룹회원들의 정보를 가져오는 쿼리.
            string query = $"SELECT * FROM sys.GROUPSTATE WHERE groupNAME = (SELECT groupNAME FROM GROUPLIST WHERE groupMANAGER = '{senderID}')";

            DataTable groupMemberlist = DBManager.getInstance().Query(query);

            foreach(DataRow row in groupMemberlist.Rows)
            {
               //각 그룹 회원별로 그룹 장의 메시지를 전달.
                receiverID = row["userID"].ToString();
                //그룹장 자기자신을 제외.
                if (!(receiverID == senderID))
                {
                    //그룹장이 그룹 회원에게 메시지를 보내는 쿼리.
                    string messagequery = $"INSERT INTO MESSAGE(senderID,recieverID,content) values('{senderID}','{receiverID}','{content}')";
                    DBManager.getInstance().nonQuery(messagequery);
                }
            }
            MessageBox.Show("모든 그룹 회원들에게 메시지 전송 완료!!");
            this.Close();
        }
    }
}

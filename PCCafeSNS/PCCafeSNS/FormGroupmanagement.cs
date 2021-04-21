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
    //그룹장의 그룹 관리 페이지
    public partial class FormGroupmanagement : Form
    {
        public FormGroupmanagement()
        {
            InitializeComponent();
            init();
        }
        //초기화 함수
        public void init()
        {
           
            //그룹에서 내 그룹 텍스트 처리
            string Mygroupnamequery = $"SELECT groupNAME FROM GROUPLIST WHERE groupMANAGER = '{User.ID}'";
            string name = DBManager.getInstance().stringValue(Mygroupnamequery);
            textBoxMygroupname.Text = name;

        }
        //그룹장의 그룹삭제 버튼
        private void buttonGroupdelete_Click(object sender, EventArgs e)
        {
            
            //userID에 맞는 그룹 정보를 디비에서 삭제
           
            string query = $"DELETE FROM GROUPLIST WHERE groupMANAGER = '{User.ID}'";
            DBManager.getInstance().nonQuery(query);

        }

        private void buttonGroupmanagersecession_Click(object sender, EventArgs e)
        {
            //그룹장이 탈퇴하는 경우이고 그룹 장 권한을 다른 사람에게 위임
            //그룹 장 권한 위임페이지로 이동
            FormGroupmanagersecession groupmanagersecession = new FormGroupmanagersecession();
            groupmanagersecession.ShowDialog();
        }

        private void buttonGroupmessageall_Click(object sender, EventArgs e)
        {
            //그룹원 모두에게 단체 메시지를 보낸는 폼으로 이동.
            FormGroupAllMessage groupAllMessage = new FormGroupAllMessage();
            groupAllMessage.ShowDialog();
            


        }
    }
}

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
    public partial class FormGroupCreate : MetroForm
    {
        public FormGroupCreate()
        {
            InitializeComponent();
        }
        

        private void buttonCreateGroup_Click(object sender, EventArgs e)
        {
            
            //그룹 생성하는 코드(CLUBLIST 테이블에 clubNAME,clubCATEGORY 등록)
            string groupname = textBoxGroupName.Text;
            string groupcategory = textBoxCategory.Text;

            //그룹 명단에 생성 그룹 삽입
            string query = $"INSERT INTO GROUPLIST(groupNAME,groupCATEGORY,groupMANAGER) values('{groupname}','{groupcategory}','{User.ID}')";
            DBManager.getInstance().nonQuery(query);

            //그룹 가입현황에 그룹장 내용이랑 넣기
            string query2 = $"INSERT INTO GROUPSTATE(groupNAME,userID,level) values('{groupname}','{User.ID}','manager')";
            DBManager.getInstance().nonQuery(query2);
            MessageBox.Show($"그룹명 '{groupname}' 카테고리 '{groupcategory}' 생성완료! ");
            this.Close();




        }
    }
}

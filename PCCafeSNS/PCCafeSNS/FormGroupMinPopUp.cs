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
    public partial class FormGroupMinPopUp : Form
    {
        public FormGroupMinPopUp()
        {
            InitializeComponent();
            init();
        }
        //현재 그룹의 이름, 선택된 회원 아이디
        string groupname = FormGroupmain.Selectedgroupname;
        string userid = FormPrivategrouppage.Selecteduserid;
        
        public void init()
        {   //선택된 유저의 이름
            textBoxUserName.Text = userid;
            //선택된 유저의 등급
            string Levelquery = $"SELECT level FROM GROUPSTATE WHERE groupNAME = groupname AND userID = '{userid}' ";
            //해당 유저의 레벨을 가져오는 것인데 만약 유저의 레벨이 널이면 에러 가능성 있음.
            string userlevel = DBManager.getInstance().stringValue(Levelquery);
            textBoxMebershipLevel.Text = userlevel;
            

        }

        //해당 회원의 등급을 조절하는 버튼 입니다. (그룹의 회원등급은 1 일반유저, 2스텝이 있습니다.)
        private void buttonMemberShipLevel_Click(object sender, EventArgs e)
        {
            //변화된 등급
            string Changedlevel = textBoxMebershipLevel.Text;

            //해당 그룹 해당 유저의 등급을 변화 시키는 것을 실행
            string query = $"UPDATE GROUPSTATE SET level = '{Changedlevel}' WHERE userID = '{userid}' AND groupNAME = '{groupname}'";
            DBManager.getInstance().nonQuery(query);
            MessageBox.Show($"'{userid}'회원의 등급을 '{Changedlevel}'으로 조절하였습니다.");
            

        }
    }
}

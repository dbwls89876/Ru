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
{//모든 유저는 1개의 그룹을 소유하거나 가입을 할 수 있다. 즉 1인 1그룹이다. 그룹 장이면 다른 그룹에 가입 x, 그룹원이면 다른 그룹 소유 x.
    //그룹 장이면 탈퇴하기 버튼, 가입하기 버튼이 안 보이고 그룹원이면 가입하기 버튼이 안 보인다.
    public partial class FormPrivategrouppage : MetroForm
    {
        public FormPrivategrouppage()
        {
            InitializeComponent();
            init();
        }
        
        //현재 해당 그룹의 이름
        string groupname = FormGroupmain.Selectedgroupname;

        //선택된 그룹 회원의 userID
        public static string Selecteduserid = "";

        public void init()
        {

            //현재 해당 그룹의 이름 텍스트 처리
            textBoxGroupname.Text = groupname;
           
            //해당 그룹의 회원 리스트 불러오기
            string query = $"SELECT groupNAME AS 그룹명,userID AS 회원명 FROM GROUPSTATE WHERE groupNAME = '{groupname}'";
            DataTable groupuserlist = DBManager.getInstance().Query(query);
            dataGridViewGroupuserlist.DataSource = groupuserlist;

            //그룹 회원이 아닌 사람은 게시판이랑 탈퇴 버튼 안 보이게 한다
            buttonGoGroupBoard.Hide();
            buttonSecession.Hide();

            //그룹에 소속된 사람들의 아이디와 등급을 가져오는 쿼리.
            string query2 = $"SELECT userID,level FROM GROUPSTATE WHERE groupNAME = '{groupname}' AND userID = '{User.ID}'";
            DataTable list = DBManager.getInstance().Query(query2);

            //해당 유저가 현재 유저가 그룹의 가입 중이거나 소유 중이면 가입 버튼 숨긴다.
            foreach (DataRow row in list.Rows)
            {
                buttonGroupjoin.Hide();
                
                buttonSecession.Show();
                if (User.ID == row["userID"].ToString()&& row["level"].ToString()!="1")// 그룹장이거나 그룹 회원이면 가입 버튼이 보이게 합니다.
                {
                    buttonGoGroupBoard.Show();
                    if (row["level"].ToString()=="manager")//그룹장의 경우 탈퇴는 숨긴다. 그룹 장의 탈퇴는 메인에서 그룹 관리에 가능합니다.
                    {
                        buttonSecession.Hide();
                       
                    }
                    
                }
            }
            
        }

        private void FormPrivategrouppage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGroupjoin_Click(object sender, EventArgs e)
        {

            //가입하기
            string query = $"INSERT INTO GROUPSTATE(groupNAME,userID,level) values('{groupname}','{User.ID}','1')";
            DBManager.getInstance().nonQuery(query);
            init();
        }

        private void buttonSearchgroupuser_Click(object sender, EventArgs e)
        {
            //현재 해당 그룹의 회원 검색하기
            string word = textBoxSearchgroupuser.Text;
            string query = $"SELECT groupNAME AS 그룹명,userID AS 회원명 FROM GROUPSTATE WHERE groupNAME = '{groupname}' AND userID = '{word}'";
            DataTable groupuserlist = DBManager.getInstance().Query(query);

            dataGridViewGroupuserlist.DataSource = groupuserlist;

        }

        private void buttonPrivategroupUserlistRefresh_Click(object sender, EventArgs e)
        {
            //현재 해당 그룹의 회원 목록 새로고침

            string query = $"SELECT groupNAME AS 그룹명,userID AS 회원명 FROM GROUPSTATE WHERE groupNAME = '{groupname}'";
            DataTable groupuserlist = DBManager.getInstance().Query(query);
            dataGridViewGroupuserlist.DataSource = groupuserlist;

        }

        //그룹원의 그룹 탈퇴하기 버튼(그룹장은 그룹관리 메뉴에서 가능)
        private void buttonSecession_Click(object sender, EventArgs e)
        {
            //GROUPSTATE에서 자신의 가입 기록을 삭제한다.
        
            string query = $"DELETE FROM GROUPSTATE WHERE userID = '{User.ID}'";
            DBManager.getInstance().nonQuery(query);
            init();
        }

        //선택된 셀의 위치를 나타내는 좌표.
        int row = 0;
        int column = 0;
        //회원 선택 버튼
        private void dataGridViewGroupuserlist_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //현재 해당 그룹의 유저의 등급을 가져오는 쿼리,
            string query = $"SELECT level FROM GROUPSTATE WHERE groupNAME = '{groupname}' AND userID = '{User.ID}'";
            //level이 널이면 오류가 날 가능성 있음!!
            string userlevel = DBManager.getInstance().stringValue(query);

            //선택된 셀의 위치를 저장.
            row = e.RowIndex;
            //이름만 선택 가능하도록 한정.
            column = 1;

            //그룹장만 회원등급 설정 가능.
            if (userlevel == "manager")
            {
                if (column == 1)
                {
                    //선택된 userID를 가져와서 저장
                    Selecteduserid = dataGridViewGroupuserlist.Rows[row].Cells[column].Value.ToString();
                    FormGroupMinPopUp formGroupMinPopUp = new FormGroupMinPopUp();
                    formGroupMinPopUp.ShowDialog();


                }
                else
                {
                    Selecteduserid = "";
                }
            }

        }

        private void buttonGoGroupBoard_Click(object sender, EventArgs e)
        {
            //그룹 게시판으로 이동
            //FormGroupBoard formGroupBoard = new FormGroupBoard();
            //formGroupBoard.ShowDialog();

             FormBoard fb = new FormBoard(groupname);
            fb.Show();
            buttonGoGroupBoard.Enabled = false;
            fb.FormClosing += delegate (object s, FormClosingEventArgs E)
              {
                  if(buttonGoGroupBoard!=null)
                      buttonGoGroupBoard.Enabled = true;
              };
            
        }
    }
}

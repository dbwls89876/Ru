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
{//모든 유저는 1개의 그룹을 소유하거나 가입을 할 수 있다. 즉 1인 1그룹이다. 그룹 장이면 다른 그룹에 가입 x, 그룹원이면 다른 그룹 소유 x.
    public partial class FormGroupmain : Form
    {
        //그룹장인지 확인
        string Is_groupmanager = "false";
        string Is_groupmemeber = "false";

        public FormGroupmain()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            //그룹에서 내 그룹 텍스트 처리

            string Mygroupnamequery = $"SELECT * FROM GROUPLIST WHERE groupMANAGER = '{User.ID}'";
            DataTable dt = DBManager.getInstance().Query(Mygroupnamequery);
            //현재 유저가 보유한 그룹이 있다면 내 그룹 명에 표시
            foreach (DataRow row in dt.Rows)
            {
                if (row["groupMANAGER"].ToString() == User.ID)
                {
                    string name = row["groupNAME"].ToString();
                    textBoxMyGroupname.Text = name;
                }
                else
                {
                    textBoxMyGroupname.Text = "";
                }
            }
            

            

            //그룹 메인화면에 그룹 리스트 불러오기
            string query = "SELECT ID AS 번호, groupNAME AS 그룹명, groupCATEGORY AS 카테고리, groupMANAGER AS 그룹장 FROM GROUPLIST";
            DataTable grouplist = DBManager.getInstance().Query(query);

            dataGridViewGrouplist.DataSource = grouplist;

           

           
            
        }
        private void buttonGroupCreate_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT * FROM GROUPSTATE";
            DataTable dt = DBManager.getInstance().Query(query2);

            //그룹장이 아닌 그룹원이면
            foreach(DataRow row in dt.Rows )
            {

                if(row["userID"].ToString()==User.ID && !(row["level"].ToString()=="manager"))
                {
                    Is_groupmemeber = "true";
                }
            }


            //그룹장인지 확인
            string query = "SELECT * FROM GROUPLIST";
            DataTable grouplist = DBManager.getInstance().Query(query);
            foreach(DataRow row in grouplist.Rows)
            {
                if(row["groupMANAGER"].ToString()==User.ID)
                {
                    Is_groupmanager = "true";
                }
            }

            //그룹 생성하기
            if (Is_groupmanager == "false")
            {
                if (Is_groupmemeber == "false")
                {
                    FormGroupCreate groupcreateform = new FormGroupCreate();
                    groupcreateform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("이미 소속된 그룹이 있습니다.");
                }
            }
            else
            {
                MessageBox.Show("이미 그룹을 소유 중 입니다.");
            }
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

      
        //그룹장의 그룹 관리하기
        private void 그룹관리ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //그룹 장인지 확인
            string query = "SELECT * FROM GROUPLIST";
            DataTable grouplist = DBManager.getInstance().Query(query);
            foreach (DataRow row in grouplist.Rows)
            {
                if (row["groupMANAGER"].ToString() == User.ID)
                {
                    Is_groupmanager = "true";
                }
            }

            if (Is_groupmanager == "true")
            {
                FormGroupmanagement groupmanagementform = new FormGroupmanagement();
                groupmanagementform.ShowDialog();
            }
            else
            {
                MessageBox.Show("그룹장만 이용 가능합니다.");
            }
        }

        //그룹 검색 버튼 구현
        private void buttonGroupSearch_Click(object sender, EventArgs e)
        {
            string word = textBoxGroupSearchKeword.Text;
            

            string query = $"SELECT ID AS 번호, groupNAME AS 그룹명, groupCATEGORY AS 카테고리, groupMANAGER AS 그룹장 " +
                $"FROM GROUPLIST WHERE groupNAME = '{word}' OR groupCATEGORY = '{word}' OR groupMANAGER = '{word}'";
            DataTable grouplist = DBManager.getInstance().Query(query);

            dataGridViewGrouplist.DataSource = grouplist;
        
            
            

        }

        //grouplist 새로고침 버튼
        private void buttonRfreshgrouplist_Click(object sender, EventArgs e)
        {
            init();
        }

        int row=0;
        int column=0;
        public static string Selectedgroupname = "";
        //grouplist의 내용을 더블 클릭하면 그 해당 그룹 페이지로 이동
        private void dataGridViewGrouplist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            column = e.ColumnIndex;
            
            //그룹명을 입력한 경우에만 이동.
            if (column == 1)
            {
                Selectedgroupname = dataGridViewGrouplist.Rows[row].Cells[column].Value.ToString();
                FormPrivategrouppage privategrouppage = new FormPrivategrouppage();
                privategrouppage.ShowDialog();
            }
            else
            {
                Selectedgroupname = "";
            }
        }

        
    }
}

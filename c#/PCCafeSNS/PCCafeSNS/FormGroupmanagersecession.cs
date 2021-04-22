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
    public partial class FormGroupmanagersecession : MetroForm
    {
        public FormGroupmanagersecession()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            MessageBox.Show($"'{User.ID}'님 그룹장 권한을 원하는 회원님의 userID를 더블 클릭해서 선택하세요");
            string query = $"SELECT groupNAME FROM GROUPLIST WHERE groupMANAGER = '{User.ID}'";
            string groupname = DBManager.getInstance().stringValue(query);



            //해당 그룹장 소유의 그룹의 그룹장을 넘겨 줄 회원리스트
            string query2 = $"SELECT * FROM GROUPSTATE WHERE groupNAME = '{groupname}'";
            DataTable dt = DBManager.getInstance().Query(query2);
            dataGridViewUserlist.DataSource = dt;
            
        }
        
        int row = 0;
        int column = 0;
        string Nextmanageruserid = "";
        int Is_okay = 1;
        //권한을 부여 할 유저의 userID선택 더블클릭!
        private void dataGridViewUserlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           row = e.RowIndex;
           column = e.ColumnIndex;

            //유저의 아이디 부분만 선택 되도록 설정하였습니다., 선택된 유저가 이미 다른 그룹장이면 위임 불가.
            string query = "SELECT * FROM GROUPLIST";
            DataTable grouplistTable = DBManager.getInstance().Query(query);

            
            if (column == 2)
            {
                Nextmanageruserid = dataGridViewUserlist.Rows[row].Cells[column].Value.ToString();

                foreach (DataRow row in grouplistTable.Rows)
                {
                    //이미 그룹장이면..
                    if (row["groupMANAGER"].ToString() == Nextmanageruserid)
                    {
                        Is_okay = 0;

                    }

                 }
                //이미 그룹장이 아니라면

                if (Is_okay==1)
                {
                    MessageBox.Show(Nextmanageruserid + "님에게 권한을 부여하시려면 아래 버튼을 눌러주세요.");

                }
                
            }
            else
            {
                Nextmanageruserid = "";
                MessageBox.Show("이미 그룹을 소유한 사람입니다.");
            }
            
       }

       private void buttonSecession_Click(object sender, EventArgs e)
       {

            //현재 그룹의 이름
            string query = $"SELECT groupNAME FROM GROUPLIST WHERE groupMANAGER = '{User.ID}'";
            string groupname = DBManager.getInstance().stringValue(query);

            //해당 유저의 userid를 GROUPLIST groupMANAGER에 업데이트해준다.
            string query2 = $"UPDATE GROUPLIST SET groupMANAGER = '{Nextmanageruserid}' WHERE groupNAME = '{groupname}'";
            DBManager.getInstance().nonQuery(query2);
            
            //GROUPSTATE에서 현재 그룹장의 데이터 지움-> 탈퇴 처리.
            string deletequery = $"DELETE FROM GROUPSTATE WHERE userID = '{User.ID}'";
            DBManager.getInstance().nonQuery(deletequery);

            //GROUPSTATE에서 새로운 그룹장의 권한을(level) manager로 승격
            string updatequery = $"UPDATE GROUPSTATE SET level = 'manager' WHERE userID = '{Nextmanageruserid}' AND groupNAME = '{groupname}'";
            DBManager.getInstance().nonQuery(updatequery);


            MessageBox.Show("그룹 장의 권한이 넘겨졌습니다.");

            this.Close();
            
             
        }

       
    }
}

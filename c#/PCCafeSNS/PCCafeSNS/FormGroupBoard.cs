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
    public partial class FormGroupBoard : MetroForm
    {
        public static string SelectedTitle = "";
        string groupname = FormGroupmain.Selectedgroupname;
        public FormGroupBoard()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            //그룹 이름
            textBoxGroupName.Text = groupname;
            string Boardquery = $"SELECT title AS 제목,writtenDate AS 시간,userID AS 글쓴이 FROM BOARD WHERE clubID = '{groupname}'";
            DataTable dt = DBManager.getInstance().Query(Boardquery);
            dataGridViewGroupBoard.DataSource = dt;

            buttonWrite.Hide();

            //그룹에서 스텝 이상의 회원만이 그룹 글쓰기 가능
            string query = $"SELECT userID FROM GROUPSTATE WHERE groupNAME = '{groupname}' AND ((level = '2') OR (level = 'manager'))";
            DataTable userlist = DBManager.getInstance().Query(query);

            foreach(DataRow row in userlist.Rows)
            {
                if(row["userID"].ToString()==User.ID)
                {
                    buttonWrite.Show();
                }
            }

        }

     
        //그룹 글쓰기 이동
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            FormGroupBoardWrite formGroupBoardWrite = new FormGroupBoardWrite();
            formGroupBoardWrite.ShowDialog();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            init();
        }

        int row = 0;
        int column = 0;

        //글 선택
        private void dataGridViewGroupBoard_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = e.RowIndex;

            if(column ==0)
            {
                //제목 더블 클릭하면 글 화면으로 이동.(글 읽기와 수정 그리고 삭제가 가능)

                SelectedTitle = dataGridViewGroupBoard.Rows[row].Cells[column].Value.ToString();


            }
            else
            {
                SelectedTitle = "";
            }

        }
    }
}

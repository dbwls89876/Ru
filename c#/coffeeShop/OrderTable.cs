using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class OrderTable : Form
    {
        Form1 form;
        DataTable dt;
        List<string> time;

        public OrderTable(Form1 _form)
        {
            InitializeComponent();
            form = _form;
            timeAdd();
            time = new List<string>();

            string query = "SELECT * FROM Coffee";
            dt = DBManager.getInstance().select(query);
            foreach (DataRow row in dt.Rows)
            {
                string str = string.Format("{0}", row["coffee"]);

                comboBoxCoffee.Items.Add(str);

            }

            

        }

        private void timeAdd()
        {
            for(int i = 0; i<=23; i++)
                listBoxTime.Items.Add(i);

        }

        private void loadDB()
        {
            
            string query = string.Format("SELECT Orders.id, Coffee.coffee, Orders.date "
            + "FROM Orders Left jOIN Coffee ON Coffee.cid = Orders.cid"
            + " WHERE date_format(Orders.date, '%HH') = {0}", listBoxTime.SelectedIndex);

            dt = DBManager.getInstance().select(query);
            dataGridViewOrder.DataSource = dt;
        }

        private void listBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDB();

           /* string nowDate = null;
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                DateTime date = Convert.ToDateTime(dt.Rows[i]["date"]);
                
                if (listBoxTime.SelectedIndex < 9)
                {
                    nowDate = dateTimePicker1.Value.ToString("yyyy-MM-dd" +"-0" + (listBoxTime.SelectedIndex+1).ToString());
                    
                }
                else
                {
                    nowDate = dateTimePicker1.Value.ToString("yyyy-MM-dd" +"-"+ (listBoxTime.SelectedIndex).ToString());
                }
                
                if (nowDate.Equals(date.ToString("yyyy-MM-dd-HH"))){
                    
                    MessageBox.Show(date.ToString(nowDate));
                    DataRow dr = dt.Rows[i];
                    DataSet ds;
                    
                    dataGridViewOrder.DataSource = ds.Tables[i];
                    string order = string.Format("{0} {1} {2}", dr["id"], dr["Coffee"], dr["date"]);
                    listBoxOrders.Items.Add(order);
                }
            }*/
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
           /* foreach (DataRow row in dt.Rows)
            {
                string strTime = string.Format("{0}", row["date"]);
                time.Add(strTime);
            }*/

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           string query = string.Format("DELETE FROM Orders WHERE id = {0}", // 지우기
               dataGridViewOrder.Rows[dataGridViewOrder.CurrentCell.RowIndex].Cells[0].Value.ToString());
            DBManager.getInstance().insert(query);
            MessageBox.Show("삭제되었습니다");
            loadDB();


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE Orders SET cid = {0} WHERE id = {1}",comboBoxCoffee.SelectedIndex+1 , dataGridViewOrder.Rows[dataGridViewOrder.CurrentCell.RowIndex].Cells[0].Value.ToString());
            DBManager.getInstance().insert(query);
            loadDB();
        }
    }
}

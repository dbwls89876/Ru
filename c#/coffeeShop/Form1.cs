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
    public partial class Form1 : Form
    {
        public Coffee coffee;
        public int loginID;
        public string name;
        string time;
        public List<Button> buttonGroup = new List<Button>();
        public int num_buttons;


        public Form1(int id, string name)
        {
            InitializeComponent();

            num_buttons = 0;
            loginID = id;
            this.name = name;
            time = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            coffee = new Coffee();
            
            menuStripAdmin.Visible = false;

            if(loginID == 1)
            {
                adminView();
                
            }

            if (loginID != -1)
            {
                
                if (loginID == 1)
                {
                    labelLoginState.Text = "관리자님 로그인 되었습니다.";
                    adminView();
                }
                else
                {
                    labelLoginState.Text = "사용자님 로그인 되었습니다.";
                }
            }

            buttonSetting();
            
        }

        private void buttonSetting()
        {


            for (int i = 0; i<coffee.coffee.Count(); i++)
            {
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(30+(num_buttons * 100), 50);
                btn.Name = "button"+coffee.coffee[i];
                btn.Size = new System.Drawing.Size(75, 25);
                btn.TabIndex = 1;
                btn.Text = coffee.coffee[i];
                btn.UseVisualStyleBackColor = true;
                btn.Click += new System.EventHandler(this.button_Coffee_Click);
                btn.Parent = this;
                btn.Tag = num_buttons;
                num_buttons++;
                groupBox1.Controls.Add(btn);
                buttonGroup.Add(btn);
            }
            
        }
        
        public void button_Coffee_Click(object sender, EventArgs e)
        {
            Button thisBtn = (Button)sender;

            if (loginID >= 0)
            {   
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd-HH-mm-ss");
                string str = string.Format("INSERT INTO Orders (date, uid, cid ) VALUES('{0}', {1}, {2})",date , loginID, Convert.ToInt32(thisBtn.Tag)+1);
                DBManager.getInstance().insert(str);
            }


        }


        private void adminView()
        {

            menuStripAdmin.Visible = true;

            string str = "SELECT Orders.date, User.name, sum(Coffee.price) AS 총판매액, count(Orders.uid) as 총판매량 FROM Orders"
            + " Left jOIN Coffee ON Coffee.cid = Orders.cid"
            +" Left JOIN User On User.uid = Orders.uid"
            +" group by Orders.uid, Orders.date";

            DataTable user = DBManager.getInstance().select(str);
            dataGridViewUserSale.DataSource = user;

            str = "SELECT Orders.date, Coffee.coffee, sum(Coffee.price) AS 총판매액, count(Orders.uid) as 총판매량 FROM Orders"
            + " Left jOIN Coffee ON Coffee.cid = Orders.cid"
            + " Left JOIN User On User.uid = Orders.uid"
            + " group by Orders.cid, Orders.date";

            DataTable coffeeDaily = DBManager.getInstance().select(str);
            dataGridViewCoffeeDailySale.DataSource = coffeeDaily;

            str = "SELECT date_format(date, '%m') as 월, Coffee.coffee, sum(Coffee.price) AS 총판매액, count(Orders.uid) as 총판매량 FROM Orders"
            + " Left jOIN Coffee ON Coffee.cid = Orders.cid"
            + " Left JOIN User On User.uid = Orders.uid"
            + " group by Orders.cid, date_format(date, '%m')";

            DataTable coffeeMonth = DBManager.getInstance().select(str);
            dataGridViewCoffeeMonthSale.DataSource = coffeeMonth;

        }

        


        private void buttonLoguot_Click(object sender, EventArgs e)
        {
            loginID = -1;
            
            labelLoginState.Text = "";
            this.Visible = false;

            string str = string.Format("INSERT INTO UserLog (name, login, logout) VALUES ('{0}', '{1}', '{2}')", name, time ,DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
            DBManager.getInstance().insert(str);

            LoginForm lf = new LoginForm();
            lf.Visible = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "SELECT name, login FROM UserLog";
            DataTable dt = DBManager.getInstance().select(str);
            

            LogGridView lgv = new LogGridView(dt);
            lgv.Show();
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "SELECT name, logout FROM UserLog";
            DataTable dt = DBManager.getInstance().select(str);
            LogGridView lgv = new LogGridView(dt);
            lgv.Show();

        }

        private void 메뉴수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoffeeUpdate cu = new CoffeeUpdate(this);
            cu.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ButtonAdds ba = new ButtonAdds(this);
            ba.Show();
        }

        private void 저널조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OrderTable ot = new OrderTable(this);
            ot.Show();
        }
    }

    public class Coffee
    {
        public List<string> coffee;
        
        public Coffee()
        {
            coffee = new List<string>();
            string str = "SELECT * FROM Coffee";
            
            DataTable dt1 = DBManager.getInstance().select(str);
            foreach (DataRow row in dt1.Rows)
            {
                string str1 = string.Format("{0}", row["coffee"]);

                coffee.Add(str1);
                
            }
        }

    }

}

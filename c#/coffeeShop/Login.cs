using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    class Login
    {
        public List<string> name;
        public List<string> password;
        public List<string> uid;
        public int loginID;

        public Login()
        {
            name = new List<string>();
            password = new List<string>();
            uid = new List<string>();

            string str = "SELECT * FROM User";

            DataTable dt1 = DBManager.getInstance().select(str);
            foreach (DataRow row in dt1.Rows)
            {

                string str1 = string.Format("{0}", row["name"]);
                string str2 = string.Format("{0}", row["password"]);
                string str3 = string.Format("{0}", row["uid"]);
                name.Add(str1);
                password.Add(str2);
                uid.Add(str3);
            }
            loginID = -1;
        }

        public void loginCheck(string name, string pw)
        {

            for (int i = 0; i < uid.Count(); i++)
            {

                if (this.name[i].Equals(name) && this.password[i].Equals(pw))
                {
                    loginID = Convert.ToInt32(uid[i]);
                    
                }
            }

            if (loginID == -1)
                MessageBox.Show("로그인을 실패하였습니다");
        }

    }
}

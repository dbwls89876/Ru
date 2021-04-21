using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCafeSNS
{
    class DBManager
    {
        private static DBManager instance_ = new DBManager();
        private DBManager() { }
        public static DBManager getInstance() { return instance_; }
        string strConn = "Server=127.0.0.1;Port=3306; Database=pccafesns;Uid=root;Pwd=8246;Charset=utf8";
        public void nonQuery(string query, byte[] Image=null)
        {

            if(Image==null)
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    if(!query.Contains("@image"))
                    {
                        MessageBox.Show("이미지 파라미터가 잘못 되었습니다. 이미지 넣는 곳에 @image로 해주세요.");
                        return;
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@image", Image);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        

        public DataTable Query(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();

                return dt;
            }
        }

        public DataRow rowQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                DataRow dr;
                try
                {
                    dr = dt.Rows[0];
                }
                catch(Exception e)
                {
                    dr = null;
                }
                rdr.Close();

                return dr;
            }
        }

        public string stringValue(string query)
        {
            string stringresult = "";
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(strConn))
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                stringresult = cmd.ExecuteScalar().ToString();
                //ExecuteNonQuery는 단일 값을 가져온다.
            }

            return stringresult;
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace CoffeeShop
{
    class DBManager
    {
        private static DBManager instance_ = new DBManager();
        private DBManager() { }
        public static DBManager getInstance() { return instance_; }
        string strConn = "Server=106.10.39.218;Database=s5355002;Uid=s5355002;Pwd=s5355002;Charset=utf8";
        public void insert(string query)
        {

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

        }

        public DataTable select(string query)
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
    }
}
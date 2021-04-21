using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCafeSNS
{
    public class User
    {
        public static string ID;
        public static string password;
        public static string Email;
        public static string region;
        public static Image image;
        

        public User()
        {
            
        }

        public int login(string id, string pw)
        {
            DataRow dr = null;
            string query = string.Format("SELECT * FROM USER WHERE userID = "
                +"'{0}' AND password = '{1}'", id, pw);
            dr = DBManager.getInstance().rowQuery(query);



            if (dr == null)
                MessageBox.Show("정보가 없습니다.");
            else
            {
                ID = dr["userID"] as string;
                password = dr["password"] as string;
                User.Email = dr["Email"] as string;
                User.region = dr["regionID"] as string;
                if(dr["image"]!=System.DBNull.Value)
                {
                    Byte[] byteBLOBData;
                    byteBLOBData = (Byte[])dr["image"];
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    
                    image = Image.FromStream(stmBLOBData);
                }
                ID = dr["userID"].ToString();
                password = dr["password"].ToString();
                User.Email = dr["Email"].ToString();
                User.region = dr["regionID"].ToString();
                if (User.ID.Equals(id) && User.password.Equals(pw))
                {
                    return 1;
                }
                    
            }
            return 0;
        }

        public static void empty()
        {
            User.ID = null;
            User.password = null;
            User.Email = null;
            User.region = null;
            User.image = null;
        }

        public static byte[] imageToString()
        {
            resize();
            byte[] buf = null;

            using(MemoryStream ms = new MemoryStream())
            {
                User.image.Save(ms, ImageFormat.Bmp);
                buf = ms.ToArray();
            }
            
            return buf; // 값 반환
         
        }

        public static void resize()
        {
            Size resize = new Size(75, 75);
            User.image = new Bitmap(User.image, resize);

        }

    }
}

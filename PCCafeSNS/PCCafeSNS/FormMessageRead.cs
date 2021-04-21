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
{
    public enum MessageState
    {
        send,
        receive
    }
    public partial class FormMessageRead : Form
    {
        int msgID;
        MessageState ms;
        public FormMessageRead(int msgID, MessageState ms)
        {
            InitializeComponent();
            this.msgID = msgID;
            this.ms = ms;
        }

        private void FormMessageRead_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (ms==MessageState.receive)
            {
                label1.Text = "보낸 사람";
                dt = DBManager.getInstance().Query($"SELECT * FROM MESSAGE WHERE ID={msgID}");
                label3.Text = dt.Rows[0]["senderID"].ToString();
            }
            else
            {
                label1.Text = "받는 사람";
                dt = DBManager.getInstance().Query($"SELECT * FROM MESSAGE WHERE ID={msgID}");
                label3.Text = dt.Rows[0]["receiverID"].ToString();
            }
            richTextBox1.Text=dt.Rows[0]["content"].ToString();
            if(dt.Rows[0]["receiveTime"]==System.DBNull.Value)
            {
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                DBManager.getInstance().nonQuery($"UPDATE MESSAGE SET receiveTime='{time}' WHERE ID={msgID}");
            }
        }
    }
}

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
    public partial class FormMessage : Form
    {
        private FormMain fm;
        DataTable Receive;
        DataTable Send;
        public FormMessage(FormMain _fm)
        {
            InitializeComponent();
            fm = _fm;
        }

        public FormMessage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshMessage();
        }

        private void RefreshMessage()
        {
            listViewReceive.Items.Clear();
            listViewSend.Items.Clear();
            Receive = DBManager.getInstance().Query($"SELECT * FROM MESSAGE WHERE receiverID='{User.ID}'");

            foreach (DataRow dr in Receive.Rows)
            {
                string receiveTime = "";
                if (dr["receiveTime"] == System.DBNull.Value)
                {
                    receiveTime = "확인 안함";
                }
                else
                {
                    receiveTime = dr["receiveTime"].ToString();
                }
                string[] item = { dr["ID"].ToString(), dr["content"].ToString(), dr["senderID"].ToString(), dr["sendTime"].ToString(), receiveTime };
                listViewReceive.Items.Add(new ListViewItem(item));
            }

            Send = DBManager.getInstance().Query($"SELECT * FROM MESSAGE WHERE senderID='{User.ID}'");
            foreach (DataRow dr in Send.Rows)
            {
                string receiveTime = "";
                if (dr["receiveTime"] == System.DBNull.Value)
                {
                    receiveTime = "확인 안함";
                }
                else
                {
                    receiveTime = dr["receiveTime"].ToString();
                }
                string[] item = { dr["ID"].ToString(),dr["content"].ToString(), dr["receiverID"].ToString(), dr["sendTime"].ToString(), receiveTime };
                listViewSend.Items.Add(new ListViewItem(item));
            }
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            RefreshMessage();
        }

        private void listViewReceive_DoubleClick(object sender, EventArgs e)
        {
            FormMessageRead fmr = new FormMessageRead(Int32.Parse(listViewReceive.FocusedItem.SubItems[0].Text),MessageState.receive);
            fmr.Show();
            fmr.FormClosing += delegate (object S, FormClosingEventArgs E)
              {
                  RefreshMessage();
              };
        }

        private void listViewSend_DoubleClick(object sender, EventArgs e)
        {
            FormMessageRead fmr = new FormMessageRead(Int32.Parse(listViewSend.FocusedItem.SubItems[0].Text), MessageState.send);
            fmr.Show();
            fmr.FormClosing += delegate (object S, FormClosingEventArgs E)
            {
                RefreshMessage();
            };
        }
    }
}

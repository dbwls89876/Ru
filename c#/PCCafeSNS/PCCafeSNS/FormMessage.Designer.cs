namespace PCCafeSNS
{
    partial class FormMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewSend = new System.Windows.Forms.ListView();
            this.columnMessageID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReceiver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSendTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReceiveTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewReceive = new System.Windows.Forms.ListView();
            this.columnMsgID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReceiveContents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReceiveSendTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReceiverReceiveTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "내가 보낸 쪽지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "내게 온 쪽지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "가입 신청";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(86, 479);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(577, 100);
            this.listBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(628, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "새로고침";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewSend
            // 
            this.listViewSend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMessageID,
            this.columnContents,
            this.columnReceiver,
            this.columnSendTime,
            this.columnReceiveTime});
            this.listViewSend.FullRowSelect = true;
            this.listViewSend.HideSelection = false;
            this.listViewSend.Location = new System.Drawing.Point(86, 71);
            this.listViewSend.Name = "listViewSend";
            this.listViewSend.Size = new System.Drawing.Size(577, 162);
            this.listViewSend.TabIndex = 6;
            this.listViewSend.UseCompatibleStateImageBehavior = false;
            this.listViewSend.View = System.Windows.Forms.View.Details;
            this.listViewSend.DoubleClick += new System.EventHandler(this.listViewSend_DoubleClick);
            // 
            // columnMessageID
            // 
            this.columnMessageID.Width = 0;
            // 
            // columnContents
            // 
            this.columnContents.Text = "내용";
            this.columnContents.Width = 266;
            // 
            // columnReceiver
            // 
            this.columnReceiver.Text = "받는 사람";
            this.columnReceiver.Width = 92;
            // 
            // columnSendTime
            // 
            this.columnSendTime.Text = "보낸 시간";
            this.columnSendTime.Width = 99;
            // 
            // columnReceiveTime
            // 
            this.columnReceiveTime.Text = "받은 시간";
            this.columnReceiveTime.Width = 108;
            // 
            // listViewReceive
            // 
            this.listViewReceive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMsgID,
            this.columnReceiveContents,
            this.columnSender,
            this.columnReceiveSendTime,
            this.columnReceiverReceiveTime});
            this.listViewReceive.FullRowSelect = true;
            this.listViewReceive.HideSelection = false;
            this.listViewReceive.Location = new System.Drawing.Point(86, 282);
            this.listViewReceive.Name = "listViewReceive";
            this.listViewReceive.Size = new System.Drawing.Size(577, 166);
            this.listViewReceive.TabIndex = 7;
            this.listViewReceive.UseCompatibleStateImageBehavior = false;
            this.listViewReceive.View = System.Windows.Forms.View.Details;
            this.listViewReceive.DoubleClick += new System.EventHandler(this.listViewReceive_DoubleClick);
            // 
            // columnMsgID
            // 
            this.columnMsgID.Text = "msgID";
            this.columnMsgID.Width = 0;
            // 
            // columnReceiveContents
            // 
            this.columnReceiveContents.Text = "내용";
            this.columnReceiveContents.Width = 262;
            // 
            // columnSender
            // 
            this.columnSender.Text = "보낸 사람";
            this.columnSender.Width = 111;
            // 
            // columnReceiveSendTime
            // 
            this.columnReceiveSendTime.Text = "보낸 시간";
            this.columnReceiveSendTime.Width = 85;
            // 
            // columnReceiverReceiveTime
            // 
            this.columnReceiverReceiveTime.Text = "확인한 시간";
            this.columnReceiverReceiveTime.Width = 109;
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 601);
            this.Controls.Add(this.listViewReceive);
            this.Controls.Add(this.listViewSend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMessage";
            this.Text = "FormMessage";
            this.Load += new System.EventHandler(this.FormMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewSend;
        private System.Windows.Forms.ListView listViewReceive;
        private System.Windows.Forms.ColumnHeader columnContents;
        private System.Windows.Forms.ColumnHeader columnReceiver;
        private System.Windows.Forms.ColumnHeader columnSendTime;
        private System.Windows.Forms.ColumnHeader columnReceiveTime;
        private System.Windows.Forms.ColumnHeader columnReceiveContents;
        private System.Windows.Forms.ColumnHeader columnSender;
        private System.Windows.Forms.ColumnHeader columnReceiveSendTime;
        private System.Windows.Forms.ColumnHeader columnReceiverReceiveTime;
        private System.Windows.Forms.ColumnHeader columnMessageID;
        private System.Windows.Forms.ColumnHeader columnMsgID;
    }
}
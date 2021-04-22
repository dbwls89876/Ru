namespace PCCafeSNS
{
    partial class FormGroupmanagersecession
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
            this.dataGridViewUserlist = new System.Windows.Forms.DataGridView();
            this.buttonSecession = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원리스트";
            // 
            // dataGridViewUserlist
            // 
            this.dataGridViewUserlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserlist.Location = new System.Drawing.Point(55, 100);
            this.dataGridViewUserlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewUserlist.Name = "dataGridViewUserlist";
            this.dataGridViewUserlist.RowTemplate.Height = 30;
            this.dataGridViewUserlist.Size = new System.Drawing.Size(541, 259);
            this.dataGridViewUserlist.TabIndex = 1;
            this.dataGridViewUserlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserlist_CellDoubleClick);
            // 
            // buttonSecession
            // 
            this.buttonSecession.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSecession.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSecession.FlatAppearance.BorderSize = 0;
            this.buttonSecession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecession.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSecession.ForeColor = System.Drawing.Color.White;
            this.buttonSecession.Location = new System.Drawing.Point(70, 407);
            this.buttonSecession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSecession.Name = "buttonSecession";
            this.buttonSecession.Size = new System.Drawing.Size(503, 33);
            this.buttonSecession.TabIndex = 2;
            this.buttonSecession.Text = "해당 회원에게 위임 후 탈퇴";
            this.buttonSecession.UseVisualStyleBackColor = false;
            this.buttonSecession.Click += new System.EventHandler(this.buttonSecession_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(238, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "그룹장 탈퇴 페이지";
            // 
            // FormGroupmanagersecession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSecession);
            this.Controls.Add(this.dataGridViewUserlist);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGroupmanagersecession";
            this.Padding = new System.Windows.Forms.Padding(14, 40, 14, 13);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUserlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSecession;
    }
}
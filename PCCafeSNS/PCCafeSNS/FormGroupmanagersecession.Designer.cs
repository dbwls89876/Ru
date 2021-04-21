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
            this.label1.Location = new System.Drawing.Point(75, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원리스트";
            // 
            // dataGridViewUserlist
            // 
            this.dataGridViewUserlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserlist.Location = new System.Drawing.Point(78, 150);
            this.dataGridViewUserlist.Name = "dataGridViewUserlist";
            this.dataGridViewUserlist.RowTemplate.Height = 30;
            this.dataGridViewUserlist.Size = new System.Drawing.Size(773, 389);
            this.dataGridViewUserlist.TabIndex = 1;
            this.dataGridViewUserlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserlist_CellDoubleClick);
            // 
            // buttonSecession
            // 
            this.buttonSecession.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSecession.Location = new System.Drawing.Point(100, 611);
            this.buttonSecession.Name = "buttonSecession";
            this.buttonSecession.Size = new System.Drawing.Size(718, 50);
            this.buttonSecession.TabIndex = 2;
            this.buttonSecession.Text = "해당 회원에게 위임 후 탈퇴";
            this.buttonSecession.UseVisualStyleBackColor = true;
            this.buttonSecession.Click += new System.EventHandler(this.buttonSecession_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(340, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "그룹장 탈퇴 페이지";
            // 
            // FormGroupmanagersecession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 743);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSecession);
            this.Controls.Add(this.dataGridViewUserlist);
            this.Controls.Add(this.label1);
            this.Name = "FormGroupmanagersecession";
            this.Text = "FormGroupmanagerrecession";
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
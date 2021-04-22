namespace CoffeeShop
{
    partial class CoffeeUpdate
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
            this.comboBoxCoffee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCoffeePrice = new System.Windows.Forms.Label();
            this.labelCoffeeName = new System.Windows.Forms.Label();
            this.textBoxCoffeePrice = new System.Windows.Forms.TextBox();
            this.textBoxCoffeeName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCoffee
            // 
            this.comboBoxCoffee.FormattingEnabled = true;
            this.comboBoxCoffee.Location = new System.Drawing.Point(91, 31);
            this.comboBoxCoffee.Name = "comboBoxCoffee";
            this.comboBoxCoffee.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCoffee.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "커피 선택";
            // 
            // labelCoffeePrice
            // 
            this.labelCoffeePrice.AutoSize = true;
            this.labelCoffeePrice.Location = new System.Drawing.Point(77, 143);
            this.labelCoffeePrice.Name = "labelCoffeePrice";
            this.labelCoffeePrice.Size = new System.Drawing.Size(29, 12);
            this.labelCoffeePrice.TabIndex = 17;
            this.labelCoffeePrice.Text = "가격";
            // 
            // labelCoffeeName
            // 
            this.labelCoffeeName.AutoSize = true;
            this.labelCoffeeName.Location = new System.Drawing.Point(49, 116);
            this.labelCoffeeName.Name = "labelCoffeeName";
            this.labelCoffeeName.Size = new System.Drawing.Size(57, 12);
            this.labelCoffeeName.TabIndex = 16;
            this.labelCoffeeName.Text = "커피 이름";
            // 
            // textBoxCoffeePrice
            // 
            this.textBoxCoffeePrice.Location = new System.Drawing.Point(112, 140);
            this.textBoxCoffeePrice.Name = "textBoxCoffeePrice";
            this.textBoxCoffeePrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxCoffeePrice.TabIndex = 15;
            // 
            // textBoxCoffeeName
            // 
            this.textBoxCoffeeName.Location = new System.Drawing.Point(112, 113);
            this.textBoxCoffeeName.Name = "textBoxCoffeeName";
            this.textBoxCoffeeName.Size = new System.Drawing.Size(100, 21);
            this.textBoxCoffeeName.TabIndex = 14;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(112, 180);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "수정";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // CoffeeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 240);
            this.Controls.Add(this.comboBoxCoffee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCoffeePrice);
            this.Controls.Add(this.labelCoffeeName);
            this.Controls.Add(this.textBoxCoffeePrice);
            this.Controls.Add(this.textBoxCoffeeName);
            this.Controls.Add(this.buttonUpdate);
            this.Name = "CoffeeUpdate";
            this.Text = "CoffeeUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCoffee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCoffeePrice;
        private System.Windows.Forms.Label labelCoffeeName;
        private System.Windows.Forms.TextBox textBoxCoffeePrice;
        private System.Windows.Forms.TextBox textBoxCoffeeName;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
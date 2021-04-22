namespace CoffeeShop
{
    partial class ButtonAdds
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
            this.textBoxCoffeeName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCoffeePrice = new System.Windows.Forms.TextBox();
            this.labelCoffeeName = new System.Windows.Forms.Label();
            this.labelCoffeePrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCoffeeName
            // 
            this.textBoxCoffeeName.Location = new System.Drawing.Point(78, 37);
            this.textBoxCoffeeName.Name = "textBoxCoffeeName";
            this.textBoxCoffeeName.Size = new System.Drawing.Size(100, 21);
            this.textBoxCoffeeName.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(89, 91);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxCoffeePrice
            // 
            this.textBoxCoffeePrice.Location = new System.Drawing.Point(78, 64);
            this.textBoxCoffeePrice.Name = "textBoxCoffeePrice";
            this.textBoxCoffeePrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxCoffeePrice.TabIndex = 2;
            // 
            // labelCoffeeName
            // 
            this.labelCoffeeName.AutoSize = true;
            this.labelCoffeeName.Location = new System.Drawing.Point(15, 40);
            this.labelCoffeeName.Name = "labelCoffeeName";
            this.labelCoffeeName.Size = new System.Drawing.Size(57, 12);
            this.labelCoffeeName.TabIndex = 3;
            this.labelCoffeeName.Text = "커피 이름";
            // 
            // labelCoffeePrice
            // 
            this.labelCoffeePrice.AutoSize = true;
            this.labelCoffeePrice.Location = new System.Drawing.Point(43, 67);
            this.labelCoffeePrice.Name = "labelCoffeePrice";
            this.labelCoffeePrice.Size = new System.Drawing.Size(29, 12);
            this.labelCoffeePrice.TabIndex = 4;
            this.labelCoffeePrice.Text = "가격";
            // 
            // ButtonAdds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 155);
            this.Controls.Add(this.labelCoffeePrice);
            this.Controls.Add(this.labelCoffeeName);
            this.Controls.Add(this.textBoxCoffeePrice);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCoffeeName);
            this.Name = "ButtonAdds";
            this.Text = "ButtonAdds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCoffeeName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCoffeePrice;
        private System.Windows.Forms.Label labelCoffeeName;
        private System.Windows.Forms.Label labelCoffeePrice;
    }
}
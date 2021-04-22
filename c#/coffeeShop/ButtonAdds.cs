using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class ButtonAdds : Form
    {
        public Form1 form;
        public ButtonAdds()
        {
            InitializeComponent();
        }

        public ButtonAdds(Form1 _form)
        {
            InitializeComponent();
            form = _form;
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Location = new System.Drawing.Point(30 + (form.num_buttons * 100), 50);
            btn.Name = "button" + textBoxCoffeeName.Text;
            btn.Size = new System.Drawing.Size(75, 25);
            btn.TabIndex = 1;
            btn.Text = textBoxCoffeeName.Text;
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(form.button_Coffee_Click);
            btn.Parent = this;
            btn.Tag = form.num_buttons;
            form.num_buttons++;
            form.groupBox1.Controls.Add(btn);
            

            string str = string.Format("INSERT INTO Coffee (coffee, price) VALUES ('{0}',{1})", textBoxCoffeeName.Text, Convert.ToInt32(textBoxCoffeePrice.Text));
            DBManager.getInstance().insert(str);
            MessageBox.Show("삽입완료");
        }
    }
}

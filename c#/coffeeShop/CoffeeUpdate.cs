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
    public partial class CoffeeUpdate : Form
    {
        public Form1 form;

        public CoffeeUpdate()
        {
            InitializeComponent();
        }

        public CoffeeUpdate(Form1 _form)
        {
            InitializeComponent();
            form = _form;

            for (int i = 0; i < form.buttonGroup.Count(); i++)
            {
                comboBoxCoffee.Items.Add(form.buttonGroup[i].Text);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < form.buttonGroup.Count(); i++)
            {
                if (form.buttonGroup[i].Text.Equals(comboBoxCoffee.Text))
                {
                    form.buttonGroup[i].Text = textBoxCoffeeName.Text;
                    string str = string.Format("UPDATE Coffee SET coffee = '{0}', price = {1} WHERE cid = {2}", textBoxCoffeeName.Text, textBoxCoffeePrice.Text, i + 1); // UPDATE문
                    DBManager.getInstance().insert(str);
                    MessageBox.Show("수정완료");
                    break;
                }
            }
        }
    }
}

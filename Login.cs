using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.Text = "";
            textBox2.PasswordChar= '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.TextLength <3)
                textBox2.BackColor = Color.Red;
            else
                textBox2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox1.TextLength < 3 || textBox2.TextLength < 5)
                MessageBox.Show("username or password must have more charecters");
            else
            {
                Welcome welcome = new();
                welcome.Show();
                this.Hide();
            }
        }
    }
}

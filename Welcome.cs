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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            var data = new List<Loans>
            {
                new Loans() { Name = "Personal Loan", Value = "5" },
                new Loans() { Name = "Home Loan", Value = "10" },
                new Loans() { Name = "Vehicle", Value = "15" }
            };

            this.comboBox1.DataSource = data;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new();
            login.Show();
            this.Hide();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(textBox3.Text.Length > 0) 
                textBox5.Text = ((float.Parse(this.comboBox1.SelectedValue.ToString())/100) * float.Parse(textBox3.Text)).ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var Rate = float.Parse(textBox3.Text) * float.Parse(textBox2.Text) / Int32.Parse(textBox4.Text) + Int32.Parse(textBox3.Text);
            var Percent = (float.Parse(this.comboBox1.SelectedValue.ToString()) / 100 * float.Parse(textBox3.Text));
            var total = Rate + Percent * Int32.Parse(textBox4.Text);
           
            if(total > 0)
            {
                MessageBox.Show("Total loan is: R " + total.ToString());
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.TextLength > 0)
                textBox5.Text = ((float.Parse(comboBox1.SelectedValue.ToString()) / 100) * float.Parse(textBox3.Text)).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

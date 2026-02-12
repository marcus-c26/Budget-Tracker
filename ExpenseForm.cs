using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Tracking_System
{
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = int.TryParse(textBox1.Text, out int val1) ? val1 : 0;
            int value2 = int.TryParse(textBox3.Text, out int val2) ? val2 : 0;
            int value3 = int.TryParse(label7.Text, out int val3) ? val3 : 0;
            int value4 = int.TryParse(label8.Text, out int val4) ? val4 : 0;
           

            int dif1 = value1 - value2 - value3 - value4;
            

            textBox4.Text = dif1.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainForm = new Form2();
            MainForm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(textBox2.Text);
            newItem.SubItems.Add(textBox1.Text);
            newItem.SubItems.Add(textBox3.Text);
            newItem.SubItems.Add(textBox5.Text);
            listView1.Items.Add(newItem);      


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
               
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

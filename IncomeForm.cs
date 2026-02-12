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
    public partial class IncomeForm : Form
    {
        
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = int.TryParse(textBox1.Text, out int val1) ? val1 : 0;
            int value2 = int.TryParse(textBox13.Text, out int val2) ? val2 : 0;
            int value3 = int.TryParse(label4.Text, out int val3) ? val3 : 0;
            int value4 = int.TryParse(label5.Text, out int val4) ? val4 : 0;
            int value5 = int.TryParse(label6.Text, out int val5) ? val5 : 0;
            int value6 = int.TryParse(label7.Text, out int val6) ? val6 : 0;
            int value7 = int.TryParse(label8.Text, out int val7) ? val7 : 0;

            int dif1 = value1 - value2 - value3 - value4;
            int dif2 = value1 - value5 - value6 - value7;

            textBox22.Text = dif1.ToString();
            textBox23.Text = dif2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainForm = new Form2();
            MainForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox23_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}

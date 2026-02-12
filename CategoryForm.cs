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
    public partial class CategoryForm : UserControl
    {
       
        public CategoryForm()
        {
            InitializeComponent();

            
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Active");
            comboBox1.Items.Add("Inactive");

            comboBox2.Items.Add("Income");
            comboBox2.Items.Add("Expense");

            




        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListViewItem newItem = new ListViewItem(textBox1.Text);
            newItem.SubItems.Add(comboBox1.Text);
            newItem.SubItems.Add(comboBox2.Text);
            listView1.Items.Add(newItem);




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox1.Text = "";

            comboBox1.Text = "";
            comboBox2.Text = "";

            listView1.Text = "";




        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                



            }
            else if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = comboBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = comboBox2.Text;


            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); 


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView ListView1 = new ListView();
        }
    }
}

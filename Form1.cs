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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = (checkBox1.Checked) ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ("user321"))
            {
                var Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}

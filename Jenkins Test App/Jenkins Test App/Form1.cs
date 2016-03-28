using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jenkins_Test_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            if (!int.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("I need just a number in the first box!");
                return;
            }
            if (!int.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("I need just a number in the second box!");
                return;
            }
            label2.Text = (a + b).ToString();
        }
    }
}

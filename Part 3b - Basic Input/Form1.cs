using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3b___Basic_Input
{
    public partial class BasicInput : Form
    {
        public BasicInput()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            int ageDifference;
            double hight;
            double hightDifference;

            name = txtName.Text;
            lblGreetMsg.Text = "Hello" + name;
            age = Convert.ToInt32(txtAge.Text);
            ageDifference = 82 - age;
            lblGreetMsg.Text = $"You are {age} years old, and according to Google your average life expectancy is around {ageDifference}";

        }
    }
}

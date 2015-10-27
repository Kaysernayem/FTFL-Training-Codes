using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DBPracticeDisconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string un = textBox1.Text;
            string pw = textBox2.Text;
            if (un == "FTFL" && pw == "DOTNET")
                MessageBox.Show("Valid","Message");
            else
                MessageBox.Show("Invalid", "Message");
        }
    }
}

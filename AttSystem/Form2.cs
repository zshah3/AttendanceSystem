using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
                       
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();          
        }

        private void course1_Click(object sender, EventArgs e)
        {           
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void course2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }
    }
}

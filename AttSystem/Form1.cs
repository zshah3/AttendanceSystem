using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AttSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            password.MaxLength = 10;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Systems Development Project\AttSystem\AttSystem.accdb";
                OleDbConnection myConnection = new OleDbConnection(connString);
                string myQuery = "SELECT * FROM Login WHERE Username='" + this.userName.Text + "' and Password='" + this.password.Text + "' ;";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

                OleDbDataReader myReader;
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read()) 
                {
                    count = count + 1;
                }
                if (count == 1)
                {             
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Visible = false;
                    //Application.OpenForms["Form1"].Close();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password");
                }
                else
                    MessageBox.Show("Username or Password is incorrect");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

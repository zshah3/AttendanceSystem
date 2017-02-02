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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        void showStu()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Systems Development Project\AttSystem\AttSystem.accdb";
            string myQuery = "SELECT * FROM Course3";
            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader["Name"].ToString();
                    stuBox.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in DBHandler" + ex);
            }
            finally
            {
                myConnection.Close();
            }

        }

        void showWeek()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Systems Development Project\AttSystem\AttSystem.accdb";
            string myQuery = "SELECT * FROM Weeks";
            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string sWeek = myReader["Weeks"].ToString();
                    wekBox.Items.Add(sWeek);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in DBHandler" + ex);
            }
            finally
            {
                myConnection.Close();
            }

        }

        void showSession()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Systems Development Project\AttSystem\AttSystem.accdb";
            string myQuery = "SELECT * FROM Attcode";
            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string sCode = myReader["Session"].ToString();
                    sesBox.Items.Add(sCode);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in DBHandler" + ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        void showCode()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Systems Development Project\AttSystem\AttSystem.accdb";
            string myQuery = "SELECT * FROM Attcode";
            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string sCode = myReader["Attcode"].ToString();
                    codeBox.Items.Add(sCode);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in DBHandler" + ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        void showStu2()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Systems Development Project\AttSystem\AttSystem.accdb";
            string myQuery = "SELECT * FROM Course3";
            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader["Name"].ToString();
                    stuBox2.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in DBHandler" + ex);
            }
            finally
            {
                myConnection.Close();
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Systems Development Project\AttSystem\AttSystem.accdb";
            string myQuery = "INSERT INTO Course3 (Name) VALUES ('" + this.addText.Text + "') ;";
            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                MessageBox.Show("New Student Added");

                string name = addText.Text;
                stuBox.Items.Add(name);
                stuBox2.Items.Add(name);
                addText.Text = (" ");

                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in DBHandler" + ex);
            }
            finally
            {
                myConnection.Close();

            }
        }

        private void dltButton_Click(object sender, EventArgs e)
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Systems Development Project\AttSystem\AttSystem.accdb";
            string myQuery = "DELETE FROM Course3 WHERE Name='" + this.stuBox2.Text + "' ;";
            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                MessageBox.Show("Student Deleted");
                string name = stuBox2.Text;
                stuBox.Items.Remove(name);
                stuBox2.Items.Remove(name);

                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in DBHandler" + ex);
            }
            finally
            {
                myConnection.Close();

            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void attLogBtn_Click(object sender, EventArgs e)
        {
            logAttendence();
        }

        void logAttendence()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Systems Development Project\AttSystem\AttSystem.accdb";
            OleDbConnection myConnection = new OleDbConnection(connString);
            if (wekBox.Text == "30/09/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week1Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "30/09/13" && sesBox.Text == "Tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week1Tut='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "30/09/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week1Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "07/10/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week2Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "07/10/13" && sesBox.Text == "Tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week2Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "07/10/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week2Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "14/10/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week3Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "14/10/13" && sesBox.Text == "tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week3Tutorial='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "14/10/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week3Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "21/10/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week4Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "21/10/13" && sesBox.Text == "Tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week4Tut='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "21/10/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week4Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "28/10/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week5Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "28/10/13" && sesBox.Text == "Tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week5Tut='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "28/10/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week5Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "04/11/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week6Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "04/11/13" && sesBox.Text == "Tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week6Tut='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "04/11/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week6Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "11/11/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week7Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "11/11/13" && sesBox.Text == "Tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week7Tut='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "11/11/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week7Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "18/11/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week8Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "18/11/13" && sesBox.Text == "Tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week8Tut='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "18/11/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week8Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "25/11/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week9Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "25/11/13" && sesBox.Text == "Tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week9Tut='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "25/11/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week9Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "02/12/13" && sesBox.Text == "Lecture")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week10Lec='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "-2/12/13" && sesBox.Text == "Tutorial")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week10Tut='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
            else if (wekBox.Text == "02/12/13" && sesBox.Text == "Lab")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Course3 SET Week10Lab='" + this.codeBox.Text + "' WHERE Name='" + this.stuBox.Text + "' ;", myConnection);
                try
                {
                    myConnection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Attendence Logged");

                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in DBHandler" + ex);
                }
            }
        }

        

        

        
    }
}

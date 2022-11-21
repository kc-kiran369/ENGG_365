using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ClassroomManagement.DataBase
{
    class SQLConnector
    {
        public static readonly SQLConnector Instance = new SQLConnector();
        string m_ConnectionString = @"Server=localhost\MariaDB;Database=mydatabase;Integrated Security=SSPI";
        public SQLConnector()
        {

        }
        public void Insert(string fname, string lname)
        {
            using (SqlConnection m_SqlConnection = new SqlConnection(m_ConnectionString))
            {
                string query = "INSERT INTO student(id,FirstName, LastName) VALUES(" + fname + "," + lname + ")";
                //SqlCommand command = new SqlCommand(query, m_SqlConnection);
                try
                {
                    m_SqlConnection.Open();
                    MessageBox.Show("Data Insertion Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                //command.ExecuteNonQuery();
                //command.Dispose();
                //m_SqlConnection.Close();
            }
        }
    }
}
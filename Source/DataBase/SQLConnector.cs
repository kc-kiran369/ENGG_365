using System;
using System.Data.SqlClient;

namespace ClassroomManagement.DataBase
{
    class SQLConnector
    {
        private SqlConnection m_SqlConnection = new SqlConnection();
        private string m_ConnectionString = "Server=testserver;Database=student;";

        public SQLConnector()
        {
            m_SqlConnection.ConnectionString = m_ConnectionString;
        }
    }
}
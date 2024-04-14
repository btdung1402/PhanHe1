using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.DirectoryServices;
using System.Windows.Forms;

namespace PhanHe1.DAO
{
    public class OracleDataProvider
    {
        private static OracleDataProvider instance;
        
        private static readonly object lockObject = new object();
        
        //You can change the default connection string in app.config
        private static string _connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public static string username;
        private OracleDataProvider(string connectionString)
        {
            _connectionString = connectionString;
            username = UserName();
        }

        private OracleDataProvider() 
        {
            username = UserName();
        }

        public static OracleDataProvider Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new OracleDataProvider();
                    }
                    return instance;
                }
            }
            private set => OracleDataProvider.instance = value;
        }

        
        public static OracleDataProvider Initialize(string connectionString)
        {
            if (instance != null)
            {
                _connectionString = connectionString;
            }
            instance = new OracleDataProvider(connectionString);
            return instance;
        }

        public bool TestConnection()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(_connectionString))
                {
                    conn.Open();
                    return true; // Connection successful
                }
            }
            catch (OracleException)
            {
                return false; // Connection failed
            }
        }

        private string UserName()
        {
            // Find the index of the substring "User Id =" in the connection string
            int userIdIndex = _connectionString.IndexOf("User Id =");

            // Check if the substring "User Id =" exists in the connection string
            if (userIdIndex != -1)
            {
                // Add the length of "User Id =" to get the starting index of the username
                userIdIndex += "User Id =".Length;

                // Find the index of the next semicolon after the "User Id =" substring
                int semicolonIndex = _connectionString.IndexOf(";", userIdIndex);

                // Calculate the length of the username substring
                int length = semicolonIndex - userIdIndex;

                // Extract the username substring using Substring method
                string username = _connectionString.Substring(userIdIndex, length);

                return username;
            }
            return "";
        }
        public DataTable ExecuteQuery(string sql, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using (OracleConnection connection = new OracleConnection(_connectionString))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(sql, connection);

                if (parameters != null)
                {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (string s in listPara)
                    {
                        if (s.Contains(":"))
                        {
                            command.Parameters.Add(s, parameters[i++]);
                        }
                    }
                }

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }


        public int ExecuteNonQuery(string sql, object[] parameters = null)
        {
            int rowsAffected = 0;
            using (OracleConnection connection = new OracleConnection(_connectionString))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(sql, connection);

                // Add parameters if provided
                if (parameters != null)
                {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (string s in listPara)
                    {
                        if (s.Contains(":"))
                        {
                            command.Parameters.Add(s, parameters[i++]);
                        }
                    }
                }

                rowsAffected = command.ExecuteNonQuery();

                connection.Close();
            }

            return rowsAffected;
        }


        public object ExecuteScalar(string sql, object[] parameters = null)
        {
            object data = null;
            using (OracleConnection connection = new OracleConnection(_connectionString))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(sql, connection);

                if (parameters != null)
                {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (string s in listPara)
                    {
                        if (s.Contains(":"))
                        {
                            command.Parameters.Add(s, parameters[i++]);
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }



    }

}

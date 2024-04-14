using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Windows.Forms;

namespace PhanHe1.DAO
{
    public class OracleDataProvider
    {
        private static OracleDataProvider instance;
        private static readonly object lockObject = new object();

        //You can change the default connection string in app.config
        private static string _connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private static OracleConnection connection;

        private OracleDataProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        private OracleDataProvider() { }

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

        public static void Initialize(string connectionString)
        {
            if (instance != null)
            {
                _connectionString = connectionString;
            }
            instance = new OracleDataProvider(connectionString);
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

        public void RunQuery(string sql)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(sql, connection);
                connection.Close();
            }
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

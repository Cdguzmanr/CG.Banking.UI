using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // SQL 
using System.Xml.Serialization;


namespace CG.Banking.BL
{
    public class DataAccess
    {
        // Fields
        private static SqlConnection? connection = null;

        public static string XMLFilePath { get; set; } = "";

        public static string ConnectionString { get; set; } = "";



        // Methods

        // --- XML ---
        public static void SaveXml(Type type, object obj)
        {
            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, obj);
            }
        }

        public static object? LoadXml(Type type)
        {
            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                return serializer.Deserialize(reader);
            }
        }


        // --- SQL ---
        private static void Connect()
        {
            if (ConnectionString == null || ConnectionString == "")
            {
                throw new Exception("Connection string was not set.");
            }

            if (connection == null)
            {
                connection = new SqlConnection(ConnectionString);
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            connection?.Close();
        }

        public static DataTable SelectFromDB(string sql, List<SqlParameter>? parameters = null, bool closeConnection = true)
        {
            Connect();

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null && parameters.Count > 0)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (closeConnection) CloseConnection();

                    return table;
                }
            }
        }

        public static int ExecuteSql(string sql, List<SqlParameter>? parameters = null, bool closeConnection = true)
        {
            Connect();

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null && parameters.Count > 0)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                int result = Convert.ToInt32(command.ExecuteScalar());
                if (closeConnection) CloseConnection();

                return result;
            }
        }

    }
}

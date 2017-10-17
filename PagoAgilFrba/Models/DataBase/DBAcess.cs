
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PagoAgilFrba.Models.DataBase
{
    class DBAcess
    {
        //para conectar base de datos con visual
        private static SqlConnection connection = new SqlConnection();

        public static SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                //connection.ConnectionString = @System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
                connection.ConnectionString = @System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
                // el string "ConnectionString" se obtiene del app.config
                connection.Open();
            }
            return connection;
        }

        private static SqlCommand BuildSQLCommand(string commandtext, List<SqlParameter> parameters)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = GetConnection();
            sqlCommand.CommandText = commandtext;
            if (parameters != null)
            {
                foreach (SqlParameter param in parameters) { sqlCommand.Parameters.Add(param); }
            }
            return sqlCommand;
        }


        public static object ExecStoredProcedure(string commandText, List<SqlParameter> parameters)
        {
            try
            {
                SqlCommand sqlCommand = BuildSQLCommand(commandText, parameters);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                return sqlCommand.Parameters["@ret"].Value;
            }
            catch { return 0; }
        }

        public static SqlDataReader GetDataReader(string commandtext, string commandtype, List<SqlParameter> parameters)
        {
            SqlCommand sqlCommand = BuildSQLCommand(commandtext, parameters);
            SetCommandType(commandtype, sqlCommand);
            return sqlCommand.ExecuteReader();
        }

        public static SqlDataReader GetDataReader(string commandtext, string commandtype)
        {
            return GetDataReader(commandtext, commandtype, null);
        }

        private static void SetCommandType(string commandtype, SqlCommand sqlCommand)
        {
            switch (commandtype)
            {
                case "T":
                    sqlCommand.CommandType = CommandType.Text;
                    break;
                case "TD":
                    sqlCommand.CommandType = CommandType.TableDirect;
                    break;
                case "SP":
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    break;
            }
        }

        public static int WriteInBase(string commandtext, string commandtype, List<SqlParameter> parameters)
        {
            SqlCommand sqlCommand = BuildSQLCommand(commandtext, parameters);
            SetCommandType(commandtype, sqlCommand);
            return sqlCommand.ExecuteNonQuery();

        }


    }

}

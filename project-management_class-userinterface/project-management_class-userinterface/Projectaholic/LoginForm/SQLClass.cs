using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Projectaholic
{
    static class SQLClass
    {
        public const string COMMAND_SELECT_ALL_FROM_TABLE = "SELECT * FROM {0}";
        public const string COMMAND_SELECT_COLUMNS_FROM_TABLE = "SELECT {0} FROM {1}";


        public static string GetSQLConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public static DataSet GetDataFromSQL(string command, string tableName)
        {
            DataSet returnData = new DataSet();
            SqlConnection conn = new SqlConnection(GetSQLConnectionString());
            SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
            conn.Open();
            adapter.Fill(returnData, tableName);
            conn.Close();
            return returnData;
        }

        public static void UpdateDataToSQL(DataTable data, string command, string tableName)
        {
            throw new NotImplementedException();
        }
    }
}

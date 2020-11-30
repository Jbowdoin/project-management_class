using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projectaholic
{
    static class SQLClass
    {
        public static string GetSQLConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public static T GetDataFromRequest<T>(string request)
        {
            T data;
            using (SqlConnection connection = new SqlConnection(GetSQLConnectionString()))
            {
                using(SqlCommand command = new SqlCommand(request))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    data = (T)result;
                }
            }
            return data;
        }
    }
}

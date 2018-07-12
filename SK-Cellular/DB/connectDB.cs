using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Cellular.DB
{
   
   public static class connectDB
    {
        
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mainDB"].ConnectionString);
            return conn;
        }

       
    }
}

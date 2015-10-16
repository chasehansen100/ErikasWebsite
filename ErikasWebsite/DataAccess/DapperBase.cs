using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class DapperBase
    {
        private static string _connect = ConfigurationManager.ConnectionStrings["ErikasWebsite"].ConnectionString;

        public static string ConnectionString
        {
            get
            {
                return _connect;
            }
            set
            {
                _connect = value;
            }
        }
        protected static SqlConnection Open(string connectionstring = null)
        {
            var con = new SqlConnection(connectionstring ?? _connect);
            con.Open();
            return con;
        }
    }
}

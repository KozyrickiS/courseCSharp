using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDatabase
{
    public static class Connection
    {
        public static SqlConnection Connect { get; private set; }
        public static void ConnectionInitialize()
        {
            try
            {
                string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Transport;Trusted_Connection=True;";
                Connect = new SqlConnection(connectionString);
                Connect.Open();
            }
            catch (Exception e)
            {
                Logger.Log.Error(e.Message);
            }
        }
    }
}

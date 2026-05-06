using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESET._3
{
    public class DatabaseContext
    {
        private static readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=T.E.S.E.T.;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            return baglanti;
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bağlantı Hatası: " + ex.Message);
                return false;
            }
        }
    }
}
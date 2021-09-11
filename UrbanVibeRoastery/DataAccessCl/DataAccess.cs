using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UrbanVibeRoastery.DataAccessCl
{
    public class DataAccess
    {
        public static void OpenDB()
        {      
          SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=UrbanVibeRoastery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();

            
        }
    }
}

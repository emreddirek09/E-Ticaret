using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess
{
    public class DbConnection
    {
        public SqlConnection Baglan()
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-J9OEKO6; Database=eTicaret; Integrated Security = True");            
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}

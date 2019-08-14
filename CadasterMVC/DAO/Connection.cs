using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CadasterMVC.DAO
{
    public class Connection
    {
        public SqlConnection ConnectionSql ()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost,1460;Initial Catalog=Cadaster;User ID=sa;Password=Cadaster!@#;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return conn;
        }
    }
}

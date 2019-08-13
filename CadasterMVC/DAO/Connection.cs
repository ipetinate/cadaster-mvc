using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CadasterMVC.DAO
{
    public class Connection
    {
        public object ConnectionSql ()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost,1460;Initial Catalog=Cadaster;User ID=sa;Password=Cadaster!@#;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                conn.Open();
                SqlCommand selectPessoa = new SqlCommand("SELECT * FROM [Cadaster].[dbo].[Pessoa]", conn);

                return selectPessoa;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }
    }
}

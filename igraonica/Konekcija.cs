using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace igraonica
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
            //string CS = "Data Source = LAPTOP-FGQM75PR\\SQLEXPRESS; Initial Catalog = ednevnik; Integrated Security = True";
            string CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
    }
}

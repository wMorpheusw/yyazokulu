using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-Q1AKMG2\SQLEXPRESS;Initial Catalog=DByazokulu;Integrated Security=True");

    }
}

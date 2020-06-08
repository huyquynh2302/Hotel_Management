using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Hotel
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B182N8G\MSSQLSERVER01;Initial Catalog=QLKS;Integrated Security=True");
    }
}

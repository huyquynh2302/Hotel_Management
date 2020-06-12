using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DBConnection
    {
        public static SqlConnection staticConnecStatus = null;

        protected string dataSource = "";
        protected string Source = "";

        protected Dictionary<string,string>[] queryParams = new Dictionary<string,string>[]();

        
        public DBConnection()
        {
            this.connection();
        }

        public SqlConnection connection()
        {
            if (staticConnecStatus == null)
            {
                string source = @"Data Source=DESKTOP-UV32U5F\SQLEXPRESS;Initial Catalog=winform;Integrated Security=True";
                staticConnecStatus = new SqlConnection(source);
            }
            return staticConnecStatus;
        }

        

    }
}

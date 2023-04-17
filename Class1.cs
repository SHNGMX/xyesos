using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyesos
{
    class Class1
    {
        SqlConnection con = new SqlConnection(@"Data Source = HOME-PC\SQLEXPRESS; Initial Catalog = database; Integrated Security = true");



        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return con;
        }
    }
}

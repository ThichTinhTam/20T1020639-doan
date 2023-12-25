using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20T1020639_doan.DAL
{
    public class Database
    {
        string strCon = @"Data Source=LAPTOP-TR2PA795\NHONVIET;Initial Catalog=639_QLBG;Integrated Security=True";
        protected SqlConnection sqlCon = null;

        public void OpenConnection()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
            {
                sqlCon.Close();
            }
        }

    }
}

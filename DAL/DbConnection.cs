using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DbConnection
    {
        public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=threeTierArchi;Integrated Security=True");

        public SqlConnection getcon()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Perform Insert Update Delete Operation
        public int ExcelNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            int rowsaffected = -1;
            rowsaffected=cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;

        }
        //Retrive a Single value from DB or Query
        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        //Perform Select Query

        public DataTable ExReader(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            //SqlDataAdapter sdr;
            DataTable dt = new DataTable();

            SqlDataReader sdr = cmd.ExecuteReader();

            dt.Load(sdr);
            con.Close();
            return dt;
        }
    }
}

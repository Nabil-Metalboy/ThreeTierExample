using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;

namespace BAL
{
    public class Operations
    {
        public DbConnection db = new DbConnection();
        public Information info = new Information();

        //hee we declare the queries and db operation for the application 

        public int insertEmp(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into empdata (Name,Gender,DOB,Address,Education,Username,Password,MobileNo,Usertype) values ('" + info.name + "','" + info.gender + "','" + info.dob + "','" + info.address + "','" + info.education + "','" + info.username + "','" + info.password + "','" + info.mobilenum + "','user') ";
            return db.ExcelNonQuery(cmd);
        }

        public DataTable StockInTransfer()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ITEMDetailsLocation";
            return db.ExReader(cmd);
        }

        public SqlDataReader StockView()
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ITEMDetailsLocation";
            return db.getReader(cmd);
        }

        public DataTable login(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from empdata where Username = '"+info.username+"' and Password = '"+info.password+"' ";

            return db.ExReader(cmd);
        }

       
       

    }
}

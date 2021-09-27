using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    class DAO_Login
    {
        public SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QLCHN;Integrated Security=True");
        public DataTable dt = new DataTable();
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public bool login(string username, string password)
        {
            bool kq = false;
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TaiKhoan='" + username + "' AND MatKhau='" + password + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    kq = true;
            }
            catch (Exception err)
            {
                throw;
            }
            return kq;
        }
    }
}

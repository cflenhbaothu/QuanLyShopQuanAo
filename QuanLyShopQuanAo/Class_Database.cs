using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyShopQuanAo
{
    public class Class_Database : IDisposable
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter sda;

        public void Dispose()
        {
            if (con != null)
            {
                con.Dispose();
                con = null;
            }
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }
            if (sda != null)
            {
                sda.Dispose();
                sda = null;
            }
        }

        public Class_Database()
        {
            con = new SqlConnection("server=DESKTOP-64SRSV4; database=QuanLyShopQuanAo; Integrated Security=True");
        }
        public DataTable GetData(ref string err, string sql)
        {
            DataTable dt = null;
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                cmd = new SqlCommand(sql, con) { CommandTimeout = 600 };
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public void executeNonQuery(ref string err, string sql)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                cmd = new SqlCommand(sql, con) { CommandTimeout = 600 };
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        public SqlDataAdapter GetData_Login(ref string err, string sql)
        {
            sda = null;

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                cmd = new SqlCommand(sql, con) { CommandTimeout = 600 };
                sda = new SqlDataAdapter(cmd);
                return sda;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return sda;
        }

        public string GetSingleData(string sql)
        {
            string x = string.Empty;
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                cmd = new SqlCommand(sql, con) { CommandTimeout = 600 };
                x = cmd.ExecuteScalar().ToString();
                return x;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                con.Close();
            }
            return x;
        }
    }
}

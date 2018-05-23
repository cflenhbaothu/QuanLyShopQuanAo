using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyShopQuanAo
{
    public class Class_Business
    {
        Class_Database data;
        DataTable dt = null;

        public Class_Business()
        {
            data = new Class_Database();
        }

        public bool Login(ref string err, string user, string pass)
        {
            dt = new DataTable();
          
            data.GetData_Login(ref err, "SELECT COUNT(*) FROM Accounts WHERE Username = '" + user + "' and UserPassword = '" + pass + "'").Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
                return true;
            return false;
        }

        public DataTable DataFields(ref string err, string query)
        {
            return data.GetData(ref err, query);
        }

        public void UpdateFields(ref string err, string query)
        {
            data.executeNonQuery(ref err, query);
        }

        public void Update_User(ref string err, string user, string sql)
        {
            data.executeNonQuery(ref err, "UPDATE Accounts SET " + sql + " WHERE UserName = '" + user + "'");
        }

        public string[] split_string(string x)
        {
            string[] tokens = x.Split(' ');
            return tokens;
        }

        public void Delete_User(ref string err, string x)
        {
            string sql = "";
            foreach (string item in split_string(x))
            {
                sql = "DELETE FROM Accounts WHERE ID=";
                if (item == null || item == "" || item== "10000000")
                {

                }
                else
                {
                    sql += "'" + item + "';";
                    data.executeNonQuery(ref err, sql);
                }
            }
        }

        public void Delete_Product(ref string err, string x)
        {
            string sql = "";
            foreach (string item in split_string(x))
            {
                sql = "DELETE FROM Products WHERE ProductID=";
                if (item == null || item == "")
                {

                }
                else
                {
                    sql += "'" + item + "';";
                    data.executeNonQuery(ref err, sql);
                }
            }
        }

        public string Get_Permission(string sql)
        {
            return data.GetSingleData("SELECT permission FROM Accounts WHERE ID = '" + sql + "'");
        }

        public void Set_Image(ref string err, string x)
        {
            data.executeNonQuery(ref err, x);
        }

        public void InsertToSQL(ref string err, string x)
        {
            data.executeNonQuery(ref err, x);
        }
    }
}

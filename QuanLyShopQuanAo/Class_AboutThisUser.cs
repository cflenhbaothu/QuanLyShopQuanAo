using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyShopQuanAo
{
    public class Class_AboutThisUser
    {
        Class_Database data = new Class_Database();

        public string get_FirstName(string user)
        {
            return data.GetSingleData("SELECT FirstName FROM Accounts WHERE UserName='" + user + "'");
        }

        public string get_LastName(string user)
        {
            return data.GetSingleData("SELECT LastName FROM Accounts WHERE UserName='" + user + "'");
        }

        public string get_Permission(string user)
        {
            string temp = string.Empty;
            temp = data.GetSingleData("SELECT Permission FROM Accounts WHERE UserName='" + user + "'");
            if (temp == "1") return "Admin";
            if (temp == "2") return "Staff";
            return "Guest";
        }

        public string get_UserName(string user)
        {
            return data.GetSingleData("SELECT UserName FROM Accounts WHERE UserName='" + user + "'");
        }

        public string get_Gender(string user)
        {
            string temp = string.Empty;
            temp = data.GetSingleData("SELECT Gender FROM Accounts WHERE UserName='" + user + "'");
            return temp;
        }

        public string get_UserID(string user)
        {
            return data.GetSingleData("SELECT ID FROM Accounts WHERE UserName='" + user + "'");
        }
    }
}

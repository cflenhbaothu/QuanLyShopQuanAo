using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyShopQuanAo
{
    class Class_Search
    {
        Class_Database data;

        public Class_Search()
        {
            data = new Class_Database();
        }

        public DataTable search_UserFields(ref string err, string query)
        {
            if (A_UName.ID_PERMISSON == 2)
            {
                return data.GetData(ref err, "EXEC [Search User With B] " + query);
            }
            else
            {
                return data.GetData(ref err, "EXEC [Search User With A] " + query);
            }
        }

        public DataTable search_ProductFields(ref string err, string query)
        {
            if (A_UName.ID_PERMISSON == 3)
            {
                return data.GetData(ref err, "EXEC [Search Product With C] " + query);
            }
            else
            {
                return data.GetData(ref err, "EXEC [Search Product With A] " + query);
            }
        }
    }
}

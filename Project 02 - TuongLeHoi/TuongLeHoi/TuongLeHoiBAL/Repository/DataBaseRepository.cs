using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuongLeHoi.DAL.Repository
{
    public class DataBaseRepository
    {
        protected IDbConnection connect;
        public DataBaseRepository()
        {
            string connectString = @"Data Source=DESKTOP-OB38UR8\QUANGHUY;Initial Catalog=CSDL Tuong_LeHoi;Integrated Security=True";
            connect = new SqlConnection(connectString);
        }
    }
}

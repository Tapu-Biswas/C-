using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Data_Access_Layer
{
    class LoginDataAccess:DataAccess
    {
        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Employees WHERE EmployeeUsername='" + username + "' AND EmployeePassword='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
    }
}

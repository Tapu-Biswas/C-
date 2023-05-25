using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Data_Access_Layer
{
    class EmployeeDataAccess : DataAccess
    {
        public List<Employee> GetAllEmployees()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.EmployeeUsername = reader["EmployeeUsername"].ToString();
                employee.EmployeeEmail = reader["EmployeeEmail"].ToString();
                employee.EmployeePassword = reader["EmployeePassword"].ToString();
                employee.EmployeeAddress = reader["EmployeeAddress"].ToString();
                employee.EmployeePhoneNumber = reader["EmployeePhoneNumber"].ToString();
                employee.EmployeeBloodGroup = reader["EmployeeBloodGroup"].ToString();
                employee.EmployeeDateofBirth = reader["EmployeeDateofBirth"].ToString();
                employee.EmployeeGender = reader["EmployeeGender"].ToString();
                employee.EmployeeDesignation = reader["EmployeeDesignation"].ToString();
                employee.EmployeeSalary = reader["EmployeeSalary"].ToString();
                employee.EmployeeHireDate = reader["EmployeeHireDate"].ToString();
                employees.Add(employee);
            }
            return employees;
        }

        public List<Employee> GetEmployeeDetailsById(int employeeId)
        {
            string sql = "SELECT * FROM Employees WHERE EmployeeId=" + employeeId;
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.EmployeeUsername = reader["EmployeeUsername"].ToString();
                employee.EmployeeEmail = reader["EmployeeEmail"].ToString();
                employee.EmployeePassword = reader["EmployeePassword"].ToString();
                employee.EmployeeAddress = reader["EmployeeAddress"].ToString();
                employee.EmployeePhoneNumber = reader["EmployeePhoneNumber"].ToString();
                employee.EmployeeBloodGroup = reader["EmployeeBloodGroup"].ToString();
                employee.EmployeeDateofBirth = reader["EmployeeDateofBirth"].ToString();
                employee.EmployeeGender = reader["EmployeeGender"].ToString();
                employee.EmployeeDesignation = reader["EmployeeDesignation"].ToString();
                employee.EmployeeSalary = reader["EmployeeSalary"].ToString();
                employee.EmployeeHireDate = reader["EmployeeHireDate"].ToString();
                employees.Add(employee);
            }
            return employees;
        }

        public bool DeleteEmployee(int employeeId)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeId=" + employeeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddEmployee(Employee employee)
        {
            string sql = "INSERT INTO Employees(EmployeeName,EmployeeUsername,EmployeeEmail,EmployeePassword,EmployeeAddress,EmployeePhoneNumber,EmployeeBloodGroup,EmployeeDateofBirth,EmployeeGender,EmployeeDesignation,EmployeeSalary,EmployeeHireDate) VALUES('" + employee.EmployeeName + "','" + employee.EmployeeUsername + "','" + employee.EmployeeEmail + "','" + employee.EmployeePassword + "','" + employee.EmployeeAddress + "','" + employee.EmployeePhoneNumber + "','" + employee.EmployeeBloodGroup + "','" + employee.EmployeeDateofBirth + "','" + employee.EmployeeGender + "','" + employee.EmployeeDesignation + "','" + employee.EmployeeSalary + "','" + employee.EmployeeHireDate + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateEmployee(int employeeId, string employeeName, string employeeUsername, string employeeEmail, string employeePassword, string employeeAddress, string employeePhoneNumber, string employeeBloodGroup, string employeeDateOfBirth, string employeeGender, string employeeDesignation, string employeeSalary, string employeeHireDate)
        {
            string sql = "UPDATE Employees SET EmployeeName='" + employeeName + "',EmployeeUsername= '" + employeeUsername + "',EmployeeEmail= '" + employeeEmail + "',EmployeePassword= '" + employeePassword + "',EmployeeAddress= '" + employeeAddress + "',EmployeePhoneNumber= '" + employeePhoneNumber + "',EmployeeBloodGroup= '" + employeeBloodGroup + "',EmployeeDateofBirth= '" + employeeDateOfBirth + "',EmployeeGender= '" + employeeGender + "',EmployeeDesignation= '" + employeeDesignation + "',EmployeeSalary= '" + employeeSalary + "',EmployeeHireDate= '" + employeeHireDate + "' WHERE EmployeeId=" + employeeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Data_Access_Layer
{
    class CustomerDataAccess: DataAccess
    {
        public List<Customer> GetAllCustomers()
        {
            string sql = "SELECT * FROM Customers";
            SqlDataReader reader = this.GetData(sql);
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = (int)reader["CustomerId"];
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.CustomerUsername = reader["CustomerUsername"].ToString();
                customer.CustomerEmail = reader["CustomerEmail"].ToString();
                customer.CustomerPassword = reader["CustomerPassword"].ToString();
                customer.CustomerDateofBirth = reader["CustomerDateofBirth"].ToString();
                customer.CustomerGender = reader["CustomerGender"].ToString();
                customers.Add(customer);
            }
            return customers;
        }

        public List<Customer> GetCustomerDetailsById(int customerId)
        {
            string sql = "SELECT * FROM Customers WHERE CustomerId=" + customerId;
            SqlDataReader reader = this.GetData(sql);
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = (int)reader["CustomerId"];
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.CustomerUsername = reader["CustomerUsername"].ToString();
                customer.CustomerEmail = reader["CustomerEmail"].ToString();
                customer.CustomerPassword = reader["CustomerPassword"].ToString();
                customer.CustomerDateofBirth = reader["CustomerDateofBirth"].ToString();
                customer.CustomerGender = reader["CustomerGender"].ToString();
                customers.Add(customer);
            }
            return customers;
        }

        public bool DeleteCustomer(int customerId)
        {
            string sql = "DELETE FROM Customers WHERE CustomerId=" + customerId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddCustomer(Customer customer)
        {
            string sql = "INSERT INTO Customers(CustomerName,CustomerUsername,CustomerEmail,CustomerPassword,CustomerDateofBirth,CustomerGender) VALUES('" + customer.CustomerName + "','" + customer.CustomerUsername + "','" + customer.CustomerEmail + "','" + customer.CustomerPassword + "','" + customer.CustomerDateofBirth + "','" + customer.CustomerGender +"')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCustomer(int customerId, string customerName,string customerUserName,string customerEmail, string customerPassword, string customerDateofBirth, string CustomerGender)
        {
            string sql = "UPDATE Customers SET CustomerName='" + customerName  + "',CustomerUsername= '"+ customerUserName + "',CustomerEmail= '" + customerEmail + "',CustomerPassword= '" + customerPassword + "',CustomerDateofBirth= '" + customerDateofBirth + "',CustomerGender= '" + CustomerGender + "' WHERE CustomerId=" + customerId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}

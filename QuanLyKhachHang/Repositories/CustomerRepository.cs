using QuanLyKhachHang.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang.Repositories
{
    public class CustomerRepository
    {
        private readonly string connectionString = "Server=.;Database=Data_LapTrinh_De11;Integrated Security=True;";

        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.ToString());
            }
            return customers;
        }
    }
}

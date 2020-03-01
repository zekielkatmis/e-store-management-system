using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Customers:Person
    {
        string customerId;
        string address;
        string customerDetails;
        double purchases;

        public Customers()
        {

        }

        public Customers(string customerId, string address, string customerDetails, double purchases,string name, string email, string password)
        : base(name, email, password)
        {
            this.customerId = customerId;
            this.address = address;
            this.customerDetails = customerDetails;
            this.purchases = Purchases;
        }

        public string CustomerId { get => customerId; set => customerId = value; }
        public string Address { get => address; set => address = value; }
        public string CustomerDetails { get => customerDetails; set => customerDetails = value; }
        public double Purchases { get => purchases; set => purchases = value; }

        public override int Login(string email, string password)
        {
            string query = string.Format("SELECT * FROM Customers WHERE " +
                "EMAIL = '{0}' AND PASSWORD = '{1}'", email, password);

            DataAcess da = new DataAcess();
            DataTable dt = da.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public DataTable ListCustomers()
        {
            try
            {
                string query = "select * from customers";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddCustomers(Customers c)
        {
            try
            {
                string query = string.Format("INSERT INTO Customers(name,email,password,id,address,details) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", c.Name, c.Email, c.Password, c.CustomerId, c.Address, c.CustomerDetails);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateCustomers(Customers c)
        {
            try
            {
                string query = string.Format("UPDATE Customers set name='{0}', email = '{1}',password = '{2}', address='{3}', details = '{4}'" +
                    " WHERE id = {5}", c.Name, c.Email, c.Password, c.Address, c.CustomerDetails,c.customerId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteCustomers(string id)
        {
            try
            {
                string query = string.Format("DELETE FROM  customers " +
                    " WHERE id = {0}", id);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*public double Cart(Customers c, double cart)
        {
            try
            {
                string query = string.Format("SELECT purchase FROM Customers WHERE email='{0}'", c.Email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/

    }
}

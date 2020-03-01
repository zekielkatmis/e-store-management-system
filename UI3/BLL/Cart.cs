using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Cart
    {
        string name;
        double price;
        string detail;

        public Cart()
        {

        }

        public Cart(string name, double price, string detail)
        {
            this.name = name;
            this.price = price;
            this.detail = detail;
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Detail { get => detail; set => detail = value; }

        public DataTable ListCart()
        {
            try
            {
                string query = "select * from cart";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddtoCart(Cart c)
        {
            try
            {
                string query = string.Format("INSERT INTO cart (name,price,detail) " +
                    "VALUES('{0}','{1}','{2}')", c.name, c.price, c.detail);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable cleanTable()
        {
            try
            {
                string query = "DELETE FROM cart";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable sum()
        {
            try
            {
                string query = "SELECT sum(price) as 'total' FROM cart";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

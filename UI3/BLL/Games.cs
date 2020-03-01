using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Games:Products
    {
        string memoryRequired;
        string type = "Game";
        public Games(string memoryRequired,string Details, string ProductId, string ProductName, string Price)
        : base(ProductId, ProductName, Price, Details)
        {
            this.memoryRequired = memoryRequired;
        }
        public string MemoryRequired { get => memoryRequired; set => memoryRequired = value; }

        public Games()
        {

        }

        public DataTable ListGames()
        {
            try
            {
                string query = "select * from games";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddGames(Games g)
        {
            try
            {
                string query = string.Format("INSERT INTO games (id,name,price,detail,memoryr,type) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", g.ProductId1, g.ProductName1, g.Price1, g.Details1, g.MemoryRequired, type);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateProduct(string type, string name, string price, string detail, string id)
        {
            try
            {
                string query = string.Format("UPDATE {0} set name='{1}', price = '{2}',detail = '{3}'" +
                    " WHERE id = {4}", type, name, price, detail, id);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteProduct(string type, string id)
        {
            try
            {
                string query = string.Format("DELETE FROM  {0} " +
                    " WHERE id = {1}", type, id);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Consoles:Products
    {
        string driveType;
        string type = "Console";

        public Consoles(string driveType, string Details, string ProductId, string ProductName, string Price)
        : base(ProductId, ProductName, Price, Details)
        {
            this.driveType = driveType;
        }

        public string DriveType { get => driveType; set => driveType = value; }

        public Consoles()
        {

        }

        public DataTable ListConsoles()
        {
            try
            {
                string query = "select * from consoles";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddConsoles(Consoles c)
        {
            try
            {
                string query = string.Format("INSERT INTO consoles (id,name,price,detail,driveType,type) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", c.ProductId1, c.ProductName1, c.Price1, c.Details1, c.DriveType, type);
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

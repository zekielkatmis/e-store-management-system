using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Accessories:Products
    {
        string picturePath = "";

        string type = "Accessory";

        public string PicturePath { get => picturePath; set => picturePath = value; }

        public Accessories(string ProductId, string ProductName, string Price, string Details, string path="")
        : base(ProductId, ProductName, Price, Details)
        {
            this.picturePath = path;
        }
        public Accessories()
        {

        }
        public DataTable ListAccessories()
        {
            try
            {
                string query = "select * from accessories";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddAccessories(Accessories a)
        {
            try
            {
                string query = string.Format("INSERT INTO accessories (id,name,price,detail,type,picture) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", a.ProductId1, a.ProductName1, a.Price1, a.Details1, type, a.picturePath);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public abstract class Products
    {
        string ProductId;
        string ProductName;
        string Price;
        string Details;

        public Products()
        {

        }

        public Products(string ProductId, string ProductName, string Price, string Details)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Details = Details;
        }

        public string ProductId1 { get => ProductId; set => ProductId = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public string Price1 { get => Price; set => Price = value; }
        public string Details1 { get => Details; set => Details = value; }
    }
}

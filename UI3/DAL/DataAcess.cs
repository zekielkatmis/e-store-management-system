using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;

namespace DAL
{
  public  class DataAcess
    {
        private string conString = "";
        // for establishing connection
        private SQLiteConnection con = null;
        // for executing SQL
        private SQLiteCommand cmd=null;

        public DataAcess()
        {
            conString = @"data source=C:\Users\Gorucu\Desktop\Data\Customers.db";
            con = new SQLiteConnection(conString);
            cmd = new SQLiteCommand(con);
        }
        // SELECT
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                // read data from database and put it int a datatable

                DataTable dt = new DataTable();
                //execute the adapter on cmd object
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                // reads data and put in dt

                adapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error in ExecuteQuery");
            }

        }

        // INSERT, UPDATE OR DELETE

        public int ExecuteNonQuery(string query)
        {
            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error in ExecuteNonQuery");
            }

        }
    }
}

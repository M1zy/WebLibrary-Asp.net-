using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace course.DataAccess
{
    public class ProductDAO :interfaces.IProduct
    {
        private Db db;
 
        public void InsertProduct(course.Business_Layer.product p)
        {
            db = new Db();
            string insert = "insert into [product](product_name, product_description, product_pages, product_Text,product_image,product_brand,product_author,product_category,product_pdf,product_added,product_developer)" +
                " values('"+p.name+"','"+p.description+"','"+p.pages+"','"+p.text+"','"+p.image+"','"+p.type+"','"+p.author+"','"+p.category+ "','" + p.pdf + "','" + p.added +"','"+p.developer + "')";
            db.executecommand(insert);
        }
        public void DeleteProduct(int i)
        {
            db = new Db();
            string sql =
 "DELETE FROM [product] where Id = '"+i+"'" ;

            db.executecommand(sql);
        }

        public int GetProductId(course.Business_Layer.product p)
        {
            db = new Db();
            string sql = "SELECT Id" +
 "FROM product WHERE product_name='"+p.name+"'";
            int d = db.executecommand(sql).ExecuteNonQuery();
            return d;
        }

        public DataTable searchById(string _id)
        {
            db = new Db();
            string query = "select * from [product] where Id='" + _id + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = db.executecommand(query);
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            
            return dataTable;
        }
        public DataTable searchCart(string user,int product_id)
        {
            db = new Db();
            string query = "select * from [cart] where product='" + product_id + "' and email='"+user+"'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = db.executecommand(query);
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void UpgradeRate(int id,int cRate,string Username)
        {
            db = new Db();
            course.Business_Layer.productBU productBU = new Business_Layer.productBU();
            Business_Layer.product p = productBU.GetProductbyID(id.ToString()) ;
            
            double rate = Math.Round(p.rate,2);
            if (p.votes != 0) rate = Math.Round(p.rate * p.votes,2);
            if (ExistVote(id, Username)) { 
                double brate = double.Parse(productBU.Rate_cart(Username, id));
                rate -= brate; p.votes--; }
                p.votes++;
            double result = (Math.Round(rate,2) + cRate) / p.votes;
            p.rate = Math.Round(result,2);
            string sql = "update [product] set product_Rate='" + p.rate.ToString() + "', product_votes='" + p.votes.ToString() + "'  where Id='" + id.ToString() + "'";
            db.executecommand(sql);
        }
        public bool ExistVote(int id,string Username)
        {
            
            string sql = "select * from cart where cart.product='" + id.ToString() + "' and cart.email='" + Username + "'";
            SqlCommand cmd = db.executecommand(sql);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count == 0) return false;
            return true;

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace course.Business_Layer
{
    public class productBU
    {
        private DataAccess.ProductDAO productDAO;
        public productBU()
        {
            productDAO = new DataAccess.ProductDAO();
        }
        public product GetProductbyID(string _id)
        {
            product product = new product();
            DataTable data = new DataTable();
            data = productDAO.searchById(_id);
            foreach (DataRow dr in data.Rows)
            {
                product.id = Int32.Parse(dr["Id"].ToString());
                product.name= dr["Product_name"].ToString();
                product.author= dr["Product_author"].ToString();
                product.image= dr["Product_image"].ToString();
                product.description = dr["Product_description"].ToString();
                product.pages = float.Parse(dr["product_pages"].ToString());
                product.type = dr["Product_brand"].ToString();
                product.pdf= dr["Product_pdf"].ToString();
                product.votes = Int32.Parse(dr["Product_votes"].ToString());
                product.added = Int32.Parse(dr["Product_added"].ToString());
               
                product.category = dr["Product_category"].ToString();
                product.text = dr["Product_Text"].ToString();
                product.rate = double.Parse(dr["Product_Rate"].ToString());
                product.developer= dr["Product_developer"].ToString();
            }
            return product;
        }
        public string Rate_cart(string username,int product_id)
        {
            string Rate = "";
            DataTable data = new DataTable();
            data = productDAO.searchCart(username,product_id);
            foreach (DataRow dr in data.Rows)
            {
                Rate = dr["c_Rate"].ToString();
            }
            return Rate;
        }



    }
}
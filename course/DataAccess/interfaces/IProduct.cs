using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.DataAccess.interfaces
{
   public interface IProduct
    {
        void InsertProduct(course.Business_Layer.product product);

        void DeleteProduct(int id);


    }
}

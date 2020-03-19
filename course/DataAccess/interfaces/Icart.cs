using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace course.DataAccess.interfaces
{
    public interface Icart
    {
         void Addproduct(int id,string session);

        bool isExist(int id, string session);

        void Deleteproduct(int id, string session);
    }
}
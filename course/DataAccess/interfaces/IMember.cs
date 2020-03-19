using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace course.DataAccess.interfaces
{
    public interface IMember
    {
        void InsertMember(course.Business_Layer.Member member);
         bool IsExistMember(course.Business_Layer.Member member);
         DataTable searchById(string _id);
    }
}
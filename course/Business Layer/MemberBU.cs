using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace course.Business_Layer
{
    public class MemberBU
    {
        private DataAccess.MemberDao memberDao;
        public MemberBU()
        {
            memberDao = new DataAccess.MemberDao();
        }
        public Member GetMemberbyID(string _id)
        {
            Member member = new Member();
            DataTable data = new DataTable();
            data = memberDao.searchById(_id);
            foreach (DataRow dr in data.Rows)
            {
                member.id = Int32.Parse(dr["Id"].ToString());
                member.firstname = dr["firstname"].ToString();
                member.lastname = dr["lastname"].ToString();
                member.email = dr["email"].ToString();
                member.password = dr["password"].ToString();
                member.address = dr["address"].ToString();
                member.mobile = dr["mobile"].ToString();
            }
            return member;
        }
    }
}
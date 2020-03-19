using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace course.Business_Layer
{
    public class Member
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string mobile { get; set; }
        public string error { get; set; }
        public Member() { }
        public Member(string firstname, string lastname, string email, string password, string address, string mobile)
        {

                this.firstname = firstname; this.lastname = lastname; this.email = email; this.password = password;
            this.address = address; this.mobile = mobile;
            Verification();

    }
         void Verification()
        {
            Rules.MemberVerification verification = new Rules.MemberVerification();
            error = verification.Verification(this);
        }
}
}
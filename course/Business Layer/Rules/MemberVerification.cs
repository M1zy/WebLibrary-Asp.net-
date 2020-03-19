using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace course.Business_Layer.Rules
{
    public class MemberVerification
    {
        public MemberVerification()
        {

        }
        public string Verification(Member member)
        {
            string error = "";
            error += veriEmail(member.email)+veriMobile(member.mobile);
            return error;

        }
         string veriEmail(string email)
        {

            bool isEmail = Regex.IsMatch(email, @"\A(?:[A-Za-z0-9!#$%&'*+/=?^_'{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_'{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?)\Z");

            if (!isEmail)
            {
                return "email is invalid; ";
            }
            return "";
        }

        string veriMobile(string mobile)
        {
            if (!Regex.IsMatch(mobile, @"^(\+375|80)(29|25|44|33)(\d{3})(\d{2})(\d{2})$"))
            {
                return "mobile is invalid; ";
            }
            return "";
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;

namespace course.Business_Layer.Rules
{
    public class productVerification
    {
        public productVerification()
        {

        }
        public string Verification(product product)
        {
            string error = "";
            string text_length = veriLength(product.text, 10);
            string name_length = veriLength(product.name, 3);
            error += text_length+name_length;
            return error;

        }
        string veriLength(string propertyname, int length)
        {
            if (IsStringInvalid(propertyname, length)) return ((propertyname) + " has invalid length; ");
            else return "";
        }

        public bool IsStringInvalid(string text,int length)
        {
            return string.IsNullOrEmpty(text) ||
                text.Length <= length;
        }
    }
}
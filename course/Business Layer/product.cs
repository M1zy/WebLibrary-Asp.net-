using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace course.Business_Layer
{
    public class product
    {
        
        
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float pages { get; set; }
        public string  text { get; set; }
        public string image { get; set; }
        public string type { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public string error { get; set; }

        public double rate { get; set; }
        public string pdf { get; set; }

        public int votes { get; set; }
        public int added { get; set; }

        public string developer { get; set; }
        public product(){
        
            }
        public product(string name, string description, string pages, string text, string image, string type,string author, string category, string pdf, int added,string developer)
        {
            try {
                error = "";
                this.name = name; this.description = description; this.pages = float.Parse(pages); this.text = text; this.image = image; this.pdf = pdf;this.developer = developer;
                this.type = type;this.author = author;this.category = category; this.added = added;
                Verification();
            }
            catch { error = "invalid input of data"; }
            }
        void Verification()
        {
            Rules.productVerification verification = new Rules.productVerification();
            error += verification.Verification(this);
        }

        


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    class seller
    {
        public int sid;
        public string password;
        public string sname;
        public string email;
        public string postalAddress;
        public string GSTIN;
        public String Bankdetails;
        public seller(int sid, string password, string sname, string email, string postalAddress, string GSTIN, string Bankdetails)
        {
            this.sid = sid;
            this.password = password;
            this.sname = sname;
            this.email = email;
            this.postalAddress = postalAddress;
            this.GSTIN = GSTIN;
            this.Bankdetails = Bankdetails;

        }

    }
}
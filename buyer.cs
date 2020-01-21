using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CaseStudy_consoleApplication
{
    class buyer
    {
        public int bid { get; set; }
        public string bname { get; set; }
        public string Password { get; set; }
        public double mobile { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public buyer(int bid, string bname, string Password, double mobile, string Email, DateTime CreatedDate)
        {
            this.bid = bid;
            this.bname = bname;
            this.CreatedDate = CreatedDate;
            this.Email = Email;
            this.Password = Password;
            this.mobile = mobile;

        }





    }


}
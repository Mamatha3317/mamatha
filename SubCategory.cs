using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    public class SubCategory : Category
    {
        public int sbid;
        public string sbname;
        public float GST;
        public SubCategory(int sbid, int cid, string cname, string sbname, string details, float GST)
        {
            this.sbid = sbid;
            this.sbname = sbname;
            this.cname = cname;
            this.cid = cid;
            this.details = details;
            this.GST = GST;


        }



    }
}
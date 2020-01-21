using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    public class Items
    {
        public int iid;
        public double price;
        public string itemname;
        public string description;
        public int stock_number;
        public string remarks;
        public int sid;
        public SubCategory sbo;

        public Items(int iid, double price, string itemname, string description, int stock_number, string remarks, int sid, SubCategory sco)
        {
            this.iid = iid;
            this.price = price;
            this.itemname = itemname;
            this.description = description;
            this.stock_number = stock_number;
            this.remarks = remarks;
            this.sid = sid;
            this.sbo = sco;

        }

    }
}
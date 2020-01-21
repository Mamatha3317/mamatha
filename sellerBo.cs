using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    public class sellerBo
    {
        static List<seller> slist = new List<seller>();
        List<Items> li = new List<Items>();
        static int sellerid;
        List<SubCategory> lsc = new List<SubCategory>();

        public void InitializeSellerList(int sid, string password, string sname, string email, string postalAddress, string GSTIN, string Bankdetails)
        {

            slist.Add(new seller(sid, password, sname, email, postalAddress, GSTIN, Bankdetails));


        }

        public bool checkseller(int sid, string password)
        {

            seller so = slist.Find(e => e.sid == sid && e.password == password);
            if (so != null)
            {
                sellerid = sid;
                return true;
            }
            else
            {

                return false;
            }
        }
        public void DisplayDetailsseller(int sid)
        {
            seller sell = slist.Find(e => e.sid == sid);
            Console.WriteLine("Details...............");
            Console.WriteLine("Id : " + sell.sid);
            Console.WriteLine("Name : " + sell.sname);
            Console.WriteLine("Email  : " + sell.email);
            Console.WriteLine("Company address : " + sell.postalAddress);
            Console.WriteLine("GSTIN : " + sell.GSTIN);
            Console.WriteLine("Bank Details  : " + sell.Bankdetails);

        }
        public void Displayproducts(int sid)
        {
            ItemsBO io = new ItemsBO();
            List<Items> tl1 = io.DisplaySellerProducts(sid);

            ////foreach (Category ij in lsc)
            ////{
            ////    Console.WriteLine("CategoryId :" + ij.cid + "   Category Name :" + ij.cname + "  Category Details :" + ij.details);

            ////}
            ////foreach (SubCategory ik in lsc)
            ////{


            ////    Console.WriteLine("SubCategory Id :" + ik.sbid + "  SubCategory Name :" + ik.sbname + "   SubCategory Desc :" + ik.details); ;

            ////}

            foreach (Items j in tl1)
            {


                Console.WriteLine("Item Id :" + j.iid + "  IteamNeam  :" + j.itemname + "   stocknumber :" + j.stock_number + "   price :" + j.price + "   remarks :" + j.remarks + "\n" +
                    j.sbo.cid + " Category name :" + j.sbo.cname + " category details :" + j.sbo.details);

            }
        }
    }
}

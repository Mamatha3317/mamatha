using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    public class ItemsBO
    {
        static List<Items> li = new List<Items>();
        static List<SubCategory> lsc = new List<SubCategory>();
        public void Additems(int cid, string cname, int sbid, string sbname, string details, float GST, int iid, string itemname, double price, string description, int stock_number, string remarks, int sid)
        {
            SubCategory sco = new SubCategory(sbid, cid, cname, sbname, details, GST);
            lsc.Add(sco);
            Items i = new Items(iid, price, itemname, description, stock_number, remarks, sid, sco);
            li.Add(i);
            Console.Write("The items added are : \n");
            foreach (Category ij in lsc)
            {
                Console.WriteLine("CategoryId :" + ij.cid + "   Category Name :" + ij.cname + "  Category Details :" + ij.details);

            }
            foreach (SubCategory ik in lsc)
            {


                Console.WriteLine("SubCategory Id :" + ik.sbid + "  SubCategory Name :" + ik.sbname + "   SubCategory Desc :" + ik.details); ;

            }


            foreach (Items j in li)
            {


                Console.WriteLine("Item Id :" + j.iid + "  ItemNeam  :" + j.itemname + "   stocknumber :" + j.stock_number + "   price :" + j.price + "   remarks :" + j.remarks);

            }
        }

        public List<Items> DisplaySellerProducts(int sellerid)
        {
            List<Items> tp = li.Where(e => e.sid == sellerid).ToList();
            return tp;
        }
        public void DisplaybuyerProducts()
        {

            Console.WriteLine("Category Id \t Category Name \t  Category Desc");
            foreach (Category i in lsc)
            {
                Console.WriteLine(i.cid + "\t\t" + i.cname + "\t\t" + i.details);
            }
            Console.WriteLine("Enter Cid for which you want to go to Subcategory");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("SubCategory Id \t\t SubCategory Name  \t \t SubCategory Desc");

            foreach (SubCategory i in lsc)
            {
                if (i.cid == ch)
                {

                    Console.WriteLine(i.sbid + "\t\t" + i.sbname + "\t\t" + i.details);
                }
            }
            Console.WriteLine("Enter scid for which you want to go to Items");
            int ch1 = int.Parse(Console.ReadLine());
            foreach (Items jk in li)
            {
                if (jk.iid == ch1)
                {

                    Console.WriteLine("Item id :" + jk.iid + "\t\tItem name :" + jk.itemname + "\t\tItem price :" + jk.price + "\t\tStock number :" + jk.stock_number + "\t\tItem Description :" + jk.remarks);
                }
            }
        }

        public void SearchByName()
        {
            int flag = 0;
            string s = "";
            Console.WriteLine("Enter Item Name that you want to search");
            String name = Console.ReadLine();
            foreach (Items i in li)
            {

                if (i.itemname == name)
                {
                    s = "Item Id : " + i.iid + "\t\t Item Name : " + i.itemname + "  \t\t Item Price : " + i.price + "\t stock number : " + i.stock_number + " \t Item Description:" + i.remarks;

                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;

                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {

                Console.WriteLine(s);
            }
        }


        public void SearchById()
        {
            int flag = 0;
            string s = "";
            Console.WriteLine("Enter Item ID that you want to search");
            int id = int.Parse(Console.ReadLine());
            foreach (Items i in li)
            {

                if (i.iid == id)
                {

                    s = "Item Id : " + i.iid + "\t\t Item Name : " + i.itemname + " \t \t Item Price : " + i.price + "\t\t stock number : " + i.stock_number + " \t\t Item Description:" + i.remarks;

                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;

                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {

                Console.WriteLine(s);
            }
        }
        public void SearchByPrice()
        {
            Console.WriteLine("Enter Item price range  that you want to search:");
            Console.WriteLine("Enter minimum price :");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter maximum price :");
            int max = int.Parse(Console.ReadLine());
            int flag = 0;
            string s = "";
            foreach (Items i in li)
            {

                if (i.price > min && i.price < max)
                {
                    s += "Item Id : " + i.iid + "\t Item Name : " + i.itemname + "  \t Item Price : " + i.price + "\t stock number : " + i.stock_number + " \t Item Description:" + i.remarks + "\n";

                    flag = 0;

                }
                else
                {
                    flag = 1;

                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {
                Console.WriteLine(s);
            }
        }

        public void SearchByCategory()
        {
            int flag = 0;
            string s = "";
            Console.WriteLine("Enter Item Category that you want to search");
            String name = Console.ReadLine();
            foreach (Category scb in lsc)
            {

                if (scb.cname == name)
                {

                    foreach (Items i in li)
                        s = "Item Id : " + i.iid + "\t Item Name : " + i.itemname + "  \t Item Price : " + i.price + "\t stock number : " + i.stock_number + " \t Item Description:" + i.remarks;

                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {

                Console.WriteLine(s);
            }
        }


        public void BuyIteam()
        {
            int flag = 0;
            string s = "";
            Console.WriteLine("Enter Item Name to Buy :");
            String name = Console.ReadLine();
            foreach (Items i in li)
            {

                if (i.itemname == name)
                {

                    // Console.WriteLine("Item Id : " + i.iid + "\t Item Name : " + i.itemname + "  \t Item Price : " + i.price + "\t stock number : " + i.stock_number + " \t Item Description:" + i.remarks);
                    // foreach (Items i in li)
                    s = "Item Id : " + i.iid + "\n Item Name : " + i.itemname + "  \n Item Price : " + i.price + "\n stock number : " + i.stock_number + " \n Item Description:" + i.remarks;

                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                    //  Console.WriteLine("iteam not found");
                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {
                // Console.WriteLine("Item Id \t Item Name  \t Item Price\t stock number  \t Item Description");
                Console.WriteLine("purchased Iteam Details :\n");
                Console.WriteLine(s);
            }
        }



    }

}



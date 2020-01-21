using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaseStudy_consoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Program mainObj = new Program();
            buyerBo bb0 = new buyerBo();
            sellerBo sb0 = new sellerBo();
            ItemsBO ib0 = new ItemsBO();

            while (true)
            {

                Console.WriteLine("Select the user: \n 1.SELLER \n 2.BUYER \n 3.Admin");
                Console.WriteLine("choose option :");
                int opt = int.Parse(Console.ReadLine());
                bool status = true;
                switch (opt)
                {
                    case 1:
                        {
                            Console.WriteLine("1.Register \n 2.login");
                            int opt4 = int.Parse(Console.ReadLine());
                            int sid = 0;
                            switch (opt4)
                            {
                                case 1:

                                    Console.WriteLine("Enter id: ");
                                    sid = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter password:");
                                    string password = Console.ReadLine();

                                    Console.WriteLine("Enter  the name  :");
                                    string sname = Console.ReadLine();
                                    Console.WriteLine("enter mail:");
                                    string email = Console.ReadLine();

                                    Console.WriteLine("Enter GSTIN : ");
                                    string GSTIN = Console.ReadLine();

                                    Console.WriteLine("Enter postal address: ");
                                    string postalAddress = Console.ReadLine();
                                    Console.WriteLine("Enter Bank Details : ");
                                    string Bankdetails = Console.ReadLine();
                                    sb0.InitializeSellerList(sid, password, sname, email, postalAddress, GSTIN, Bankdetails);

                                    break;


                                case 2:
                                    Console.WriteLine("Enter id: ");
                                    sid = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter password:");
                                    string Password3 = Console.ReadLine();
                                    status = sb0.checkseller(sid, Password3);


                                    break;
                                default: break;

                            }
                            if (status == false)
                            {
                                Console.WriteLine("Please Enter  valid credentials.");
                                break;

                            }
                            while (true)
                            {
                                int flag = 0;
                                Console.WriteLine("----------------Seller Activities--------------------");
                                Console.WriteLine("\n 1.Display Profile \n 2.Add Items \n3.Display Items \n Enter Your option :");
                                int opt5 = int.Parse(Console.ReadLine());

                                switch (opt5)
                                {
                                    case 1:
                                        //Console.WriteLine("Enter seller Id");
                                        //sid = int.Parse(Console.ReadLine());
                                        sb0.DisplayDetailsseller(sid);
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter The Items by category and sub-Category  :");
                                        Console.WriteLine("Enter item Category id :");
                                        int cid = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter item Category Name :");
                                        string cname = Console.ReadLine();
                                        Console.WriteLine("Enter item sub-Category id :");
                                        int sbid = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter item sub-Category Name :");
                                        string sbname = Console.ReadLine();
                                        Console.WriteLine("Enter item Details :");
                                        string details = Console.ReadLine();
                                        Console.WriteLine("Enter the GST percentage on Category  :");
                                        float GST = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter item id :");
                                        int iid = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter item  Name :");
                                        string itemname = Console.ReadLine();
                                        Console.WriteLine("Enter item price :");
                                        double price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the item description :");
                                        string description = Console.ReadLine();
                                        Console.WriteLine("Enter stock number :");
                                        int stock_number = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter Remarks:");
                                        string remarks = Console.ReadLine();
                                        ib0.Additems(cid, cname, sbid, sbname, details, GST, iid, itemname, price, description, stock_number, remarks, sid);




                                        break;
                                    case 3:
                                        sb0.Displayproducts(sid);
                                        break;
                                    default:
                                        flag = 1;
                                        break;

                                }
                                if (flag == 1)
                                    break;
                            }
                            break;
                        }
                    //  break;




                    case 2:
                        {
                            Console.WriteLine("1.Register \n 2.login");
                            int opt3 = int.Parse(Console.ReadLine());
                            switch (opt3)
                            {
                                case 1:

                                    Console.WriteLine("Enter id: ");
                                    int bid = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter password:");
                                    string Password = Console.ReadLine();

                                    Console.WriteLine("Enter  the name  :");
                                    string bname = Console.ReadLine();
                                    Console.WriteLine("Enter mobile number");
                                    double mobile = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("enter mail:");
                                    string Email = Console.ReadLine();
                                    Console.WriteLine("Dateof Creation:");
                                    DateTime CreatedDate = Convert.ToDateTime(DateTime.Now);
                                    Console.WriteLine(CreatedDate);
                                    bb0.InitializeBuyersList(bid, bname, Password, mobile, Email, CreatedDate);
                                    bb0.displayCategory();
                                    Console.WriteLine("search Iteam by :\n 1.Iteam name  \n 2.Iteam ID \n 3.Search by price \n 4.search by Category\n");
                                    int opt5 = int.Parse(Console.ReadLine());

                                    int flag1 = 0;
                                    switch (opt5)
                                    {
                                        case 1:
                                            bb0.serchIteamByName();
                                            bb0.BuyProduct();
                                            break;
                                        case 2:
                                            bb0.serchIteamId();
                                            bb0.BuyProduct();

                                            break;
                                        case 3:
                                            bb0.serchIteamByPrice();
                                            bb0.BuyProduct();
                                            break;
                                        case 4:
                                            bb0.serchIteamByCategory();
                                            bb0.BuyProduct();
                                            break;


                                        default:

                                            flag1 = 1;
                                            break;
                                    }
                                    if (flag1 == 1)
                                        break;




                                    break;
                                case 2:
                                    Console.WriteLine("Enter id: ");
                                    int bid1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter password:");
                                    string Password1 = Console.ReadLine();
                                    status = bb0.checkbuyer(bid1, Password1);
                                    break;

                            }
                            if (status == false)
                            {
                                Console.WriteLine("Please  Enter valid credentials.");
                                break;

                            }

                            break;
                        }

                    default:
                        break;


                }

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    class buyerBo
    {
        ItemsBO ibo = new ItemsBO();

        static List<buyer> blist = new List<buyer>();

        public void InitializeBuyersList(int bid, string bname, string Password, double mobile, string Email, DateTime CreatedDate)
        {

            blist.Add(new buyer(bid, bname, Password, mobile, Email, CreatedDate));


        }
        public bool checkbuyer(int bid, string Password)
        {

            buyer bo = blist.Find(e => e.bid == bid && e.Password == Password);
            if (bo != null)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
        public void displayCategory()
        {
            ibo.DisplaybuyerProducts();
        }
        public void serchIteamByName()
        {
            ibo.SearchByName();
        }
        public void serchIteamId()
        {
            ibo.SearchById();
        }
        public void serchIteamByPrice()
        {
            ibo.SearchByPrice();
        }
        public void serchIteamByCategory()
        {
            ibo.SearchByCategory();
        }
        public void BuyProduct()
        {
            ibo.BuyIteam();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace Invoice
{

    public class Invoice
    {

        private int account;
        private string customer;
        private string provider;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        private string article;

        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public void CostCalculation(bool NeedEdv)
        {
            if (NeedEdv == true)
            {
                Console.WriteLine(Price * Quantity * (decimal)0.18);
            }
            else
            {
                Console.WriteLine(Price * Quantity);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBusinessLayer
{
    // makes it accessible
    public class Customer
    {
        //Member Variables for Customer
        public string customerName;
        public string customerAddress;
        public string customerContact;

        //A method which displays the Customer details
        public void MyProfile()
        {
            Console.WriteLine("Customer Name:" + customerName);
            Console.WriteLine("Customer Address:" + customerAddress);
            Console.WriteLine("Customer Contact:" + customerContact);
        }
    }
}

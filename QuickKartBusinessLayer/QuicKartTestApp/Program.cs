using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBusinessLayer;

namespace QuicKartTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer custObj = new Customer();

            custObj.customerName = "Fred";
            custObj.customerAddress = "Las Vegas";
            custObj.customerContact = "+1-231-34452";

            custObj.MyProfile();
        }
    }
}

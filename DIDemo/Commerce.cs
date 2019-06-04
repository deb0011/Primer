using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    class Commerce
    {
        public void Processor(Order order, Billing billing, Customer customer)
        {
            order.PlaceOrder();
            billing.ProcessBill();
            customer.CustomerUpdate();

            Console.WriteLine("All steps done. Your order has been placed");
            Console.ReadLine();
        }
    }
}

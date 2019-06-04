using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Commerce commerce = new Commerce();
            commerce.Processor(new Order(), new Billing(), new Customer());
        }
    }
}

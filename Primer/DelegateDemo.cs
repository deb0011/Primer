using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer
{
    public delegate string message(int num);

    class DelegateDemo
    {
        public void Processor()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine(ToString(EntryPoint, n));
                    break;
                case 2:
                    Console.WriteLine(ToString(ExitPoint, n));
                    break;
            }
            Console.ReadLine();
        }

        public string ToString(message msg,int n)
        {
            return msg(n);
        }

        public string EntryPoint(int n)
        {
            return "Entry point reached! " + n.ToString();
        }

        public string ExitPoint(int n)
        {
            return "Exit point reached! " + n.ToString();
        }
    }
}

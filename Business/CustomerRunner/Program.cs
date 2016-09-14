using System;
using System.Collections.Generic;
using System.Text;
using Business;
using System.IO;

namespace CustomerRunner
{
    class Program
    {
        public delegate void VoidDelegate();

        /*
         static event VoidDelegate MyEvent;
         * 
         * VoidDelegate x = new VoidDelegate(Ximpl);
         * MyEvent +=x;
         * 
         * MyEvnt("");
         * 
         * static void XImpl(string s){};
         */

        static void Main(string[] args)
        {
            /*
            CustomerGroup a = new CustomerGroup();
            CustomerGroup b = new CustomerGroup();
            Customer c = new Customer();
            c.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(c_PropertyChanged);

            c.Pay(100);
            c.Pay(10);
            c.Pay(1);

            a.AddCustomer(c);
            b.AddCustomer(c);
            a.AddCustomer(c);
            */

            Customer c = new Customer(Guid.NewGuid(), "Teszt ugyfel", null);
            c.Charge(42000.66m);

            CustomerDumper cd = new CustomerDumper();
            cd.Dump(c, Console.Out);

            FileStream fs = new FileStream("e.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            cd.Dump(c, sw);
            sw.Close();

            Console.ReadKey();

        }

        static void c_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Customer ts = sender as Customer;

            switch (e.PropertyName)
            {
                case "AccountBalance":
                    Console.WriteLine("account balance:" + " " + ts.AccountBalance.ToString());
                    break;
                case "Group":
                    if (ts.Group == null)
                        Console.WriteLine("group:" + "<undefined>");
                    else
                        Console.WriteLine("group:" + " " + ts.Group.Name);
                    break;
                default:
                    Console.WriteLine("Mas valtozott");
                    break;
            }

        }
    }
}

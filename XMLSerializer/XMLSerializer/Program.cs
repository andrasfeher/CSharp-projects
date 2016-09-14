using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace XMLSerializer
{
    [XmlType]
    public class Customer
    {
        //[XmlAttribute]
        public string Name;
        public string Address;

        public Customer()
        {
            Name = "Andras";
            Address = "Budapest";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer x = new XmlSerializer(typeof(Customer));
            using (Stream s = File.Create("dump.txt"))
            {
                x.Serialize(s, new Customer());
            }
        }
    }
}

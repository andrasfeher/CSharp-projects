using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node("0");
            Node rootNode = n;
            
            Node c1 = new Node("1");
            Node c2 = new Node("2");

            n.AddChild(c1);
            n.AddChild(c2);

            n = c1;
            n.AddChild(new Node("1.1"));
            n.AddChild(new Node("1.2"));

            n = c2;
            Node c3 = new Node("2.2");
            n.AddChild(new Node("2.1"));
            n.AddChild(c3);

            n = c3;
            n.AddChild(new Node("2.2.1"));
            n.AddChild(new Node("2.2.2"));


            Console.WriteLine("Deep");

            DeepTreeTraveller dtt = new DeepTreeTraveller(rootNode);

            foreach (Node nd in dtt.DoTravelTree())
                Console.WriteLine(nd.Id);

            Console.WriteLine("");
            Console.WriteLine("Wide");

            WideTreeTraveller wtt = new WideTreeTraveller(rootNode);

            foreach (Node nd in wtt.DoTravelTree())
                Console.WriteLine(nd.Id);

        
        }
    }
}

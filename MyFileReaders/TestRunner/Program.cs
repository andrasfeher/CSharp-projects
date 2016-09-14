using System;
using System.Collections.Generic;
using System.Text;
using MyFileReaders;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] record;

            using (CSVReader csv = new CSVReader("c:\\test.txt"))
            {
                while ((record = csv.ReadRecord()) != null)
                {
                    Console.WriteLine(record[0] + ":" + record[1]);
                }
            }
        }
    }
}

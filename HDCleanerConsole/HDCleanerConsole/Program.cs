using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.IO;

namespace HDCleanerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid='c:'");
            disk.Get();
            
            long freeSpace = Convert.ToInt64(disk["FreeSpace"].ToString());

            for (int i = 0; i < 7; i++)
            {
                StreamWriter sw = new StreamWriter("c:\\xx.txt");

                StringBuilder sb = new StringBuilder();

                for (int k = 0; k < 1000; k++)
                    sb.Append(rnd.Next(10));

                for (long j = 0; j < (freeSpace / 1000); j++)
                    sw.Write(sb);

                sw.Close();

                Console.WriteLine( (i + 1).ToString() + "/7" );
            }

            File.Delete("c:\\xx.txt");

            Console.WriteLine("Vége");
            Console.ReadKey();
        }
    }
}

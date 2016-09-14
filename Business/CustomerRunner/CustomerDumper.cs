using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Business;
using System.Globalization;


namespace CustomerRunner
{
    class CustomerDumper
    {
        public void Dump(Customer c, TextWriter sw)
        {
            /*IFormatProvider provider = CultureInfo.GetCultureInfo("fr-Fr");
            sw.WriteLine(String.Format(provider,"{0}: {1}", "Id", c.Id));
            sw.WriteLine(String.Format(provider,"{0}: {1}", "Name", c.Name));
            sw.WriteLine(String.Format(provider,"{0}: {1:0.0000}", "AccountBalance", c.AccountBalance));
            sw.WriteLine(String.Format(provider,"{0}: {1:D}", "LastActivityDate", c.LastActivityDate));
             */

            sw.WriteLine(String.Format("{0}: {1}", "Id", c.Id));
            sw.WriteLine(String.Format("{0}: {1}", "Name", c.Name));
            sw.WriteLine(String.Format("{0}: {1:0.0000}", "AccountBalance", c.AccountBalance));
            sw.WriteLine(String.Format("{0}: {1:D}", "LastActivityDate", c.LastActivityDate));
            
        }

        public void Read(Customer c, TextReader sr)
        {
            string[] record = new string[2];

            string s = sr.ReadLine();

            while (!String.IsNullOrEmpty(s) )
            {
                record=s.Split(new char[] {':'}, 2);
                string value = record[1].Trim();

                switch ( record[0] )
                {
                    case "Id" :
                        c.Id = new Guid(value);
                        break;
                    case "Name" :
                        c.Name = value;
                        break;
                    case "AccountBalance" :
                        try
                        {
                            c.AccountBalance = Decimal.Parse(value);
                        }
                        catch ( Exception e )
                        {
                            Console.Error.WriteLine("AccBalanceError:" + value + "because: " +e.Message);
                        }
                        break;
                    case "LastActivityDate" :
                        DateTime dt;
                        if (DateTime.TryParse(value, out dt) )
                        {
                            c.LastActivityDate = dt;
                        }
                    break;
                }

                s = sr.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DateTmeInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime from = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime to = DateTime.Now; // TODO: Initialize to an appropriate value
            DateTimeInterval dti = new DateTimeInterval(from, to);
        }
    }
}

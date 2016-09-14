// felsorolás típus kezdőértékek megváltoztatásával

using System;

public class BDay
{
    enum Month : byte
    {
        January   = 1,
        February  = 2,
        March     = 3,
        April     = 4,
        May       = 5,
        June      = 6,
        July      = 7,
        August    = 8,
        September = 9,
        October   = 10,
        November  = 11,
        December  = 12 
    }
    
    struct birthday
    {
        public Month month;
        public int bday;
        public int byear;
    }
    
    public static void Main()
    {
        birthday myBirthday;
        
        myBirthday.month = Month.February;
        myBirthday.bday  = 1;
        myBirthday.byear = 1967;
        
        Console.WriteLine( "My birthday is {0} {1} {2}",
                           myBirthday.byear,
                           myBirthday.month,
                           myBirthday.bday
                         );
    }
}

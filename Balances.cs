// tömb

using System;

public class Balances
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
    

    public static void Main()
    {
        decimal[] balances = new decimal[ 12 ];
        decimal sum = 0m;
        System.Random rnd = new System.Random();

        Console.WriteLine( "Balances :" );
        Console.WriteLine( "______________________________________________" );
        
        for ( int i = 0; i < 12; i ++ )
        {
            balances[ i ] = ( decimal ) ( rnd.NextDouble() * 10000 );
            sum += balances[ i ];
            Console.WriteLine( "Balance of month {0} : {1}",
                               ( Month ) ( i + 1 ),
                               balances[ i ]
                             );
        }
        
        Console.WriteLine(     "______________________________________________" );
        Console.WriteLine(     "Total                 : {0}", sum );
        Console.WriteLine(     "Average               : {0}", sum / 12 );
    }
}

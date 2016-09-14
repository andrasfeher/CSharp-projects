// foreach használata

using System;

public class Fname
{

    public static void Main()
    {
        char[] name = new char[] { 'F', 'e', 'h', 'e', 'r' };

        foreach ( char chr in name )
        {
            Console.Write( chr );
        }
        
        Console.WriteLine( );
        
    }
}

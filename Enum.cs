// felsorolás típus

using System;

class Colors
{
    enum Color
    {
        red,
        white,
        blue
    }

    static void Main()
    {
        string buffer;
        Color myColor = new Color();
        
        Console.WriteLine( "Enter value for color: 0 - Red, 1 - White, 2 - Blue " );
        buffer = Console.ReadLine();
        
        myColor = ( Color ) Convert.ToInt32( buffer );
        
        switch ( myColor )
        {
            case Color.red:
                Console.WriteLine( "Switched to Red" );
                break;
            case Color.white:
                Console.WriteLine( "Switched to White" );
                break;
            case Color.blue:
                Console.WriteLine( "Switched to Blue" );
                break;
            default:
                Console.WriteLine( "Default" );
                break;
        }
        
        Console.WriteLine( "Color is {0} - ({1})",
                           myColor,
                           ( int ) myColor                           
                         );
    }
}

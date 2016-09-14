using System;
using System.Text.RegularExpressions;

class RegexpTest
{
    public static void Main()
    {
/*
        Match m = Regex.Match( "abracadabra", "(a|b|r)+" );

        if ( m.Success )
        {
            Console.WriteLine( "Talalt: " + m.ToString() );
        }
        else
        {
            Console.WriteLine( "Nem talalt!" );
        }

        string s = Regex.Replace( "abracadabra", "abra", "yyyy");

        Console.WriteLine( "Behelyettesites utan: " + s );
*/

        Regex r = new Regex( @"^\s*(.*)\s(.*)\s*$" );

        Match m = r.Match( "abracadabra 3245" );

        if ( m.Success )
        {
            Group g1 = m.Groups[ 1 ];
            Group g2 = m.Groups[ 2 ];

            Console.WriteLine( "Capture=[" + g1.Captures[ 0 ] + "]" );
            Console.WriteLine( "Capture=[" + g2.Captures[ 0 ] + "]" );

        }
        else
        {
            Console.WriteLine( "Nem talalt!" );
        }

    }
}
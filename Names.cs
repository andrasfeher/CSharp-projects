// kétdimenziós tömb

using System;

class Names
{
    public static void Main()
    {

        char[][] name = new char[ 3 ][];

        name[ 0 ] = new char[ 7 ] { 'B','r','a','d','l','e','y' };
        name[ 1 ] = new char[ 2 ] { 'L', '.'};
        name[ 2 ] = new char[ 5 ] { 'J', 'o', 'n', 'e', 's'};
        
        for ( int i = 0; i < name.Length; i ++ )
        {
            for ( int j = 0; j < name[ i ].Length;  j ++ )
            {
                Console.Write( name[ i ][ j ] );
            }
            
            Console.Write( " " );
        }
        Console.Write( "\n" );
    }
}

using System;

class tomb
{
    private const int SIDE = 5;

    public static void Main()
    {

        int[][] t = new int[ SIDE ][ ];

        t[ 0 ] = new int[ SIDE ] { 1, 2, 3, 4, 5 };
        t[ 1 ] = new int[ SIDE ] { 11, 12, 13, 14, 15 };

        for ( int i = 0; i < 2; i++ )
        {
            int j;

            for ( j = 0; j < ( SIDE - 1 ); j++ )
            {
                Console.Write( t[ i ][ j ] + ",");
            }

            Console.Write( t[ i ][ j ] + "\n" );
        }


    }
}

class Forciklus
{
    public static void Main()
    {
        int x, y;
        
        for ( x = 0; x < 10; x++ )
        {
            System.Console.Write( "\n" );

            for ( y = 0; y < 10; y++ )
            {
                System.Console.Write( "{0}", (char) 1 );
            }

        }
    }
}

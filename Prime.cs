using System;

namespace Prime
{

    class PrimeList
    {
        int top;
        int bot;
        int primeNumber = 0;
        int[] primeList = new int[ 10000 ];

        public PrimeList( int p_bot, int p_top )
        {
            if ( p_top % 2 == 0 )
            {
                top = p_top - 1;
            }
            else
            {
                top = p_top;
            }

            if ( p_bot % 2 == 0 )
            {
                bot = p_bot + 1;
            }
            else
            {
                bot = p_bot;
            }

            Calculate();
        }

        public void Calculate()
        {
            int i;
            int j;
            bool isPrime;

            for ( i = bot; i <= top; i += 2 )
            {
                j = 2 ;
                isPrime = true;

                while ( j <= Math.Sqrt( i ) && isPrime )
                {
                    isPrime = i % j != 0;
                    j ++;
                }

                 if ( isPrime )
                 {
                     primeList[ primeNumber ] = i;
                     primeNumber ++;
                 }
            }
        }

        public void PrintPrimeList()
        {
            for ( int i = 0; i < primeNumber; i++ )
            {
                 Console.WriteLine( primeList[ i ] );
            }
        }

        public int GetPrimesNumber()
        {
            return primeNumber;
        }
    }

    class Program
    {
        static public void Main( string[] args )
        {
            int bottom = Convert.ToInt32( args[ 0 ] );
            int top    = Convert.ToInt32( args[ 1 ] );

            PrimeList myPrimeList = new PrimeList( 3, 10 );

            Console.WriteLine( "Primszamok szama "
                               + bottom
                               + " es "
                               + top
                               + " kozott: "
                               + myPrimeList.GetPrimesNumber()
                              );

            Console.WriteLine( "Primszamok listaja:\n"
                              +"-------------------"
                             );

            myPrimeList.PrintPrimeList();


//             DateTime StartTime = DateTime.Now;
//             DateTime EndTime = DateTime.Now;
//             Console.WriteLine( "Ido: " + EndTime.Subtract( StartTime ) + " s" );
        }
    }
}
using System;
using System.Text;


class RandomString
{
    private char[] charSet = new char[ 52 ];

    public RandomString
    {
        for ( int i = 65; i <= 90; i++ )
        {
            charSet[ i - 65 ] = ( char ) i;
        }

        for ( int i = 97; i <= 122; i++ )
        {
            charSet[ i - 71 ] = ( char ) i;
        }

    }

    public string getNext( int length )
    {
        System.Random rnd = new System.Random();
        StringBuilder myString = new StringBuilder();

        for ( int i = 0; i < length; i++ )
        {
            myString.Add( charSet[ rnd.Next( 52 ) ];
        }

        get{ return myString }
    }

    public static void Main()
    {





    }
}

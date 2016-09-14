using System;
using System.Text;


class RandomString
{
    protected const int CHAR_SET_LEN = 52;
    protected char[] charSet = new char[ CHAR_SET_LEN ];

    public enum Type
    {
        ConstLen,
        VarLenAllowNull,
        VarLenNoNull
    }


    public RandomString()
    {
        for ( int i = 0; i < CHAR_SET_LEN / 2; i++ )
        {
            charSet[ i ] = ( char ) ( i + 65 );
            charSet[ i + 26 ] = ( char ) ( i + 97 );
        }
    }

    public StringBuilder getNext( int length, Type strType )
    {
        System.Random rnd = new System.Random();
        StringBuilder myString = new StringBuilder();

        if ( strType == Type.ConstLen )
        {
            for ( int i = 0; i < length; i++ )
            {
                myString.Append( charSet[ rnd.Next( CHAR_SET_LEN ) ] );
            }
        }
        else if ( strType == Type.VarLenAllowNull )
        {
            int strLen = rnd.Next( length );

            for ( int i = 0; i < strLen; i++ )
            {
                myString.Append( charSet[ rnd.Next( CHAR_SET_LEN ) ] );
            }
        }
        else if ( strType == Type.VarLenNoNull )
        {
            int strLen = rnd.Next( 1, length );

            for ( int i = 0; i < strLen; i++ )
            {
                myString.Append( charSet[ rnd.Next( CHAR_SET_LEN ) ] );
            }
        }

        return myString;
    }
}

class TestRandomString
{
    public static void Main()
    {
        RandomString myRndStr = new RandomString();

        for ( int i = 1; i <= 10; i++ )
        {
            Console.WriteLine( myRndStr.getNext( 10, RandomString.Type.ConstLen) );
            Console.WriteLine( myRndStr.getNext( 10, RandomString.Type.VarLenNoNull) );
        }

//         Console.WriteLine( myRndStr.getNext( 10, RandomString.Type.VarLenAllowNull) );
//         Console.WriteLine( myRndStr.getNext( 10, RandomString.Type.VarLenNoNull) );
    }

}

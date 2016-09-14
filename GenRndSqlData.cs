using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;


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



class GenRndSqlData
{
    public static void Main()
    {
        SqlConnection myConnection = null;
//        SqlCommand myCommand       = null;

        string myConnectionString = "server=localhost;"
                                      + "database=sajat;"
                                      + "uid=sa;"
                                      + "pwd=;";

        RandomString myRndStr = new RandomString();

        try
        {
            myConnection = new SqlConnection( myConnectionString );
            SqlCommand myCommand = myConnection.CreateCommand();

            myConnection.Open();

            for ( int i = 1; i <= 10; i++ )
            {
                myCommand.CommandText = "INSERT INTO contacts2 ( name )"
                                       + " VALUES ( '"
                                       + myRndStr.getNext( 50, RandomString.Type.ConstLen)
                                       + "' )";
                myCommand.ExecuteNonQuery();
            }
        }
        catch( SqlException e )
        {
            Console.WriteLine( "SqlDb exception: {0}", e.Message );
        }
        finally
        {
            if ( myConnection != null )  myConnection.Close();
        }
//         ConsSql.WriteLine( myRndStr.getNext( 10, RandomString.Type.VarLenAllowNull) );
//         ConsSql.WriteLine( myRndStr.getNext( 10, RandomString.Type.VarLenNoNull) );
    }

}

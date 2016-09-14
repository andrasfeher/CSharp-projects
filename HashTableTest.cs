using System;
using System.Collections;

class HashTableTest
{
    public static void Main()
    {
        Hashtable myHT = new Hashtable();

        myHT.Add( "Tercsi", 1 );
        myHT.Add( "Fercsi", 2 );
        myHT.Add( "Kata",   3 );
        myHT.Add( "Klara",  4 );

        Console.WriteLine( "A hashtabla tartalma torles elott:" );
        PrintHTContent( myHT );

        myHT.Remove( "Kata" );

        Console.WriteLine( "A hashtabla tartalma torles utan:" );
        PrintHTContent( myHT );

    }

    static void PrintHTContent( Hashtable myList )
    {
        IDictionaryEnumerator myEnumerator = myList.GetEnumerator();

        Console.WriteLine( "\t-Kulcs-\t-Ertek-" );

        while ( myEnumerator.MoveNext() )
        {
            Console.WriteLine( "\t{0}\t{1}", myEnumerator.Key, myEnumerator.Value );
        }
    }
}
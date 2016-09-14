using System;
using System.Data;
using System.Data.OleDb;

public class DBTest
{
    public static void Main()
    {
        string myConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
                                    + "User Id=;Password=;"
                                    + @"Data Source=C:\temp\C#\test.mdb";

        string mySelectCimek = "SELECT [Szemelyek].[nev], [Cimek].[cim]"
                               + " FROM Szemelyek INNER JOIN Cimek"
                                   + " ON [Szemelyek].[szem_id]=[Cimek].[szem_id]"
                               + " ORDER BY [Szemelyek].[nev]";

        string mySelectTelefonok = "SELECT [Szemelyek].[nev], [Telefonok].[telefon]"
                                   + " FROM Szemelyek INNER JOIN Telefonok"
                                     + " ON [Szemelyek].[szem_id]=[Telefonok].[szem_id]"
                                   + " ORDER BY [Szemelyek].[nev]";


        OleDbConnection myConnection = new OleDbConnection( myConnectionString );
        OleDbCommand myCommand = new OleDbCommand( mySelectCimek, myConnection );

        myConnection.Open();

        OleDbDataReader myDataReader = null;
        myDataReader =myCommand.ExecuteReader();

        // címek kiolvasása
        Console.WriteLine( "\nA cimek:\n" );

        while ( myDataReader.Read() )
        {
            Console.WriteLine( myDataReader.GetString( 0 ).PadRight( 10, ' ' )
                               + myDataReader.GetString( 1 )
                             );

        }

        myDataReader.Close();

        // telefonszámok kiolvasása
        Console.WriteLine( "\nA telefonszámok:\n" );

        myCommand = new OleDbCommand( mySelectTelefonok, myConnection );
        myDataReader = null;
        myDataReader =myCommand.ExecuteReader();

        while ( myDataReader.Read() )
        {
            Console.WriteLine( myDataReader.GetString( 0 ).PadRight( 10, ' ' )
                               + myDataReader.GetString( 1 )
                             );

        }


        myDataReader.Close();
        myConnection.Close();
    }
}
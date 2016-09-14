using System;
using System.Data;
using System.Data.OleDb;

public class DBTest
{
    public static void Main()
    {
        OleDbConnection myConnection = null;

        try
        {
          // 1. lépés: xxxConnection objektum létrehozása az adatbázishoz való
          // csatlakozásra
          string myConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
                                      + "User Id=;Password=;"
                                      + @"Data Source=C:\temp\C#\test.mdb";

          myConnection = new OleDbConnection( myConnectionString );


          // 2. lépés: xxxCommand objektum létrehozása
          string mySelectCimek = "SELECT [Szemelyek].[nev], [Cimek].[cim]"
                                 + " FROM Szemelyek INNER JOIN Cimek"
                                     + " ON [Szemelyek].[szem_id]=[Cimek].[szem_id]"
                                 + " ORDER BY [Szemelyek].[nev]";

          OleDbCommand myCommand = new OleDbCommand( mySelectCimek, myConnection );

          // 3. lépés: adatbázis kapcsolat megnyitása
          myConnection.Open();

          // 4. lépés: xxxDataReader objektum létrehozása, majd az xxxCommand
          // objektum ExecuteReader metódus meghívása a SELECT utasítás végrehaj-
          // tásához
          OleDbDataReader myDataReader = null;
          myDataReader =myCommand.ExecuteReader();

          // címek kiolvasása
          Console.WriteLine( "\nA cimek:\n" );

          // 5. lépés: rekordok kiolvasása és feldolgozása
          while ( myDataReader.Read() )
          {
              Console.WriteLine( myDataReader.GetString( 0 ).PadRight( 10, ' ' )
                                 + myDataReader.GetString( 1 )
                               );

          }

          // 6. lépés: DataReader lezárása
          myDataReader.Close();

          // 7. lépés: Connection objektum lezárása
          myConnection.Close();
        }
        catch ( OleDbException e )
        {
            Console.WriteLine( "An OleDB exception was thrown" );
            Console.WriteLine( "Message    : " + e.Message );
            Console.WriteLine( "Stack trace: " + e.StackTrace );
        }
        finally
        {
            if ( myConnection != null )  myConnection.Close();
        }
    }
}
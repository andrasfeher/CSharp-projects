// adatbázisból kinyert adatok tárolása DataSet objektumban

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

          OleDbCommand myCommand = myConnection.CreateCommand();
          myCommand.CommandText = mySelectCimek;

          // 3. lépés xxxDataAdapter objektum létrehozása
          OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
          myDataAdapter.SelectCommand = myCommand;

          // 4. DataSet objektum létrehozása
          DataSet myDataSet = new DataSet();

          // 5. lépés: adatbázis kapcsolat megnyitása
          myConnection.Open();

          // 6. lépés: adatok tárolása a DataSet-ben
          Console.WriteLine( "Retrieving rows ..." );
          myDataAdapter.Fill( myDataSet, "Contacts" );

          // 7. lépés: Connection objektum lezárása
          myConnection.Close();

          // 8. lépés: adatok kiolvasása a DataSet objektumból egy DataTable
          // típusú objektumba
          DataTable myDataTable = myDataSet.Tables[ "Contacts" ];

          // 9. lépés: DataTable sorainak megjelenítése egy DataRow objektum
          // segítségével
          foreach ( DataRow myDataRow in myDataTable.Rows )
          {
            Console.WriteLine( "Nev : " + myDataRow[ "nev" ] );
            Console.WriteLine( "Cim : " + myDataRow[ "cim" ] );
          }
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
// adatb�zisb�l kinyert adatok t�rol�sa DataSet objektumban

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
          // 1. l�p�s: xxxConnection objektum l�trehoz�sa az adatb�zishoz val�
          // csatlakoz�sra
          string myConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
                                      + "User Id=;Password=;"
                                      + @"Data Source=C:\temp\C#\test.mdb";

          myConnection = new OleDbConnection( myConnectionString );


          // 2. l�p�s: xxxCommand objektum l�trehoz�sa
          string mySelectCimek = "SELECT [Szemelyek].[nev], [Cimek].[cim]"
                                 + " FROM Szemelyek INNER JOIN Cimek"
                                     + " ON [Szemelyek].[szem_id]=[Cimek].[szem_id]"
                                 + " ORDER BY [Szemelyek].[nev]";

          OleDbCommand myCommand = myConnection.CreateCommand();
          myCommand.CommandText = mySelectCimek;

          // 3. l�p�s xxxDataAdapter objektum l�trehoz�sa
          OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
          myDataAdapter.SelectCommand = myCommand;

          // 4. DataSet objektum l�trehoz�sa
          DataSet myDataSet = new DataSet();

          // 5. l�p�s: adatb�zis kapcsolat megnyit�sa
          myConnection.Open();

          // 6. l�p�s: adatok t�rol�sa a DataSet-ben
          Console.WriteLine( "Retrieving rows ..." );
          myDataAdapter.Fill( myDataSet, "Contacts" );

          // 7. l�p�s: Connection objektum lez�r�sa
          myConnection.Close();

          // 8. l�p�s: adatok kiolvas�sa a DataSet objektumb�l egy DataTable
          // t�pus� objektumba
          DataTable myDataTable = myDataSet.Tables[ "Contacts" ];

          // 9. l�p�s: DataTable sorainak megjelen�t�se egy DataRow objektum
          // seg�ts�g�vel
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
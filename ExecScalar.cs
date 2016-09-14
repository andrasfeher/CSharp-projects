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
          string mySqlStmt = "SELECT COUNT(*) FROM Cimek";

          OleDbCommand myCommand = new OleDbCommand( mySqlStmt, myConnection );

          // 3. l�p�s: adatb�zis kapcsolat megnyit�sa
          myConnection.Open();

          int rtnValue = ( int ) myCommand.ExecuteScalar();

          Console.WriteLine( "Rekordok szama: " + rtnValue );

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
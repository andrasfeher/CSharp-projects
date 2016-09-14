using System;
using System.Data;
using System.Data.OleDb;

public class DBInsert
{
    public static void Main()
    {
        int rv = 0;
        OleDbConnection myConnection = null;
        OleDbCommand myCommand       = null;

        string myConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
                                    + "User Id=;Password=;"
                                    + @"Data Source=E:\C#\test.mdb";

        string myInsertStmt = "INSERT INTO cimek ( szem_id, cim )"
                               + " VALUES ( 1, 'T cim programból' )";


        try
        {
            myConnection = new OleDbConnection( myConnectionString );
            myCommand = new OleDbCommand( myInsertStmt, myConnection );

            myConnection.Open();

            rv = myCommand.ExecuteNonQuery();
        }
        catch( OleDbException e )
        {
            Console.WriteLine( "OleDb exception: {0}", e.Message );
        }
        finally
        {
            if ( myConnection != null )  myConnection.Close();
        }

        Console.WriteLine( "{0} records added\n", rv );

    }
}
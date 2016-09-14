using System;
using System.Data;
using System.Data.SqlClient;

public class ExecuteInsertUpdateDelete
{
    public static void DisplayRow( SqlCommand mySqlCommand,
                                   string CustomerID
                                  )
    {
        mySqlCommand.CommandText = "SELECT CustomerID, CompanyName"
                                   + " FROM customers "
                                   + " WHERE CustomerID = '" + CustomerID + "'";

        SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

        while ( mySqlDataReader.Read() )
        {
            Console.WriteLine( "Customer ID  = " + mySqlDataReader[ "CustomerID" ] );
            Console.WriteLine( "Company name = " + mySqlDataReader[ "CompanyName" ] );
        }
        
        mySqlDataReader.Close();
    }


    public static void Main()
    {
        SqlConnection myConnection = null;

        try
        {
          // 1. lépés: xxxConnection objektum létrehozása az adatbázishoz való
          // csatlakozásra
          string myConnectionString = "server=localhost;"
                                      + "database=Northwind;"
                                      + "uid=sa;"
                                      + "pwd=;";

          myConnection = new SqlConnection( myConnectionString );


          SqlCommand myCommand = myConnection.CreateCommand();
          myConnection.Open();

          // INSERT
          myCommand.CommandText = "INSERT INTO Customers ( CustomerID, CompanyName )"
                                  + "VALUES ( 'J2COM', 'JSCorp' )";


          myCommand.ExecuteNonQuery();

          DisplayRow( myCommand, "J2COM" );

          // UPDATE
          myCommand.CommandText = "UPDATE Customers"
                                  + " SET CompanyName = 'Andras'"
                                  + " WHERE CustomerID = 'J2COM'";

          myCommand.ExecuteNonQuery();

          DisplayRow( myCommand, "J2COM" );

          // DELETE
          myCommand.CommandText = "DELETE FROM Customers"
                                  + " WHERE CustomerID = 'J2COM'";

          myCommand.ExecuteNonQuery();

          DisplayRow( myCommand, "J2COM" );

        }
        catch ( SqlException e )
        {
            Console.WriteLine( "An Sql exception was thrown" );
            Console.WriteLine( "Message    : " + e.Message );
            Console.WriteLine( "Stack trace: " + e.StackTrace );
        }
        finally
        {
            if ( myConnection != null )  myConnection.Close();
        }
    }
}
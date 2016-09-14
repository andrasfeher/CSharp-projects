using System;
using System.Data;
using System.Data.SqlClient;

public class MSSQLTest
{
    public static void Main()
    {
        SqlConnection myConnection = null;

        try
        {
          // 1. lépés: xxxConnection objektum létrehozása az adatbázishoz való
          // csatlakozásra
          string myConnectionString = "server=HP22693238002\\TEST;"
                                      + "database=xxxx;"
                                      + "Trusted_Connection=yes;";
//                                      + "uid=sa;"
//                                       + "pwd=;";

          myConnection = new SqlConnection( myConnectionString );


          // 2. lépés: xxxCommand objektum létrehozása
          string mySelectCimek = "select * from t";

          SqlCommand myCommand = new SqlCommand( mySelectCimek, myConnection );

          // 3. lépés: adatbázis kapcsolat megnyitása
          myConnection.Open();

          // 4. lépés: xxxDataReader objektum létrehozása, majd az xxxCommand
          // objektum ExecuteReader metódus meghívása a SELECT utasítás végrehaj-
          // tásához
          SqlDataReader myDataReader = null;
          myDataReader =myCommand.ExecuteReader();

          // címek kiolvasása
          Console.WriteLine( "\nA cimek:\n" );

          // 5. lépés: rekordok kiolvasása és feldolgozása
          while ( myDataReader.Read() )
          {
              Console.WriteLine( myDataReader.GetString( 0 )
                                 + " - "
                                 + myDataReader.GetString( 1 )
                               );

          }

          // 6. lépés: DataReader lezárása
          myDataReader.Close();

          // 7. lépés: Connection objektum lezárása
          myConnection.Close();
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
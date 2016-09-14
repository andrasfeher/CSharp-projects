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
          // 1. l�p�s: xxxConnection objektum l�trehoz�sa az adatb�zishoz val�
          // csatlakoz�sra
          string myConnectionString = "server=HP22693238002\\TEST;"
                                      + "database=xxxx;"
                                      + "Trusted_Connection=yes;";
//                                      + "uid=sa;"
//                                       + "pwd=;";

          myConnection = new SqlConnection( myConnectionString );


          // 2. l�p�s: xxxCommand objektum l�trehoz�sa
          string mySelectCimek = "select * from t";

          SqlCommand myCommand = new SqlCommand( mySelectCimek, myConnection );

          // 3. l�p�s: adatb�zis kapcsolat megnyit�sa
          myConnection.Open();

          // 4. l�p�s: xxxDataReader objektum l�trehoz�sa, majd az xxxCommand
          // objektum ExecuteReader met�dus megh�v�sa a SELECT utas�t�s v�grehaj-
          // t�s�hoz
          SqlDataReader myDataReader = null;
          myDataReader =myCommand.ExecuteReader();

          // c�mek kiolvas�sa
          Console.WriteLine( "\nA cimek:\n" );

          // 5. l�p�s: rekordok kiolvas�sa �s feldolgoz�sa
          while ( myDataReader.Read() )
          {
              Console.WriteLine( myDataReader.GetString( 0 )
                                 + " - "
                                 + myDataReader.GetString( 1 )
                               );

          }

          // 6. l�p�s: DataReader lez�r�sa
          myDataReader.Close();

          // 7. l�p�s: Connection objektum lez�r�sa
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
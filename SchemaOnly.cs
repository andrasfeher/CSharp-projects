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

          OleDbCommand myCommand = new OleDbCommand( mySelectCimek, myConnection );

          // 3. l�p�s: adatb�zis kapcsolat megnyit�sa
          myConnection.Open();

          // 4. l�p�s: xxxDataReader objektum l�trehoz�sa, majd az xxxCommand
          // objektum ExecuteReader met�dus megh�v�sa a SELECT utas�t�s v�grehaj-
          // t�s�hoz
          OleDbDataReader myDataReader = null;
          myDataReader =myCommand.ExecuteReader( CommandBehavior.SchemaOnly );

          DataTable myDataTable = myDataReader.GetSchemaTable();

          foreach ( DataRow myDataRow in myDataTable.Rows )
          {
                Console.WriteLine( "New column details follow:" );
                foreach ( DataColumn myDataColumn in myDataTable.Columns )
                {
                    Console.WriteLine( myDataColumn
                                       + " = "
                                       + myDataRow[ myDataColumn ] );
                    if ( myDataColumn.ToString() == "ProviderType" )
                    {
                        Console.WriteLine( myDataColumn
                                           + " = "
                                           + ( ( System.Data.SqlDbType )
                                                myDataRow[ myDataColumn ]
                                              )
                                          );

                    }
                }
          }


          // 6. l�p�s: DataReader lez�r�sa
          myDataReader.Close();

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
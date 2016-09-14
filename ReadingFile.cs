//  FileSize.cs -
//-----------------------------------------------
using System;
using System.IO;

class ReadingFile
{
   public static void Main( )
   {
      string[] CLA = Environment.GetCommandLineArgs();

      if ( CLA.Length < 2 )
      {
          Console.WriteLine("Format: {0} filename", CLA[ 0 ] );
      }
      else
      {
          string buffer;

          try
          {
              StreamReader myFile = File.OpenText( CLA[ 1 ] );

              while ( ( buffer = myFile.ReadLine() ) != null )
              {
                   Console.WriteLine( buffer );
              }

              myFile.Close();
          }
          catch( Exception e )
          {
              Console.WriteLine( "Unexpected exception was thrown" );
              Console.WriteLine( "Message    : " + e.Message );
              Console.WriteLine( "Stack trace: " + e.StackTrace );
          }
       }
   }
}

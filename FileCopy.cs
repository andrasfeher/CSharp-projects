//  FileSize.cs -
//-----------------------------------------------
using System;
using System.IO;

class FileCopy
{
   public static void Main( )
   {
      string[] CLA = Environment.GetCommandLineArgs();

      if ( CLA.Length < 3 )
      {
          Console.WriteLine("Format: {0} orig filename new filename", CLA[ 0 ] );
      }
      else
      {
          string origFile = CLA[ 1 ];
          string newFile  = CLA[ 2 ];

          Console.WriteLine( "Copying ..." );

          try
          {
              File.Copy( origFile, newFile );
          }
          catch( FileNotFoundException )
          {
                Console.WriteLine( "File {0} does not exist", CLA[ 1 ] );
          }
          catch( IOException )
          {
                Console.WriteLine( "File {0} already exist", CLA[ 2 ] );
          }
          catch( Exception e )
          {
              Console.WriteLine( "Unexpected exception was thrown" );
              Console.WriteLine( "Message    : " + e.Message );
              Console.WriteLine( "Stack trace: " + e.StackTrace );
          }

           Console.WriteLine( "Done..." );
       }
   }
}

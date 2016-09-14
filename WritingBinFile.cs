//  FileSize.cs -
//-----------------------------------------------
using System;
using System.IO;

class WritingFile
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
          try
          {
              FileStream myFile = new FileStream( CLA[ 1 ], FileMode.CreateNew );
              BinaryWriter bwFile = new BinaryWriter( myFile );

              for ( int i =0; i < 100; i++ )
              {
                  bwFile.Write( i );
              }

              bwFile.Close();
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

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
              FileStream myFile = new FileStream( CLA[ 1 ], FileMode.Open );
              BinaryReader brFile = new BinaryReader( myFile );

              while ( brFile.PeekChar() != -1 )
              {
                  Console.WriteLine( "<{0}>", brFile.ReadInt32() );
              }

              brFile.Close();
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

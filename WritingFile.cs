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
              StreamWriter myFile = File.CreateText( CLA[ 1 ] );

              myFile.WriteLine( "Tercsi" );
              myFile.WriteLine( "Fercsi" );
              myFile.WriteLine( "Kata" );
              myFile.WriteLine( "Klára" );

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

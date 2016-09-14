//  FileSize.cs -
//-----------------------------------------------
using System;
using System.IO;

class FileAttr
{
   public static void Main( string[] args )
   {
      if ( args.Length < 1 )
      {
          Console.WriteLine("Format: {0} filename", args[0] );
      }
      else
      {
            try
            {
                FileInfo myFileInfo = new FileInfo( args[0] );

                Console.WriteLine( "Length      :" + myFileInfo.Length );
                Console.WriteLine( "Last access :" + myFileInfo.LastAccessTime );
                Console.WriteLine( "Last write  :" + myFileInfo.LastWriteTime );
                Console.WriteLine( "Creation    :" + myFileInfo.CreationTime );
            }
            catch( FileNotFoundException )
            {
                Console.WriteLine( "File {0} does not exist", args[0] );
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

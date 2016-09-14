//  FileSize.cs -
//-----------------------------------------------
using System;
using System.IO;

class SpeedTest
{
   public static void Main( )
   {
      string[] CLA = Environment.GetCommandLineArgs();
      int limit = Convert.ToInt32( CLA[ 1 ] );
      int x = 0;

      DateTime StartTime = DateTime.Now;

      for ( int i = 1; i <= limit; i ++ )
      {
          x = i + 1;
      }

      DateTime EndTime = DateTime.Now;

      Console.WriteLine( x );

      Console.WriteLine( EndTime.Subtract( StartTime ) );


   }
}

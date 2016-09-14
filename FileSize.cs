//  FileSize.cs -  
//-----------------------------------------------
using System;
using System.IO;

class FileSize
{
   public static void Main()
   {
      string[] CLA = Environment.GetCommandLineArgs();
      
      FileInfo fiExe = new FileInfo(CLA[0]);

      if ( CLA.Length < 2 )
      {
          Console.WriteLine("Format: {0} filename", fiExe.Name);
      }
      else
      {
        try
        {
           FileInfo fiFile = new FileInfo(CLA[1]);

           if(fiFile.Exists)
           {
             Console.WriteLine("===================================");
             Console.WriteLine("{0} - {1}", fiFile.Name, fiFile.Length );
             Console.WriteLine("===================================");     
             Console.WriteLine("Last Access: {0}", fiFile.LastAccessTime);
             Console.WriteLine("Last Write:  {0}", fiFile.LastWriteTime);
             Console.WriteLine("Creation:    {0}", fiFile.CreationTime);
             Console.WriteLine("===================================");     
           }
           else
           {
             Console.WriteLine("{0} doesn't exist!", fiFile.Name);
           }
        }
 
        catch (System.IO.FileNotFoundException)
        {
          Console.WriteLine("\n{0} does not exist!", CLA[1]);
          return;
        }
        catch (Exception e)
        {
          Console.WriteLine("\nAn exception was thrown trying to copy file.");
          Console.WriteLine(e);
          return;
        }
      }
   }
}

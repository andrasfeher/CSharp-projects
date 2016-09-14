using System;
using System.IO;

namespace Utility.IO{
    /// <summary>
    /// Filesystem
    /// </summary>
    public class FileSystem{
        // Copy directory structure recursively
        public static void copyDirectory(string Src,string Dst){
            String[] Files;

            if(Dst[Dst.Length-1]!=Path.DirectorySeparatorChar) 
                Dst+=Path.DirectorySeparatorChar;
            if(!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files=Directory.GetFileSystemEntries(Src);
            foreach(string Element in Files){
                // Sub directories
                if(Directory.Exists(Element)) 
                    copyDirectory(Element,Dst+Path.GetFileName(Element));
                // Files in directory
                else 
                    File.Copy(Element,Dst+Path.GetFileName(Element),true);
                }
            }

        }
    }

An usage example
Here is an example of how to use the FileSystem class. 

// After a successful copy, you can then call 
// Directory.Delete(@"c:\MySrcDirectory") to mimic a Directory.Move behaviour
try{
    copyDirectory(@"c:\MySrcDirectory",@"c:\MyDstDirectory");
    }
catch(Exception Ex){
    Console.Error.WriteLine(Ex.Message);
    }


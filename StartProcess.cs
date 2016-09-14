using System;

class StartProcess
{
      public static void Main()
      {
         System.Diagnostics.Process proc = new System.Diagnostics.Process();

         proc.StartInfo.FileName = "C:\\Documents and Settings\\András\\Dokumentumok\\Temp\\calc.exe";
//         proc.StartInfo.Arguments = "machine -l mylogin ls";
         proc.StartInfo.UseShellExecute = false;
         proc.StartInfo.RedirectStandardOutput = false;
         proc.Start();
         proc.WaitForExit();
      }
}

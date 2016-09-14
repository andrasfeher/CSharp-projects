using System;
using System.IO;

///<summary>
/// osztály a forráskódok számozására, ha a kód hossza nem nagyobb mint 1000 sor
///</summary>

class NumberIT
{
    ///<summary>
    /// az alkalmazás kezdõpontja
    ///</summary>

    public static void Main( string[] args )
    {
        // ellenõrizzük, hogy a felhasználó megadott-e fájlnevet a parancssorban

        if ( args.Length <= 0 )
        {
            Console.WriteLine( "Missing input filename\n" );
        }
        else
        {
            // objektumok bevezetése a fájlmûveletekhez

            StreamReader InFile  = null;
            StreamWriter OutFile = null;

            try
            {
                // parancssorban megadott file megnyitása
                InFile = File.OpenText( args[0] );

                // kimeneti fájl létrehozása
                OutFile = File.CreateText( "outfile.txt" );

                Console.Write( "\nNumbering...." );

                // a fájl elsõ sorának beolvasása
                string line = InFile.ReadLine();
                int ctr = 1;

                // addig maradunk a ciklusban, míg el nem érjük a fájl végét
                while ( line != null )
                {
                    OutFile.WriteLine( "{0}: {1}", ctr.ToString().PadLeft( 3, '0' ), line );
                    Console.Write( "..{0}..", ctr.ToString());
                    ctr++;
                    line = InFile.ReadLine();
                }
            }
            catch ( System.IO.FileNotFoundException )
            {
                Console.WriteLine( "Could not find file {0}", args[0] );
            }
            catch ( Exception e )
            {
                Console.WriteLine( "Error: {0}", e.Message );
            }
            finally
            {
                if ( InFile != null )
                {
                    // fájlok lezárása
                    InFile.Close();
                    OutFile.Close();
                    Console.WriteLine( "Done.." );
                }
            }
        }
    }
}

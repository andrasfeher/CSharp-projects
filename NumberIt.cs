using System;
using System.IO;

///<summary>
/// oszt�ly a forr�sk�dok sz�moz�s�ra, ha a k�d hossza nem nagyobb mint 1000 sor
///</summary>

class NumberIT
{
    ///<summary>
    /// az alkalmaz�s kezd�pontja
    ///</summary>

    public static void Main( string[] args )
    {
        // ellen�rizz�k, hogy a felhaszn�l� megadott-e f�jlnevet a parancssorban

        if ( args.Length <= 0 )
        {
            Console.WriteLine( "Missing input filename\n" );
        }
        else
        {
            // objektumok bevezet�se a f�jlm�veletekhez

            StreamReader InFile  = null;
            StreamWriter OutFile = null;

            try
            {
                // parancssorban megadott file megnyit�sa
                InFile = File.OpenText( args[0] );

                // kimeneti f�jl l�trehoz�sa
                OutFile = File.CreateText( "outfile.txt" );

                Console.Write( "\nNumbering...." );

                // a f�jl els� sor�nak beolvas�sa
                string line = InFile.ReadLine();
                int ctr = 1;

                // addig maradunk a ciklusban, m�g el nem �rj�k a f�jl v�g�t
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
                    // f�jlok lez�r�sa
                    InFile.Close();
                    OutFile.Close();
                    Console.WriteLine( "Done.." );
                }
            }
        }
    }
}

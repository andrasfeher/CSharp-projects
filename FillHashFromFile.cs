using System;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

class FillHashFromFile
{

    public static void Main()
    {
        FileStream fstr = new FileStream( "infile.txt", FileMode.Open );
        StreamReader sReader = new StreamReader( fstr );
        Hashtable storage = new Hashtable();
        Regex r = new Regex( @"^\s*(.*)\s(.*)\s*$" );


        string line;

        while ( ( line = sReader.ReadLine() ) != null )
        {

            Match m = r.Match( line );

            if ( m.Success )
            {
                Group g1 = m.Groups[ 1 ];
                Group g2 = m.Groups[ 2 ];

                storage.Add( g1.Captures[ 0 ], g2.Captures[ 0 ] );

            }
            else
            {
                Console.WriteLine( "Nem talalt!" );
            }

        }

        fstr.Close();

        if ( storage.ContainsKey( "Tercsi" ) )
        {
            Console.WriteLine( storage.GetObjectData( "Tercsi" ) );
        }
        else
        {
            Console.WriteLine( "Nincs benne" );
        }
    }

 }
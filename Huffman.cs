using System;

class HuffComp
{
    protected string infile;
    protected string outfile;

    public HuffComp( string pInfile )
    {
        infile = pInfile;
    }

    public HuffComp( string pInfile, string pOutfile )
    {
        infile  = pInfile;
        outfile = pOutfile;
    }
}

class HuffExt
{
    protected string infile;
    protected string outfile;

    public HuffExt( string pInfile )
    {
        infile = pInfile;
    }

    public HuffExt( string pInfile, string pOutfile )
    {
        infile  = pInfile;
        outfile = pOutfile;
    }
}


class Huffman
{

    // leszedi a .huf kerjesztest a fájlévrõl
    static string removeHufExt( string filename)
    {
        return filename;
    }

    // ellenõrzi a parancssor paramétereket
    static bool isCmdParamOK( string[] args )
    {
        bool result = true;

        // number of arguments
        if ( args.Length < 3 )
        {
            result = false;
        }

        // options
        if ( result == true ) and
           ( args[ 1 ] != "-c" or args[ 1 ] != "-e" )
        {
            result = false;
        }

        // filenames in case of compression
        if ( result == true ) and
           ( args.Length == 4 ) and
           ( args[ 3 ] != "-c" or args[ 1 ] != "-e" )
        {
            result = false;
        }






        return true;
    }

    // Usage kiírása
    static void printUsage()
    {
        Console.WriteLine( "Usage:\n\n" +
                           "Huffman <-c|-e> <input filename> [output filename]\n\n" +
                           "Where:\n" +
                           " -c means compress\n" +
                           " -e means extract\n\n" +
                           "In case of compression, if the output file is specified, " +
                           "the last four characters of the filename must be '.huf'.\n" +
                           "In case of extraction, the last four characters of the filename must be '.huf'."
                         );
    }


    // program kezdet
    public static void Main( string[] args )
    {
        if ( !isCmdParamOK( args ) )
        {
            printUsage();
        }
        else
        {
            if ( args[ 1 ] == "-c" )
            {
                if ( args.Length == 4 )
                {
                    HuffComp comp = new HuffComp( args[ 2 ],
                                                  args[ 3 ]
                                                 );
                }
                else
                {
                    HuffComp comp = new HuffComp( args[ 2 ],
                                                  args[ 2 ] + ".huf"
                                                );
                }
            }
            else
            {
                if ( args.Length == 4 )
                {
                    HuffExt comp = new HuffExt( args[ 2 ],
                                              args[ 3 ]
                                            );
                }
                else
                {
                    HuffExt comp = new HuffExt( args[ 2 ],
                                              removeHufExt( args[ 2 ] )
                                            );
                }
            }
        }
    }
}
class Options
{
    Hashtable argsHT = new Hashtable();;
    string pattern;

    void Options( string[] p_args, string p_pattern )
    {
        args    = p_args;
        
        foreach ( string arg in args )
        {
            argsHT.Add( arg );
        }

        pattern = p_pattern;
    }
}
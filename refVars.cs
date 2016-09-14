using System;

class nbr
{
    public double squareByVal( double x )
    {
        x = x * x; 
        return x;
    }
    
    public double squareByRef( ref double x )
    {
        x = x * x; 
        return x;
    }
}

class refVars
{

    public static void Main()
    {
        nbr doit = new nbr();
        
        double nbr1 = 3;
        double retVal = 0;
        
        // függvényhívás érték szerinti paraméterrel
        Console.WriteLine( "Before square -> nbr1 = {0}, retVal = {1}", nbr1, retVal );
        
        retVal = doit.squareByVal( nbr1 );
        
        Console.WriteLine( "After square -> nbr1 = {0}, retVal = {1}", nbr1, retVal );
        
        Console.WriteLine( "\n--------------\n" );
    
        // függvényhívás hivatkozás szerinti paraméterrel
        retVal = 0;
    
        Console.WriteLine( "Before square -> nbr1 = {0}, retVal = {1}", nbr1, retVal );
        
        retVal = doit.squareByRef( ref nbr1 );
        
        Console.WriteLine( "After square -> nbr1 = {0}, retVal = {1}", nbr1, retVal );
    }    
}

using System;

class Nbr
{
    public void math_routines(  double x,
                                out double half,
                                out double squared,
                                out double cubed
                             )
    {
        half    = x / 2;
        squared = x * x;
        cubed   = x * x * x;
    }
}

class Outter
{
    public static void Main()
    {
        Nbr doit = new Nbr();
        
        double nbr = 600;
        double half_nbr, cubed_nbr, square_nbr;

        doit.math_routines( nbr, out half_nbr, out cubed_nbr, out square_nbr );
        
        Console.WriteLine( "nbr = {0}, half_nbr = {1}, cubed_nbr = {2}, square_nbr = {3}",
                            nbr, half_nbr, cubed_nbr, square_nbr 
                          );
    }
}

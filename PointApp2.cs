// struktúra konstruktorral

struct Point
{
	public int x;
	public int y;
    
    public Point( int x, int y )
    {
        this.x = x;
        this.y = y;
    }
}

class PointApp
{
	public static void Main()
	{
		Point starting 	= new Point( 1, 4 );
		Point ending 	= new Point( 10, 14 );
		
		System.Console.WriteLine( "Starting point:( {0}, {1} )", 
								  starting.x, 
								  starting.y );

		System.Console.WriteLine( "Ending point:( {0}, {1} )", 
								  ending.x, 
								  ending.y );
	}
}

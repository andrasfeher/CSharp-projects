struct Point
{
	public int x;
	public int y;
}

class PointApp
{
	public static void Main()
	{
		Point starting;
		Point ending;
		
		starting.x 	= 1;
		starting.y 	= 4;
		ending.x	= 10;
		ending.y	= 14;
		
		System.Console.WriteLine( "Starting point:( {0}, {1} )", 
								  starting.x, 
								  starting.y );

		System.Console.WriteLine( "Ending point:( {0}, {1} )", 
								  ending.x, 
								  ending.y );
	}
}

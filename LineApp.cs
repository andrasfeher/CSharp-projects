class Point
{
	public int x;
	public int y;
}

class PointApp
{
	public static void Main()
	{
		Point starting 	= new Point();
		Point ending 	= new Point();
		double distance;
		
		starting.x 	= 1;
		starting.y 	= 4;
		ending.x	= 10;
		ending.y	= 14;
		
		distance = System.Math.Sqrt( ( ( ending.x - starting.x ) * ( ending.x - starting.x ) ) 
									 + ( ( ending.y - starting.y ) * ( ending.y - starting.y ) )  
								   );
		
		
		System.Console.WriteLine( "Starting point:( {0}, {1} )", 
								  starting.x, 
								  starting.y );

		System.Console.WriteLine( "Ending point:( {0}, {1} )", 
								  ending.x, 
								  ending.y );

		System.Console.WriteLine( "Distance between the two points: {0}", 
								  distance ); 
	}
}

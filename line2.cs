class Point
{
	public int x;
	public int y;
}

class Line
{
	public Point starting 	= new Point();
	public Point ending 	= new Point();
	public double len;
	
}

class LineApp
{
	public static void Main()
	{
	
		Line myLine = new Line();
		
		myLine.starting.x 	= 1;
		myLine.starting.y 	= 4;
		myLine.ending.x	= 10;
		myLine.ending.y	= 14;
		
		myLine.len = System.Math.Sqrt( ( ( myLine.ending.x - myLine.starting.x ) * 
										 ( myLine.ending.x - myLine.starting.x ) 
									   ) 
									   + 
									   ( ( myLine.ending.y - myLine.starting.y ) * 
									     ( myLine.ending.y - myLine.starting.y ) 
									   )  
								     );
		
		
		System.Console.WriteLine( "Starting point:( {0}, {1} )", 
								  myLine.starting.x, 
								  myLine.starting.y );

		System.Console.WriteLine( "Ending point:( {0}, {1} )", 
								  myLine.ending.x, 
								  myLine.ending.y );

		System.Console.WriteLine( "Length: {0}", myLine.len );
	}
}

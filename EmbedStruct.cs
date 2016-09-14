struct Point
{
	public int x;
	public int y;
}

struct Line
{
	public Point starting;
	public Point ending;
    
    public double getLength()
    {
		return System.Math.Sqrt( ( ( ending.x - starting.x ) * 
				     			   ( ending.x - starting.x ) 
							      ) 
								  + 
								  ( ( ending.y - starting.y ) * 
									( ending.y - starting.y ) 
								   )  
								);
    }
    
}

class LineApp
{
	public static void Main()
	{
	
		Line myLine;
		
		myLine.starting.x 	= 1;
		myLine.starting.y 	= 4;
		myLine.ending.x	= 10;
		myLine.ending.y	= 14;
		
		
		
		System.Console.WriteLine( "Starting point:( {0}, {1} )", 
								  myLine.starting.x, 
								  myLine.starting.y );

		System.Console.WriteLine( "Ending point:( {0}, {1} )", 
								  myLine.ending.x, 
								  myLine.ending.y );

		System.Console.WriteLine( "Length: {0}", myLine.getLength() );
	}
}

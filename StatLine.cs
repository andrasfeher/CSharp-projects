class Point
{
	public int x;
	public int y;
}

class Line
{
	static public Point origin = new Point();
	public Point ending		   = new Point();
}

class LineApp
{
	public static void Main()
	{
	
		Line line1 = new Line();
		Line line2 = new Line();
		
		Line.origin.x 	= 1;
		Line.origin.y 	= 4;

		line1.ending.x	= 10;
		line1.ending.y	= 14;

		line2.ending.x	= 10;
		line2.ending.y	= 14;
		

		System.Console.WriteLine( "Line1 origin:( {0}, {1} )", 
								  Line.origin.x, 
								  Line.origin.y );

		System.Console.WriteLine( "Line1 ending:( {0}, {1} )", 
								  line1.ending.x, 
								  line1.ending.y );

		System.Console.WriteLine( "Line2 origin:( {0}, {1} )", 
								  Line.origin.x, 
								  Line.origin.y );

		System.Console.WriteLine( "Line2 ending:( {0}, {1} )", 
								  line2.ending.x, 
								  line2.ending.y );

		Line.origin.x 	= 947;
		Line.origin.y 	= 476;
		
		System.Console.WriteLine( "Line1 origin:( {0}, {1} )", 
								  Line.origin.x, 
								  Line.origin.y );

		System.Console.WriteLine( "Line1 ending:( {0}, {1} )", 
								  line1.ending.x, 
								  line1.ending.y );

		System.Console.WriteLine( "Line2 origin:( {0}, {1} )", 
								  Line.origin.x, 
								  Line.origin.y );

		System.Console.WriteLine( "Line2 ending:( {0}, {1} )", 
								  line2.ending.x, 
								  line2.ending.y );


	}
}

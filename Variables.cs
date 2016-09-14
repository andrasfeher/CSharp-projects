using System;

class Variables
{
	public static void Main()
	{
		// változók bevezetése
		int radius = 25;
		const double PI = 3.141592;
		double circum, area;
		
		// számÍtások
		area = PI * radius * radius;
		circum = 2 * PI * radius;
		
		// eredmények kiÍratása
		Console.WriteLine( "Radius = {0}, PI = {1}", radius, PI );
		Console.WriteLine( "The area is {0}", area );
		Console.WriteLine( "The circumference is {0}", circum );
	}
}

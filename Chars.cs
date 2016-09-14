using System;

class Chars
{
	public static void Main()
	{
		int ctr;
		char ch;
		
		Console.WriteLine("\nNumber   Value\n");
		
		for( ctr = 95; ctr <= 128; ctr++ )
		{
			ch = (char) ctr;
			Console.WriteLine( "{0:D4} is {1}", ctr, ch );
		}
	}
}

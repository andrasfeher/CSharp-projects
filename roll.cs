using System;

class roll
{
	public static void Main()
	{
		int roll = 0;
		
		Random rnd = new Random();
		
		roll = ( int ) rnd.Next( 1, 7 );
		
		Console.WriteLine( "Starting the switch ...." );
		
		switch ( roll )
		{
			case 1: 
				Console.WriteLine( "Roll is 1" );
				break;
			case 2: 
				Console.WriteLine( "Roll is 2" );
				break;
			case 3: 
				Console.WriteLine( "Roll is 3" );
				break;
			case 4: 
				Console.WriteLine( "Roll is 4" );
				break;
			case 5: 
				Console.WriteLine( "Roll is 5" );
				break;
			case 6: 
				Console.WriteLine( "Roll is 6" );
				break;
			default:
				Console.WriteLine( "Roll is not 1-6" );
				break;
		}

		Console.WriteLine( "Switch statement is over." );
	}
}

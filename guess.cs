using System;
using System.Drawing;
using System.Text;

public class Guess
{
	private static int getRandomNumber( int nbr )
	{
		if ( nbr > 0 )
		{
			Random Rnd = new Random();
			return ( Rnd.Next( 0, nbr ) );
		}
		else
		{
			return 0;
		}
	}	
	
	private static void writeStats( string guess, int nbr, string err )
	{
		Console.WriteLine( "\n===================================" );
		Console.WriteLine( "Current guess: {0}", guess );
		Console.WriteLine( "Number of guesses: {0}", nbr );
		
		if ( err != "")
			Console.WriteLine( err );
		
		Console.WriteLine( "Enter a number from 1 to 10000" );		
		Console.WriteLine( "\n===================================" );
		
		return;		
	}

	public static void Main( string[] args )
	{
		int winningNumber = Guess.getRandomNumber( 10000 );
		
		int guesses = 0;
		string curr = "";
		int val = 0;
		string errMsg;
		
		bool cont = true;
		
		writeStats( curr, guesses, (string) "" );
	
		while ( cont == true )
		{
			Console.Write( "\nEnter guess: " );
			curr = Console.ReadLine();
			
			try
			{
				val = Convert.ToInt32( curr );
				guesses += 1;
				
				if ( val < 0 || val > 10000 )
				{
					errMsg = "Number is out of range... Try again";
					writeStats( curr, guesses, errMsg );
				}
				else
				{
					if ( val < winningNumber )
					{
						errMsg = "You guessed low... Try again";
						writeStats( curr, guesses, errMsg );
					}
					else 
					if ( val > winningNumber )
					{
						errMsg = "You guessed high... Try again";
						writeStats( curr, guesses, errMsg );
					}
					else
					{
						Console.WriteLine( "\nCurrent guess: {0}\n", val );
						Console.WriteLine( "Number of guesses: {0}\n", guesses );
						cont = false;
					}
				}
			}
	
			catch( FormatException )
			{
				errMsg = "Please enter a valid number....";
				writeStats( curr, guesses, errMsg );
			}
			
		}
	
	}
}

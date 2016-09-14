#define CURRENT

using System;
using System.IO;
using System.Text;

class MyThreeException : Exception{}

// metódus túlterhelés
public class Rectangle
{
    private const int defSide = 10; // konstans
    
    public int Area( )
    {
        return defSide * defSide;
    }

    public int Area( int side )
    {
        return side * side;
    }

    public int Area( int side1, int side2 )
    {
        return side1 * side2;
    }

}

public class AddEm
{
    public static long Add( params int[] args )
    {
        int i = 0;
        int total = 0;
        
        for ( i = 0; i < args.Length; i++ )
        {
            total = total + args[ i ];
        }
        
        return total;
    }
}

class Garbage
{
    public static void Print( params object[] args )
    {
        int i = 0;

        for ( i = 0; i < args.Length; i++ )
        {
            Console.WriteLine( "Param {0} - {1}", i, args[ i ] );
        }
    }
}

namespace Consts
{
    public class PI
    {
        public static double value = 3.1415926;
        private PI() {} // privát konstruktor, hogy ne lehessen belőle osztályt létrehozni 
    }
}

class MyMath
{
    static public int AddEm( int x, int y )
    {
        if ( x == 3 || y == 3 )
        {
            throw( new MyThreeException() );
        }

        return x + y;
    }
}


class Person
{
    protected string firstName;
    protected string middleName;
    protected string lastName;
    private int age;

    public Person()
    {
    }

    public Person( string fn, string ln )
    {
        firstName = fn;
        lastName  = ln;
    }

    public Person( string fn, string mn, string ln )
    {
        firstName  = fn;
        middleName = mn;
        lastName   = ln;
    }

    public Person( string fn, string mn, string ln, int a )
    {
        firstName  = fn;
        middleName = mn;
        lastName   = ln;
        age        = a;
    }

    public void DisplayAge()
    {
        Console.WriteLine( "Age : {0}", age );
    }

    public void DisplayFullName()
    {
        /*
        StringBuilder fullName = new StringBuilder();

        fullName.Append( firstName );
        fullName.Append( " " );

        if ( middleName != "" )
        {
            fullName.Append( middleName[ 0 ] );
            fullName.Append( ". " );
        }

        fullName.Append( lastName );
        
        Console.WriteLine( fullName );
        
        */
        
        Console.WriteLine("{0} {1}", firstName, lastName );

    }

}


class Employee : Person
{
    private ushort hYear;
    
    public ushort hireYear
    {
        get{ return( hYear ); }
        set{ hYear = value; }
    }
    
    public Employee() : base()
    {
    }
    
    public Employee( string fn, string ln ) : base( fn, ln )
    {
    }

    public Employee( string fn, string mn, string ln ) : base( fn, mn, ln )
    {
    }

    public Employee( string fn, string mn, string ln, int a ) : base( fn, mn, ln, a )
    {
        
    }

    public Employee( string fn, string ln, ushort hy ) : base( fn, ln )
    {
        hireYear = hy;
    }
    
    public new void DisplayFullName()
    {
        
        Console.WriteLine( "Employee: {0} {1} {2}", 
                           firstName,
                           middleName,
                           lastName
                         );
        
        //Console.Write( "Employee:" );
        // ez nem működik mono alatt
        //base.DisplayFullName();
        
    }

}

sealed public class Number
{
    private float pi;
    
    public Number()
    {
        pi = 3.141592F;
    }
    
    public float PI
    {
        get{ return pi; }
    }
}

/* ki van kommentezve, mert lezárt osztályból nem lehet származtatni

public class Numbers : Number
{
    public float myVal = 123.456F;
}
*/

sealed public class PI
{
    private static float pi;
    
    public PI()
    {
        pi = 3.141592F;
    }
    
    public static float Val()
    {
        return pi;
    }
}


/*******************************************************************************
*******************************************************************************/
class Test
{

    enum Pet
    {
        Cat,
        Dog,
        Fish,
        Snake,
        Rat,
        Hamster,
        Bird
    }

    public static void Main( string[] args )
    {
    
        #if CURRENT
        /***********************************************************************/
        
        // az Environment osztály használata
        
        Console.WriteLine( "==================================================" );
        Console.WriteLine( "Command    : {0}", Environment.CommandLine );
        Console.WriteLine( "Current dir: {0}", Environment.CurrentDirectory );
        Console.WriteLine( "System dir : {0}", Environment.SystemDirectory );
        Console.WriteLine( "Version    : {0}", Environment.Version );
        Console.WriteLine( "OS Version : {0}", Environment.OSVersion );
        Console.WriteLine( "Machine    : {0}", Environment.MachineName );
        Console.WriteLine( "Memory     : {0}", Environment.WorkingSet );
        
        Console.WriteLine( "==================================================" );
        string[] drives = Environment.GetLogicalDrives();
        
        for ( int x = 0; x < drives.Length; x++ )
        {
            Console.WriteLine( "Drive {0}: {1}", x, drives[x] );
        }
        
        Console.WriteLine( "==================================================" );
       
        Console.WriteLine( "Path: {0}", Environment.GetEnvironmentVariable( "Path" ) );
        
        
        
        /***********************************************************************/
        #else
        // kimenet formázása
        
        int intvar = 12345;
        float var  = 12345.56F;
        float longvar  = .00000556F;
        
        // formázás WriteLine segítségével
        
        // pénznem
        Console.WriteLine( "Pénznem:{0:C}\n{0:C4}", var ); 
        
        //  fixpontos
        Console.WriteLine( "Fixpontos: {0:f}\n{0:f3}", var );
        
        // decimális ( floatnál kivétel keletkezik)
        Console.WriteLine( "Decimális: {0:D}", intvar );        
        
        // Számérték
        Console.WriteLine( "Számérték: {0:N}", var );        
        
        // hexa ( floatnál kivétel keletkezik)
        Console.WriteLine( "Hexa: {0:X}", intvar );         
        
        // általános: a lehető legrövidebb
        Console.WriteLine( "Általános rövid: {0:G}", var );    
        Console.WriteLine( "Általános hosszú: {0:G}", longvar );    

        // általános: a lehető legrövidebb
        Console.WriteLine( "Hatványalak: {0:E}", var );  
        
        /*
                        Eredmény:
                        --------------------------------------------------------------------
                        Pénznem:12 345,56 Ft
                        12 345,5600 Ft
                        Fixpontos: 12345,56
                        12345,560
                        Decimális: 12345
                        Számérték: 12 345,56
                        Hexa: 3039
                        Általános rövid: 12345,56
                        Általános hosszú: 5,56E-06
                        Hatványalak: 1,234556E+004
                         */

        // formázás ToString segítségével
        
        string str1 = var.ToString( "C" );    
        string str2 = var.ToString( "C3" );   
        string str3 = var.ToString( "E8" );   
        
        Console.WriteLine( str1 );
        Console.WriteLine( str2 );
        Console.WriteLine( str3 );

        /*
                        Eredmény:
                        --------------------------------------------------------------------
                        12 345,56 Ft
                        12 345,560 Ft
                        1,23455600E+004
                        */

        // formázás a string.Format segítségével
        
        string str5 = string.Format( "{0:F3} \n{0:C} \n{0:C0}", var );  
        Console.WriteLine( str5 );
        
        /*
                        Eredmény:
                        --------------------------------------------------------------------
                        12345,560 
                        12 345,56 Ft 
                        12 346 Ft
                        */
                        
        // egyedi formátumok leírása képleírók segítségével
        
        int var1 = 1234;
        float var2 = 12.34F;
        
        Console.WriteLine( " Egyedi formátumok leírása képleírók segítségéve", var1 );
        
        // nulla formázó
        Console.WriteLine( "{0} ---> {0:0000000}", var1 );
        Console.WriteLine( "{0} ---> {0:0000000}", var2 );
        
        /*
                        1234 ---> 0001234
                        12,34 ---> 0000012
                        */
        
        // térköz formázó
        Console.WriteLine( "{0} ---> {0:0####}", var1 );
        Console.WriteLine( "{0} ---> {0:0####}", var2 );
        /*
                        1234 ---> 01234
                        12,34 ---> 012
                        */
        
        // csoportválasztó és többszöröző
        Console.WriteLine( "{0} ---> {0:0,,}<---", 1000000 );
        Console.WriteLine( "{0} ---> {0:##,###,##0}", 20000000 );
        Console.WriteLine( "{0} ---> {0:##,###,##0}", 3 );
        /*
                        1000000 ---> 1000000<---
                        20000000 ---> 20 000 000
                        3 --->  000 003     
                        */
        
        // százalékformázó
        Console.WriteLine( "{0} ---> {0:0%}<---", var1 );
        Console.WriteLine( "{0} ---> {0:0%}<---", var2 );
        /*
                        1234 ---> 123400%<---
                        12,34 ---> 1234%<---
                        */
        
        
        // literális formázás
        Console.WriteLine( "{0} ---> {0:'My number: '0}<---", var1 );
        Console.WriteLine( "{0} ---> {0:'My number: '0}<---", var2 );
        Console.WriteLine( "{0} ---> {0:Mine: 0}<---", var1 );
        Console.WriteLine( "{0} ---> {0:Mine: 0}<---", var2 );
        /*
                        1234 ---> My number: 1234<---
                        12,34 ---> My number: 12<---
                        1234 ---> Mine: 1234<---
                        12,34 ---> 1,Mine1 0<---
                        */
        // Convert osztály használata
        
        string buff;
        int age;
        
        Console.Write( "Enter your age: " );
        
        buff = Console.ReadLine();
        
        try
        {
            age = Convert.ToInt32( buff );

            if ( age < 21 )
            {
                Console.WriteLine( "You are under 21" );
            }
            else
            {
                Console.WriteLine( "You are over 21" );
            }
        }
        
        
        catch ( ArgumentException ) 
        {
            Console.WriteLine( "No value was entered...(equal to null)" );
        }
        catch ( OverflowException ) 
        {
            Console.WriteLine( "Number too big or too small" );
        }
        catch ( FormatException ) 
        {
            Console.WriteLine( "Invalid number" );
        }
        catch ( Exception e ) 
        {
            Console.WriteLine( "Error occurred at conversion" );
            throw( e );
        }


        // olvasás konzolról
        
        StringBuilder input = new StringBuilder();
        int ival;
        char ch = ' ';
        
        Console.WriteLine( "Enter text. When done, press CTRL+Z ( CTRL+D on Linux )" );
            
        while ( true )
        {
            ival = Console.Read();
            
            if ( ival == -1 )
            {
                break;
            }
            
            ch = ( char ) ival;
            
            input.Append( ch );
        }
        
        Console.WriteLine( "\n\n==================================>\n" );
        Console.WriteLine( input );
        Console.WriteLine( "\n" );
        

        // StringBuilder osztály használata
        
        StringBuilder name = new StringBuilder();
        string buffer;
        int marker = 0;
        
        Console.Write( "\nEnter your first name: " );
        buffer = Console.ReadLine();
        
        if ( buffer != null )
        {
            name.Append( buffer );
            marker = name.Length;
        }

       
        Console.Write( "\nEnter your last name: " );
        buffer = Console.ReadLine();

        if ( buffer != null )
        {
            name.Append( " " );
            name.Append( buffer );
        }
        
        Console.Write( "\nEnter your middle name: " );
        buffer = Console.ReadLine();

        Console.WriteLine( "Marker: {0}", marker );
        
        if ( buffer != null )
        {
            name.Insert( marker + 1, buffer );
            name.Insert( marker + buffer.Length + 1, " " );
        }

        Console.WriteLine( "\n\nFull name: {0}", name );
        
        // statisztika
        
        Console.WriteLine( "\n\nInfo about StringBuilder string:" );
        Console.WriteLine( "Value: {0}", name );
        Console.WriteLine( "Capacity: {0}", name.Capacity );
        Console.WriteLine( "Maximum capacity: {0}", name.MaxCapacity );
        Console.WriteLine( "Length: {0}", name.Length );
        
        // felsoroló típusú értékek formázása
        Pet myPet   = Pet.Fish;
        Pet yourPet = Pet.Hamster;
        
        Console.WriteLine( "Using myPet:" );
        Console.WriteLine( "d: {0:d}", myPet ); 
        Console.WriteLine( "D: {0:D}", myPet ); 
        Console.WriteLine( "g: {0:g}", myPet ); 
        Console.WriteLine( "G: {0:G}", myPet ); 
        Console.WriteLine( "x: {0:x}", myPet ); 
        Console.WriteLine( "X: {0:X}", myPet ); 
        
        Console.WriteLine( "Using yourPet:" );
        Console.WriteLine( "d: {0:d}", yourPet ); 
        Console.WriteLine( "D: {0:D}", yourPet ); 
        Console.WriteLine( "g: {0:g}", yourPet ); 
        Console.WriteLine( "G: {0:G}", yourPet ); 
        Console.WriteLine( "x: {0:x}", yourPet ); 
        Console.WriteLine( "X: {0:X}", yourPet ); 
        
        /*
                        Using myPet:
                        d: 2
                        D: 2
                        g: Fish
                        G: Fish
                        x: 00000002
                        X: 00000002

                        Using yourPet:
                        d: 5
                        D: 5
                        g: Hamster
                        G: Hamster
                        x: 00000005
                        X: 00000005
        
                        */

        // dátum formázása
        DateTime CurrTime = DateTime.Now;
        
        Console.WriteLine( "d: {0:d}", CurrTime ); 
        Console.WriteLine( "D: {0:D}", CurrTime ); 
        Console.WriteLine( "f: {0:f}", CurrTime ); 
        Console.WriteLine( "F: {0:F}", CurrTime ); 
        Console.WriteLine( "g: {0:g}", CurrTime ); 
        Console.WriteLine( "G: {0:G}", CurrTime ); 
        Console.WriteLine( "m: {0:m}", CurrTime ); 
        Console.WriteLine( "M: {0:M}", CurrTime ); 
        Console.WriteLine( "r: {0:r}", CurrTime ); 
        Console.WriteLine( "R: {0:R}", CurrTime ); 
        Console.WriteLine( "s: {0:s}", CurrTime ); 
        Console.WriteLine( "t: {0:t}", CurrTime ); 
        Console.WriteLine( "T: {0:T}", CurrTime ); 
        Console.WriteLine( "u: {0:u}", CurrTime ); 
        Console.WriteLine( "U: {0:U}", CurrTime ); 
        Console.WriteLine( "y: {0:y}", CurrTime ); 
        Console.WriteLine( "Y: {0:Y}", CurrTime ); 
        
        /*
                        d: 2005. 07. 22.
                        D: 2005. július 22.
                        f: 2005. július 22. 15:27
                        F: 2005. július 22. 15:27:22 +2
                        g: 2005. 07. 22. 15:27
                        G: 2005. 07. 22. 15:27:22
                        m: július 22
                        M: július 22
                        r: Fri, 22 Jul 2005 15:27:22 GMT
                        R: Fri, 22 Jul 2005 15:27:22 GMT
                        s: 2005-07-22T15:27:22
                        t: 15:27
                        T: 15:27:22
                        u: 2005-07-22 15:27:22Z
                        U: 2005. július 22. 15:27:22 +2
                        y: 2005. július
                        Y: 2005. július
                        */


        // objektumok tömbje
        
        Employee[] myCompany = new Employee[ 4 ]; 
        
        Employee emp   = new Employee( "Tercsi", "L.", "Jones", 23 );
        myCompany[ 0 ] = emp;

        emp = new Employee( "Fercsi", "L.", "Jones", 23 );
        myCompany[ 1 ] = emp;
        
        emp = new Employee( "Kata", "L.", "Jones", 23 );
        myCompany[ 2 ] = emp;
        
        emp = new Employee( "Klara", "L.", "Jones", 23 );
        myCompany[ 3 ] = emp;
        
        for ( int i = 0; i <= 3; i ++ )
        {
            myCompany[ i ].DisplayFullName();
        }

        // is - azonos-e a típusa az egyik objektumnak a másikéval?

        Person myWife = new Person( "Melissa", "Anne", "Jones", 21 );
        Employee me   = new Employee( "Bradley", "L.", "Jones", 23 );

        if ( myWife is Employee )
        {
            Console.WriteLine( "myWife is Employee" );
        }
        else
        {
            Console.WriteLine( "myWife is NOT Employee" );
        }
        
        if ( myWife is Person )
        {
            Console.WriteLine( "myWife is Person" );
        }
        else
        {
            Console.WriteLine( "myWife is NOT Person" );
        }


        // Object osztály és két alapvető metódusa: ToString() és GetType()
        
        Console.WriteLine( "PI = {0}", PI.Val() );
        
        Object x = new PI();
        
        Console.WriteLine( "ToString : {0}", x.ToString() );
        Console.WriteLine( "Type : {0}", x.GetType() );

        Console.WriteLine( "ToString : {0}", 123.ToString() );
        Console.WriteLine( "Type : {0}", 123.GetType() );

        // osztály lezárása
        
        Number myNumber = new Number();
        Console.WriteLine( "PI = {0}", myNumber.PI );
        
        Numbers newNumbers = new Numbers();
        Console.WriteLine( "PI = {0}", newNumber.PI );
        Console.WriteLine( "myVal = {0}", newNumber.myVal );
        
        // többalakúság és származtatatott osztályok
        
        Employee me = new Employee( "Bradley",  "Jones", 2003 );
        
        Person Brad = me;
        
        me.DisplayFullName();
        
        Console.WriteLine( "You hired me in: {0}", me.hireYear );
        
        Brad.DisplayFullName();
 
        // öröklődés
        
        Person myWife = new Person( "Melissa", "Anne", "Jones", 21 );
        Employee me   = new Employee( "Bradley", "L.", "Jones", 23 );
        Employee you  = new Employee( "Eyle", "Rinn", 2003 );

        myWife.DisplayFullName();
        myWife.DisplayAge();

        me.DisplayFullName();
        Console.WriteLine( "Year hired: {0}", me.hireYear );
        me.DisplayAge();

        you.DisplayFullName();
        Console.WriteLine( "Year hired of him: {0}", you.hireYear );
        you.DisplayAge();


        // metódus túlterhelés
        Rectangle rect = new Rectangle();
        
        Console.WriteLine( "Default area   = {0}", rect.Area( ) );
        Console.WriteLine( "Square area    = {0}", rect.Area( 4 ) );
        Console.WriteLine( "Rectangle area = {0}", rect.Area( 5, 5 ) );

        // változó számú paraméter azonos adattípussal
        Console.WriteLine( "Result of sum  = {0}", AddEm.Add( 1, 2, 3, 4 ) );

        // változó számú paraméter különböző adattípusokkal
        Garbage.Print( "Tercsi", 1, "Fercsi" );

        // program parancssor paramétereinek feldolgozása
        for ( int i = 0; i < args.Length; i++ )
        {
            Console.WriteLine( "Command line param {0} - {1}", i, args[ i ] );
        }
        
        // saját névtér megadása
        Console.WriteLine( "Own PI = {0}", Consts.PI.value );
        
        // try - catch használata
        int[] myArray = new int[ 5 ];
        
        try
        {
            

            for ( int i = 0; i < 10; i++ )
            {
                myArray[ i ] = i; 
            }
        }
        catch
        {
            Console.WriteLine( "Exception caught" );
        }

        // kivétellel kapcsolatos információ fogadása
        try
        {
            for ( int i = 0; i < 10; i++ )
            {
                myArray[ i ] = i; 
            }
        }
        catch( Exception e )
        {
            Console.WriteLine( "Exception caught:{0}", e );
        }
        
        // egy megadott típusú kivétel elfogása
        try
        {
            for ( int i = 0; i < 10; i++ )
            {
                myArray[ i ] = i; 
            }
        }
        catch( IndexOutOfRangeException e )
        {
            Console.WriteLine( "Index out of range" );
        }
        catch( Exception e )
        {
            Console.WriteLine( "Exception caught:{0}", e );
        }
        
        Console.WriteLine( "Done with the catch statements" );
        
        // finally kulcsszó használata
        // kikommentezve, mert finally miatt az utána követekező programrész nem futna le
        /*
        try
        {
            for ( int i = 0; i < 10; i++ )
            {
                myArray[ i ] = i; 
            }
        }
        finally
        {
            Console.WriteLine( "Done with the catch statements" );
        }
        */
        
        // forrásfile kiíratása a konzolra
    
        try
        {
            if ( args.Length <= 0 )
            {
                Console.WriteLine( "Usage: test.exe <source file name>" );
                return;
            }
            else
            {

                FileStream fstr = new FileStream( args[ 0 ], FileMode.Open );

                try
                {
                    StreamReader sReader = new StreamReader( fstr );
                    string line;
                    int i = 0;
                    
                    while ( ( line = sReader.ReadLine() ) != null )
                    {
                        i++;
                        Console.WriteLine( "{0}  {1}", i, line );
                    }
                }
    
                catch( Exception e )
                {
                    Console.WriteLine( "Exception during read/write {0}\n", e );
                }
                finally
                {
                    fstr.Close();
                }

            }
            
        }

        catch( System.IO.FileNotFoundException )
        {
            Console.WriteLine( "Could not found file {0}", args[ 0 ] );
        }
        catch( Exception e )
        {
            Console.WriteLine( "Exception {0}\n\n", e );
        }
        
        
        // öröklődés

        Person me     = new Person( "Bradley", "Lee", "Jones" );
        Person myWife = new Person( "Melissa", "Anne", "Jones", 21 );

        me.DisplayFullName();
        me.DisplayAge();

        myWife.DisplayFullName();
        myWife.DisplayAge();
        
	    // saját kivétel dobása

        int result;

		try
		{
			result = MyMath.AddEm( 1, 2 );
			Console.WriteLine( "Result of AddEm( 1, 2 ) is {0}", result );

			result = MyMath.AddEm( 3, 4 );
			Console.WriteLine( "Result of AddEm( 3, 4 ) is {0}", result );
		}

		catch( MyThreeException )
		{
			Console.WriteLine( "I don't like adding threes" );
		}

		catch( Exception e )
		{
			Console.WriteLine( "Exception caught {0}", e );
		}

		Console.WriteLine( "End of program" );

    #endif

    }
}

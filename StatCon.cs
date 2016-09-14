using System;

public class MyClass
{
    static public int sctr = 0;
    public int ctr = 0;
    
    public void routine()
    {
        sctr ++;
        ctr ++;
            
        Console.WriteLine( "In the routine : sctr = {0} / ctr = {1}",
                            sctr,
                            ctr
                         );
    }    
    
    static MyClass()
    {
        sctr = 100;

        Console.WriteLine( "In the static constructor : sctr = {0}",
                            sctr
                         );

    }
}

class Constr
{
    public static void Main()
    {
        Console.WriteLine( "Start of main method ..." );

        Console.WriteLine( "Creating first object ..." );
        MyClass first = new MyClass();
        
        Console.WriteLine( "Creating second object ..." );
        MyClass second = new MyClass();

        Console.WriteLine( "Calling first routine ..." );
        first.routine();
        
        Console.WriteLine( "Creating third object ..." );
        MyClass third = new MyClass();

        Console.WriteLine( "Calling third routine ..." );
        third.routine();

        Console.WriteLine( "Calling second routine ..." );
        second.routine();

        Console.WriteLine( "End of main method ..." );

    }
}

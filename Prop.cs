class Point
{
    int my_X;
    int my_Y;
    
    public int x
    {
        get
        {
            return my_X;
        }
        set
        {
            my_X = value;
        }
    }

    public int y
    {
        get
        {
            return my_Y;
        }
        set
        {
            my_Y = value;
        }
    }
}

class PropApp
{
    public static void Main()
    {
    
        Point starting  = new Point();
        Point ending    = new Point();
        
        starting.x = 1;
        starting.y = 4;
    
        ending.x = 34;
        ending.y = 45;
    
        System.Console.WriteLine( "Starting point: ( {0}, {1} )",
                                  starting.x,
                                  starting.y
                                );
                                
        System.Console.WriteLine( "Ending point: ( {0}, {1} )",
                                  ending.x,
                                  ending.y
                                );
    }
}

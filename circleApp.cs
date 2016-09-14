using System;

class Circle
{
   
    public double getArea( double radius )
    {
        return 3.1415926 * radius * radius;
    }
    
    public double getCircumference( double radius )
    {
        return 2 * 3.1415926 * radius;
    }
}

class circleApp
{
    public static void Main()
    {
        Circle firstCircle  = new Circle();
        Circle secondCircle = new Circle();
        
        Console.WriteLine( "Area of first circle:{0}", firstCircle.getArea( 4 ) );
        Console.WriteLine( "Circumference of first circle:{0}", 
                            firstCircle.getCircumference( 4 ) );
                            
        Console.WriteLine( "Area of second circle:{0}", secondCircle.getArea( 16 ) );
        Console.WriteLine( "Circumference of second circle:{0}", 
                            secondCircle.getCircumference( 16 ) );
    }
}

// Az első hét összefoglalója

using System;

//------------------------------------------------------------------------------
///<summary>
/// Ez egy pontstruktűra
///</summary>

struct Point
{
    public int x;
    public int y;
    
    Point( int x, int y )
    {
        this.x = x;
        this.y = y;
    }
}

///<summary>
/// A Line osztály nem tartalmaz túl sok műveleti lehetőséget
///</summary>
class Line
{
    private Point lineStart;
    private Point lineEnd;
    
    public Point start
    {
        get { return lineStart }
        set
        {
            if ( value.x < 0 )
                lineStart.x = 0;
            else
                lineStart.x = value.x;
                
            if ( value.y < 0 )
                lineStart.y = 0;
            else
                lineStart.y = value.y;
        }

    public Point end
    {
        get { return lineEnd }
        set
        {
            if ( value.x < 0 )
                lineEnd.x = 0;
            else
                lineEnd.x = value.x;
                
            if ( value.y < 0 )
                lineEnd.y = 0;
            else
                lineEnd.y = value.y;
        }
        
        public double getLength
        {
            int x_diff;
            int y_diff;
            double lenght;
            
            x_diff = lineEnd.x - lineStart.x;
            y_diff = lineEnd.y - lineStart.y;
            
            return ( double ) Math.Sqrt( ( x_diff * x_diff ) + ( y_diff * y_diff ) );
        }
        
        public void displayInfo
        {
            Console.WriteLine( "\n\n-------------------------" );
            Console.WriteLine( "   Line stats:" );
            Console.WriteLine( "-------------------------" );
            
            Console.WriteLine( "Start point: ( {0}, {1} )", 
                               lineStart.x,
                               lineStart.y
                             );
            Console.WriteLine( "End point: ( {0}, {1} )", 
                               lineEnd.x,
                               lineEnd.y
                             );
            Console.WriteLine( "-------------------------" );
        }
        
        public Line
        {
            lineStart = new Point();
            lineEnd   = new Point();
        }
    }
}

///<summary>
/// Négyzetekkel kapcsolatos lehetőségek
///</summary>
class Square
{
    private Line squareHight;
    private Line squareWidth;
    
    public Line height
    {
        get { return squareHight }
        set
        {
            squareHight.start = value.start;
            squareHight.end   = value.end;
        }
    }
    
    public Line width
    {
        get { return squareWidth }
        set
        {
            squareWidth.start = value.start;
            squareWidth.end   = value.end;
        }
    }
    
}

using System;

public class Element
{
    protected string name;
    protected Element left  = null;
    protected Element right = null;

    public Element( string name )
    {
        this.name = name;
    }

    public string GetName()
    {
        return this.name;
    }

    public void ConnectLeft( Element left )
    {
        this.left = left;
    }

    public void ConnectRight( Element right )
    {
        this.right = right;
    }

    public Element GetRight()
    {
        return this.right;
    }
}

public class DynList
{
    protected Element first;
    protected Element last;

    public DynList( )
    {
         this.first = new Element( "First" );
         this.last = this.first;
    }

    public void AddElement( string name )
    {
   	    Element myElement = new Element( name );
        this.last.ConnectRight( myElement );
        this.last = myElement;
    }

    public bool DeleteElement( string name )
    {
   	    Element curr = this.first.GetRight();
        bool result = false;

        if ( curr != null )
        {
            Element prev = this.first;

            while ( name != curr.GetName() )
            {
                prev = curr;
                curr = curr.GetRight();
            }

            if ( curr.GetRight() == null ) // utolsó elem
            {
                prev.ConnectRight( null );
                this.last =  prev;
            }
            else
            {
                prev.ConnectRight( curr.GetRight() );
            }

            result = true;
        }

        return result;
    }

    public bool PrintContent()
    {
   	    Element curr = this.first.GetRight();

        bool result = false;

        if ( curr != null )
        {
            result = true;

            while ( curr != null )
            {
                Console.WriteLine( curr.GetName() );
                curr = curr.GetRight();
            }
        }

        return result;

    }

}


public class DynlistHandler
{
    public static void Main()
   	{
   	    DynList myDynList = new DynList();
   	    for ( int i = 0; i < 256; i ++ )
   	    {
       	    myDynList.AddElement( i.ToString() );
   	    }

        myDynList.DeleteElement( "2" );
        myDynList.DeleteElement( "4" );
        myDynList.DeleteElement( "9" );
        myDynList.DeleteElement( "3" );

        myDynList.PrintContent();

   	}
}
// címke használata
using System;
using System.Windows.Forms;
using System.Drawing;

public class PopApp : Form
{
    public PopApp()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Pop Up Menu Application";

          // vezérlõk létrehozása
        CreatePopUp();
    }

    protected void PopUp_Selection( object sender, System.EventArgs e )
    {
        this.Text = ( ( MenuItem ) sender ).Text;
    }

    public void CreatePopUp()
    {
        ContextMenu myPopUp = new ContextMenu();

        myPopUp.MenuItems.Add( "First Item", new EventHandler( this.PopUp_Selection ) );
        myPopUp.MenuItems.Add( "Second Item", new EventHandler( this.PopUp_Selection ) );
        myPopUp.MenuItems.Add( "-");
        myPopUp.MenuItems.Add( "Third Item", new EventHandler( this.PopUp_Selection ) );

        this.ContextMenu = myPopUp;
    }

    public static void Main( string[] args)
    {

        Application.Run( new PopApp() );
    }
}

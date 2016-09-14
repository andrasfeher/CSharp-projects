// beépített párbeszédablakok használata
using System;
using System.Windows.Forms;
using System.Drawing;

public class MsgBoxApp : Form
{
    private ContextMenu myPopUp = new ContextMenu();


    public MsgBoxApp()
    {
        MessageBox.Show( "Application has been started", "Status" );
        InitializeComponent();
        MessageBox.Show( "Component Initialized", "Status" );
    }

    private void InitializeComponent()
    {
        this.Text = "Pop Up Menu Application";
          // vezérlõk létrehozása
        CreatePopUp();
    }

    protected void PopUp_Selection( object sender, System.EventArgs e )
    {
        if ( ( ( MenuItem ) sender ).Text == "Colors Dialog" )
        {
            ColorDialog myColorDialog = new ColorDialog();
            myColorDialog.ShowDialog();
        }
        else
        {
            MessageBox.Show( ( ( MenuItem ) sender ).Text, "Status" );
        }
    }

    public void CreatePopUp()
    {


        myPopUp.MenuItems.Add( "First Item", new EventHandler( this.PopUp_Selection ) );
        myPopUp.MenuItems.Add( "Second Item", new EventHandler( this.PopUp_Selection ) );
        myPopUp.MenuItems.Add( "-");
        myPopUp.MenuItems.Add( "Colors Dialog", new EventHandler( this.PopUp_Selection ) );

        this.ContextMenu = myPopUp;
    }

    public static void Main( string[] args)
    {

        Application.Run( new MsgBoxApp() );
        MessageBox.Show( "Application Exited", "Status" );
    }
}

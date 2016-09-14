// címke használata
using System;
using System.Windows.Forms;
using System.Drawing;

public class MenuApp : Form
{
    private Label myDateLabel = new Label();

    private MainMenu myMainMenu = new MainMenu();

    public MenuApp()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Menu Application";
        this.StartPosition = FormStartPosition.CenterScreen;

          // vezérlõk létrehozása

        DateTime currDate    = DateTime.Now;
        myDateLabel.Text     = currDate.ToString();
        myDateLabel.AutoSize = true;
        myDateLabel.Left     = 60;
        myDateLabel.Top      = 20;


        this.Width  = myDateLabel.PreferredWidth
                        + 110;
        this.Height = myDateLabel.PreferredHeight + 100;

        MenuItem menuItemFile = myMainMenu.MenuItems.Add( "File" );
        menuItemFile.MenuItems.Add( new MenuItem( "Update date",
                                                   new EventHandler( this.MenuUpdate_Selection )
                                                 )
                                  );
        menuItemFile.MenuItems.Add(  new MenuItem( "Exit",
                                                   new EventHandler( this.FileExit_Selection )
                                                 )
                                  );

        // vezérlõk elhelyezése az ablakon
        this.Menu = myMainMenu;
        this.Controls.Add( myDateLabel );
    }

    protected void MenuUpdate_Selection( object sender, System.EventArgs e )
    {
        DateTime currDate = new DateTime();

        currDate              = DateTime.Now;
        this.myDateLabel.Text = currDate.ToString();
    }

    protected void FileExit_Selection( object sender, System.EventArgs e )
    {
        this.Close();
    }

    public static void Main( string[] args)
    {

        Application.Run( new MenuApp() );
    }
}

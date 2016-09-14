// címke használata
using System;
using System.Windows.Forms;
using System.Drawing;

public class MenusApp : Form
{
    private Label myDateLabel = new Label();

    private MainMenu myMainMenu = new MainMenu();

    public MenusApp()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text            = "Menu Application";
        this.FormBorderStyle = FormBorderStyle.Fixed3D;
        this.StartPosition   = FormStartPosition.CenterScreen;

          // vezérlõk létrehozása

        DateTime currDate    = DateTime.Now;
        myDateLabel.Text     = currDate.ToString();
        myDateLabel.AutoSize = true;
        myDateLabel.Left     = 60;
        myDateLabel.Top      = 20;


        this.Width  = myDateLabel.PreferredWidth
                        + 110;
        this.Height = myDateLabel.PreferredHeight + 100;

        CreateMyMenu();


        // vezérlõk elhelyezése az ablakon
        this.Controls.Add( myDateLabel );
    }

    protected void FileUpdate_Selection( object sender, System.EventArgs e )
    {
        DateTime currDate = new DateTime();

        currDate              = DateTime.Now;
        this.myDateLabel.Text = currDate.ToString();
    }

    protected void FileExit_Selection( object sender, System.EventArgs e )
    {
        this.Close();
    }

    protected void HelpAbout_Selection( object sender, System.EventArgs e )
    {
        //névjegy ablak megjelenítése;
    }

    public void CreateMyMenu()
    {
        MenuItem menuItemFile = myMainMenu.MenuItems.Add( "&File" );
        menuItemFile.MenuItems.Add( new MenuItem( "Update &Date",
                                                   new EventHandler( this.FileUpdate_Selection ),
                                                   Shortcut.CtrlD
                                                 )
                                  );
        menuItemFile.MenuItems.Add(  new MenuItem( "Exit",
                                                   new EventHandler( this.FileExit_Selection ),
                                                   Shortcut.CtrlX
                                                 )
                                  );

        MenuItem menuItemHelp = myMainMenu.MenuItems.Add( "&Help" );
        menuItemHelp.MenuItems.Add(  new MenuItem( "&About",
                                                   new EventHandler( this.HelpAbout_Selection )
                                                 )
                                  );
        this.Menu = myMainMenu;

    }

    public static void Main( string[] args)
    {

        Application.Run( new MenusApp() );
    }
}

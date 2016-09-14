// rádiógombok használata
using System.Windows.Forms;
using System.Drawing;

public class ListBoxApp : Form
{
    private Button btnOK = new Button();

    private Label lblFullName = new Label();
    private Label lblSex      = new Label();

    private TextBox txtFullName = new TextBox();

    private ListBox lboxSex = new ListBox();
    private ListBox lboxAge = new ListBox();


    public ListBoxApp()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
          // fõablak tulajdonságainak beállítása
          this.Text            = "Get User Info";
 //         this.ClientSize      = new Size( 350, 225 );
          this.StartPosition   = FormStartPosition.CenterScreen;
          this.FormBorderStyle = FormBorderStyle.Fixed3D;

          // vezérlõk tulajdonságainak beállítása
          this.lblFullName.Location = new Point( 15, 30 );
          this.lblFullName.AutoSize = true;
          this.lblFullName.Text     = "Name:";

          this.txtFullName.Width = 70;
          this.txtFullName.Location = new Point( 80, 30 );

          this.btnOK.Location = new Point( ( ( this.Width/2 ) - ( this.btnOK.Width/2 ) ),
                                           ( this.Height - 75 )
                                         );
          this.btnOK.Text     = "Done";
          this.btnOK.Click    += new System.EventHandler( this.btnOK_Click );

          this.lblSex.Location = new Point( 20, 70 );
          this.lblSex.Size     = new Size( 100, 20 );
          this.lblSex.Text     = "Sex:";

          this.lboxSex.Location      = new Point( 80, 70 );
          this.lboxSex.Size          = new Size( 100, 20 );
          this.lboxSex.SelectionMode = SelectionMode.One;
          this.lboxSex.Update();
          this.lboxSex.Items.Add( "        " );
          this.lboxSex.Items.Add( "Boy     " );
          this.lboxSex.Items.Add( "Girl    " );
          this.lboxSex.Items.Add( "Man     " );
          this.lboxSex.Items.Add( "Lady    " );
          this.lboxSex.EndUpdate();

          this.lboxAge.Location      = new Point( 80, 100 );
          this.lboxAge.Size          = new Size( 100, 60 );
          this.lboxAge.SelectionMode = SelectionMode.One;
          this.lboxAge.Update();
          this.lboxAge.Items.Add( "        " );
          this.lboxAge.Items.Add( "Under 21" );
          this.lboxAge.Items.Add( "21      " );
          this.lboxAge.Items.Add( "Over 21 " );
          this.lboxAge.EndUpdate();
          this.lboxAge.SelectedIndex = 0;

          // vezérlõk elhelyezése az ablakon
          this.Controls.Add( this.lblFullName );
          this.Controls.Add( this.txtFullName );
          this.Controls.Add( this.lboxSex );
          this.Controls.Add( this.lblSex );
          this.Controls.Add( this.lboxAge );
          this.Controls.Add( this.btnOK );
    }

    protected void btnOK_Click( object sender, System.EventArgs e )
    {
        Application.Exit();
    }

    public static void Main( string[] args)
    {
        Application.Run( new ListBoxApp() );
    }
}

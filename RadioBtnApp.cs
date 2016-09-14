// rádiógombok használata
using System.Windows.Forms;
using System.Drawing;

public class RadioBtnApp : Form
{
    private Button btnOK = new Button();

    private RadioButton rdMale   = new RadioButton();
    private RadioButton rdFemale = new RadioButton();
    private RadioButton rdYouth  = new RadioButton();
    private RadioButton rdAdult  = new RadioButton();

    private Label lblText1 = new Label();
    private Label lblText2 = new Label();

    public RadioBtnApp()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
          // fõablak tulajdonságainak beállítása
          this.Text            = "Radio Buttons";
          this.ClientSize      = new System.Drawing.Size( 350, 225 );
          this.StartPosition   = FormStartPosition.CenterScreen;
          this.FormBorderStyle = FormBorderStyle.Fixed3D;

          // vezérlõk tulajdonságainak beállítása
          this.rdMale.Location = new System.Drawing.Point( 50, 65 );
          this.rdMale.Size     = new Size( 90, 15 );
          this.rdMale.TabIndex = 0;
          this.rdMale.Text     = "Male";

          this.rdFemale.Location = new System.Drawing.Point( 50, 90 );
          this.rdFemale.Size     = new System.Drawing.Size( 90, 15 );
          this.rdFemale.TabIndex = 1;
          this.rdFemale.Text     = "Female";

          this.lblText1.Location = new System.Drawing.Point( 50, 40 );
          this.lblText1.Size     = new System.Drawing.Size( 90, 15 );
          this.lblText1.TabIndex = 2;
          this.lblText1.Text     = "Text";

          this.rdYouth.Location = new System.Drawing.Point( 220, 65 );
          this.rdYouth.Size     = new System.Drawing.Size( 90, 15 );
          this.rdYouth.TabIndex = 3;
          this.rdYouth.Text     = "Under 21";

          this.rdAdult.Location = new System.Drawing.Point( 220, 90 );
          this.rdAdult.Size     = new System.Drawing.Size( 90, 15 );
          this.rdAdult.TabIndex = 4;
          this.rdAdult.Text     = "Over 21";

          this.lblText2.Location = new System.Drawing.Point( 220, 40 );
          this.lblText2.Size     = new System.Drawing.Size( 90, 15 );
          this.lblText2.TabIndex = 5;
          this.lblText2.Text     = "Age Group";

          this.btnOK.Location = new System.Drawing.Point( 130, 160 );
          this.btnOK.Size     = new System.Drawing.Size( 70, 30 );
          this.btnOK.TabIndex = 6;
          this.btnOK.Text     = "OK";
          this.btnOK.Click    += new System.EventHandler( this.btnOK_Click );

          // vezérlõk elhelyezése az ablakon
          this.Controls.Add( this.rdMale );
          this.Controls.Add( this.rdFemale );
          this.Controls.Add( this.rdYouth );
          this.Controls.Add( this.rdAdult );
          this.Controls.Add( this.lblText1 );
          this.Controls.Add( this.lblText2 );
          this.Controls.Add( this.btnOK );
    }

    protected void btnOK_Click( object sender, System.EventArgs e )
    {
        Application.Exit();
    }

    public static void Main( string[] args)
    {
        Application.Run( new RadioBtnApp() );
    }
}

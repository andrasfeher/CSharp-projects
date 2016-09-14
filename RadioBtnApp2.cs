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
    
    private GroupBox gboxAge = new GroupBox();
    private GroupBox gboxSex = new GroupBox();

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
          this.gboxSex.Location = new System.Drawing.Point( 15, 30 );
          this.gboxSex.Size     = new Size( 125, 100 );
          this.gboxSex.TabStop  = false;
          this.gboxSex.Text     = "Sex Group";

          this.rdMale.Location = new System.Drawing.Point( 35, 35 );
          this.rdMale.Size     = new Size( 70, 15 );
          this.rdMale.TabIndex = 0;
          this.rdMale.Text     = "Male";

          this.rdFemale.Location = new System.Drawing.Point( 35, 60 );
          this.rdFemale.Size     = new System.Drawing.Size( 70, 15 );
          this.rdFemale.TabIndex = 1;
          this.rdFemale.Text     = "Female";

          this.gboxAge.Location = new System.Drawing.Point( 200, 30 );
          this.gboxAge.Size     = new Size( 125, 100 );
          this.gboxAge.TabStop  = false;
          this.gboxAge.Text     = "Age Group";

          this.rdYouth.Location = new System.Drawing.Point( 35, 35 );
          this.rdYouth.Size     = new System.Drawing.Size( 70, 15 );
          this.rdYouth.TabIndex = 2;
          this.rdYouth.Text     = "Under 21";

          this.rdAdult.Location = new System.Drawing.Point( 35, 60 );
          this.rdAdult.Size     = new System.Drawing.Size( 70, 15 );
          this.rdAdult.TabIndex = 3;
          this.rdAdult.Text     = "Over 21";


          this.btnOK.Location = new System.Drawing.Point( 130, 160 );
          this.btnOK.Size     = new System.Drawing.Size( 70, 30 );
          this.btnOK.TabIndex = 4;
          this.btnOK.Text     = "OK";
          this.btnOK.Click    += new System.EventHandler( this.btnOK_Click );

          // vezérlõk elhelyezése az ablakon
          this.Controls.Add( this.gboxAge );
          this.Controls.Add( this.gboxSex );
          this.gboxSex.Controls.Add( this.rdMale );
          this.gboxSex.Controls.Add( this.rdFemale );
          this.gboxAge.Controls.Add( this.rdYouth );
          this.gboxAge.Controls.Add( this.rdAdult );
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

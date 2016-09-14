// címke használata
using System;
using System.Windows.Forms;
using System.Drawing;

public class GetName : Form
{
    private Button btnOK = new Button();

    private Label lblFirst          = new Label();
    private Label lblMiddle         = new Label();
    private Label lblLast           = new Label();
    private Label lblFullName       = new Label();
    private Label lblInstructions   = new Label();

    private TextBox txtFirst  = new TextBox();
    private TextBox txtMiddle = new TextBox();
    private TextBox txtLast   = new TextBox();

     public GetName()
     {
          InitializeComponent();
     }

     private void InitializeComponent()
     {
          // fõablak tulajdonságainak beállítása
          this.Text            = "Get User Name";
          this.StartPosition   = FormStartPosition.CenterScreen;
          this.FormBorderStyle = FormBorderStyle.Fixed3D;

          // vezérlõk tulajdonságainak beállítása
          lblFirst.AutoSize = true;
          lblFirst.Text     = "First Name:";
          lblFirst.Location = new Point( 20, 20 );

          lblMiddle.AutoSize = true;
          lblMiddle.Text     = "Middle Name:";
          lblMiddle.Location = new Point( 20, 50 );

          lblLast.AutoSize = true;
          lblLast.Text     = "Last Name:";
          lblLast.Location = new Point( 20, 80 );

          lblFullName.AutoSize = true;
          lblFullName.Location = new Point( 20, 110 );

          txtFirst.Width    = 100;
          txtFirst.Location = new Point( 140, 20 );

          txtMiddle.Width    = 100;
          txtMiddle.Location = new Point( 140, 50 );

          txtLast.Width    = 100;
          txtLast.Location = new Point( 140, 80 );

          lblInstructions.Width     = 250;
          lblInstructions.Height    = 60;
          lblInstructions.Text      = "Here comes the first line of instructions" 
                                      + "\n ... and hear the second";
          lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
          lblInstructions.Location  = new Point( ( ( this.Width/2 ) - ( lblInstructions.Width/2 ) ), 
                                                 140 
                                                );

          btnOK.Text = "Done";
          btnOK.BackColor = Color.LightGray;

          btnOK.Location  = new Point( ( ( this.Width/2 ) - ( btnOK.Width/2 ) ),
                                       ( this.Height - 75 )
                                      );

          // vezérlõk elhelyezése az ablakon
          this.Controls.Add( lblFirst );
          this.Controls.Add( lblMiddle );
          this.Controls.Add( lblLast );
          this.Controls.Add( lblFullName );
          this.Controls.Add( lblInstructions );
          this.Controls.Add( btnOK );
          this.Controls.Add( txtFirst );
          this.Controls.Add( txtMiddle );
          this.Controls.Add( txtLast );


          // eseménykezelõk hozzáadása az alapértelmezett eseménykezelõhöz
          btnOK.Click += new System.EventHandler( this.btnOK_Click );

          txtFirst.TextChanged  += new System.EventHandler( this.txtChanged_Event );
          txtMiddle.TextChanged += new System.EventHandler( this.txtChanged_Event );
          txtLast.TextChanged   += new System.EventHandler( this.txtChanged_Event );
     }

    protected void btnOK_Click( object sender, System.EventArgs e )
    {
        Application.Exit();
    }

    protected void txtChanged_Event( object sender, System.EventArgs e )
    {
        lblFullName.Text = txtFirst.Text + " "
                           + txtMiddle.Text + " "
                           + txtLast.Text;
    }

    public static void Main( string[] args)
    {
        Application.Run( new GetName() );
    }
}

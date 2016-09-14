// címke használata
using System;
using System.Windows.Forms;
using System.Drawing;

public class ButtonApp : Form
{
     private Label myDateLabel = new Label();
     private Button btnUpdate  = new Button();

     public ButtonApp()
     {
          InitializeComponent();
     }

     private void InitializeComponent()
     {
          this.Text = Environment.CommandLine;
          this.StartPosition = FormStartPosition.CenterScreen;
          this.FormBorderStyle = FormBorderStyle.Fixed3D;

          DateTime currDate    = new DateTime();
          currDate             = DateTime.Now;
          myDateLabel.Text     = currDate.ToString();

          myDateLabel.AutoSize  = true;
          myDateLabel.Location  = new Point( 50, 20 );
          myDateLabel.BackColor = this.BackColor;

          // címke elhelyezése az ablakon
          this.Controls.Add( myDateLabel );

          // az ablak szélességének beállítása a címke szélessége alapján
          this.Width = ( myDateLabel.PreferredWidth + 100 );

          btnUpdate.Text      = "Update";
          btnUpdate.BackColor = Color.LightGray;
          btnUpdate.Location  = new Point( ( ( this.Width / 2 )
                                             - ( btnUpdate.Width / 2 )
                                           ),
                                           ( this.Height - 75 )
                                          );
          // gomb elhelyezése az ablakon
          this.Controls.Add( btnUpdate );

          // eseménykezelõk hozzáadása az alapértelmezett eseménykezelõhöz
          btnUpdate.Click += new System.EventHandler( this.btnUpdate_Click );
          btnUpdate.MouseEnter += new System.EventHandler( this.btnUpdate_MouseEnter );
          btnUpdate.MouseLeave += new System.EventHandler( this.btnUpdate_MouseLeave );

          myDateLabel.MouseEnter += new System.EventHandler( this.myDateLabel_MouseEnter );
          myDateLabel.MouseLeave += new System.EventHandler( this.myDateLabel_MouseLeave );

     }

    protected void btnUpdate_Click( object sender, System.EventArgs e )
    {
        DateTime currDate = DateTime.Now;
        this.myDateLabel.Text = currDate.ToString();
    }

    protected void btnUpdate_MouseEnter( object sender, System.EventArgs e )
    {
        this.BackColor = Color.HotPink;
    }

    protected void btnUpdate_MouseLeave( object sender, System.EventArgs e )
    {
        this.BackColor = Color.Blue;
    }

    protected void myDateLabel_MouseEnter( object sender, System.EventArgs e )
    {
        this.BackColor = Color.Yellow;
    }

    protected void myDateLabel_MouseLeave( object sender, System.EventArgs e )
    {
        this.BackColor = Color.Green;
    }


     public static void Main( string[] args)
     {
          Application.Run( new ButtonApp() );
     }
}

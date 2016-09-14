// címke használata
using System;
using System.Windows.Forms;
using System.Drawing;

public class ControlAppB : Form
{
     public ControlAppB()
     {
          InitializeComponent();
     }

     private void InitializeComponent()
     {
          this.Text = Environment.CommandLine;
          this.StartPosition = FormStartPosition.CenterScreen;

          // vezérlõk létrehozása
          Label myDateLabel = new Label();
          Label myLabel     = new Label();

          myLabel.Text     = "This program was executed at:";
          myLabel.AutoSize = true;  // a label hossza pont akkora mint a szöveg
          myLabel.Left     = 50;
          myLabel.Top      = 20;

          DateTime currDate    = DateTime.Now;
          myDateLabel.Text     = currDate.ToString();
          myDateLabel.AutoSize = true;
          myDateLabel.Left     = 50 + myLabel.PreferredWidth + 10;
          myDateLabel.Top      = 20;

          this.Width  = myLabel.PreferredWidth
                          + myDateLabel.PreferredWidth
                          + 110;
          this.Height = myLabel.PreferredHeight + 100;

          // vezérlõk elhelyezése az ablakon
          this.Controls.Add( myDateLabel );
          this.Controls.Add( myLabel );
     }

     public static void Main( string[] args)
     {
          Application.Run( new ControlAppB() );
     }
}

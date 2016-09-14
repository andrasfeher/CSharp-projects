// címke használata
using System;
using System.Windows.Forms;
using System.Drawing;

public class ControlApp : Form
{
     public static void Main( string[] args)
     {
          ControlApp myForm = new ControlApp();
          myForm.Text = Environment.CommandLine;
          myForm.StartPosition = FormStartPosition.CenterScreen;

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

          myForm.Width  = myLabel.PreferredWidth
                          + myDateLabel.PreferredWidth
                          + 110;
          myForm.Height = myLabel.PreferredHeight + 100;

          // vezérlõk elhelyezése az ablakon
          myForm.Controls.Add( myDateLabel );
          myForm.Controls.Add( myLabel );

          Application.Run( myForm );
     }
}

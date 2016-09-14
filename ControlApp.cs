// c�mke haszn�lata
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

          // vez�rl�k l�trehoz�sa
          Label myDateLabel = new Label();
          Label myLabel     = new Label();

          myLabel.Text     = "This program was executed at:";
          myLabel.AutoSize = true;  // a label hossza pont akkora mint a sz�veg
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

          // vez�rl�k elhelyez�se az ablakon
          myForm.Controls.Add( myDateLabel );
          myForm.Controls.Add( myLabel );

          Application.Run( myForm );
     }
}

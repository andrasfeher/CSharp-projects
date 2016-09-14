// c�mke haszn�lata
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

          this.Width  = myLabel.PreferredWidth
                          + myDateLabel.PreferredWidth
                          + 110;
          this.Height = myLabel.PreferredHeight + 100;

          // vez�rl�k elhelyez�se az ablakon
          this.Controls.Add( myDateLabel );
          this.Controls.Add( myLabel );
     }

     public static void Main( string[] args)
     {
          Application.Run( new ControlAppB() );
     }
}

// ablak méretezése

using System.Windows.Forms;
using System.Drawing;

public class FormSize : Form
{
       public static void Main( string[] args)
       {
              FormSize myForm = new FormSize();
              myForm.Text = "Form Sizing";

              myForm.Width = 400;
              myForm.Height= 100;
              myForm.BackColor = Color.HotPink;
/*
              Point FormLoc = new Point( 350, 200 );
              myForm.StartPosition = FormStartPosition.Manual;
              myForm.DesktopLocation = FormLoc;
*/

              myForm.StartPosition = FormStartPosition.CenterScreen;
              Application.Run( myForm );
       }
}

// ablak méretezése

using System.Windows.Forms;
using System.Drawing;

public class PicForm : Form
{
       public static void Main( string[] args)
       {
              PicForm myForm = new PicForm();
              //myForm.Text = "Picture Form";
              myForm.BackColor = Color.HotPink;

              if ( args.Length >= 1 )
              {
                 myForm.BackgroundImage = Image.FromFile( args[0] );
                 Size tmpSize = new Size();
                 tmpSize.Width = myForm.BackgroundImage.Width;
                 tmpSize.Height = myForm.BackgroundImage.Height;
                 myForm.ClientSize = tmpSize;
                 myForm.StartPosition = FormStartPosition.CenterScreen;
                 myForm.FormBorderStyle = FormBorderStyle.None;

                 myForm.MinimizeBox = false;
                 myForm.MaximizeBox = false;
                 myForm.HelpButton  = false;
                 myForm.ControlBox  = false;

                 //myForm.Text = "PicForm - " + args[0];
              }


              //myForm.StartPosition = FormStartPosition.CenterScreen;
              Application.Run( myForm );
       }
}

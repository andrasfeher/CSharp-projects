using System.Windows.Forms;

public class FormApp : Form
{
       public static void Main( string[] args)
       {
              FormApp frmHello = new FormApp();
              frmHello.MinimizeBox = false;
              frmHello.MaximizeBox = false;
              frmHello.HelpButton  = false;
              frmHello.ControlBox  = false;
              //frmHello.Text  = @"form caption";
              Application.Run( frmHello );
       }
}

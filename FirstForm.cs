using System.Windows.Forms;

public class FirstFrm : Form
{
       public static void Main( string[] args)
       {
              FirstFrm frmHello = new FirstFrm();
              frmHello.SizeGripStyle = SizeGripStyle.Show;
              Application.Run( frmHello );
       }
}

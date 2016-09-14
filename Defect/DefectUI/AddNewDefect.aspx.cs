using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DefectUI.DefectService1;

namespace DefectUI
{
    public partial class AddNewDefect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void DefectButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void DefectButtonAdd_Click(object sender, EventArgs e)
        {
            Defect defect = new Defect();
            defect.Title = DefectTitle.Text;
            defect.Description = DefectDescription.Text;
            // defect.AttachedFile = DefectFile.FileBytes;

            using (Service1 dSercive = new Service1())
            {
                dSercive.AddDefect(defect);
            }

            // Session
            Response.Redirect("Default.aspx");
        }
    }
}

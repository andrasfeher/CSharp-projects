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
    public partial class ConfirmDefectState : System.Web.UI.Page
    {
        public Defect CurrDef
        {
            get { return (Defect)this.Session["CurrDef"]; }
            set { this.Session["CurrDef"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Context.PreviousHandler is _Default)
                CurrDef = ((_Default)this.Context.PreviousHandler).CurrentDefect;
        }

        protected void btResolved_Click(object sender, EventArgs e)
        {
            if (CurrDef != null)
            {
                using (Service1 dSercive = new Service1())
                {
                    dSercive.SetDefectState(CurrDef, DefectState.Resolved);
                }
            }
            Response.Redirect("Default.aspx");
        }

        protected void btRejected_Click(object sender, EventArgs e)
        {
            if (CurrDef != null)
            {
                using (Service1 dSercive = new Service1())
                {
                    dSercive.SetDefectState(CurrDef, DefectState.Rejected);
                }
            }
            Response.Redirect("Default.aspx");
        }
    }
}

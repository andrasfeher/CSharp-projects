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
using System.Collections.Generic;


namespace DefectUI
{
    public partial class _Default : System.Web.UI.Page
    {

        Defect _currentDefect;

        public Defect CurrentDefect
        {
            get { return _currentDefect; }
            set { _currentDefect = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //_currentDefect = null;
            }
            btAddNewDefect.Visible = ((bool)this.Session["tesztelő"]);
            btKivetel.Visible = ((bool)this.Session["fejlesztő"]);
            btMegoldas.Visible = ((bool)this.Session["fejlesztő"]);
            btLezaras.Visible = ((bool)this.Session["tesztelő"]);
        }

        protected void btAddNewDefect_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewDefect.aspx");
        }

        protected void btKivetel_Click(object sender, EventArgs e)
        {
            if (DeftectsGridView.SelectedRow != null)
            {
                if (GetSelectedDefect(DeftectsGridView.SelectedValue).State == DefectState.Opened)
                {
                    using (Service1 dSercive = new Service1())
                    {
                        dSercive.SetDefectState(GetSelectedDefect(DeftectsGridView.SelectedValue), DefectState.UnderDevelopement);
                        Response.Redirect("Default.aspx");
                    }
                }
            }
        }

        protected void btMegoldas_Click(object sender, EventArgs e)
        {
            if (DeftectsGridView.SelectedRow != null)
            {
                if (GetSelectedDefect(DeftectsGridView.SelectedValue).State == DefectState.UnderDevelopement)
                {
                    CurrentDefect = GetSelectedDefect(DeftectsGridView.SelectedValue);
                    Server.Transfer("ConfirmDefectState.aspx");
                }
            }
        }

        protected void btLezaras_Click(object sender, EventArgs e)
        {
            if (DeftectsGridView.SelectedRow != null)
            {
                if (GetSelectedDefect(DeftectsGridView.SelectedValue).State == DefectState.Resolved ||
                    GetSelectedDefect(DeftectsGridView.SelectedValue).State == DefectState.Rejected)
                {
                    using (Service1 dSercive = new Service1())
                    {
                        dSercive.SetDefectState(GetSelectedDefect(DeftectsGridView.SelectedValue), DefectState.Closed);
                        Response.Redirect("Default.aspx");
                    }
                }
            }
        }

        private Defect GetSelectedDefect(object id)
        {
            if (id is int)
            {
                List<Defect> defects = (List<Defect>)this.Session["List"];
                return defects.Find(delegate(Defect d)
                {
                    return d.Id == (int)id;
                });
            }
            else
            {
                return null;
            }
        }
    }
}

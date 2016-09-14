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
using WebApplication1.localhost;
using System.Web.Services;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using ( localhost.Service1 svc = new WebApplication1.localhost.Service1()) {
                lblResult.Text = Convert.ToString(svc.Szumma(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)));

                
                Invoice2 i = (Invoice2)svc.GetInvoice(6);

                i.Deadline = DateTime.Now;

                svc.AddItem(i, new InvoiceItem());

                lblInvoiceNo.Text = Convert.ToString(i.Number);
                svc.StoreInvoice(i);

            }
  
        }
    }
}

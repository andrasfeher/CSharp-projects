using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace WebService1
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Szumma(int a, int b)
        {
            return a+b;
        }

        [WebMethod]
        public void StoreInvoice(Invoice i)
        {
        }

        [WebMethod]
        public Invoice GetInvoice(int n)
        {
            Invoice i = new Invoice(5);
            InvoiceItem b = new InvoiceItem();

            return i;
        }

        [WebMethod]
        public Invoice AddItem(Invoice parent, InvoiceItem item)
        {
            try
            {
                parent.Items.Add(item);
                item.Container = parent;
            }
            catch
            {
                throw new SoapException();
            }


            return parent;
        }
    }
}

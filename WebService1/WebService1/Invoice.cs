using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace WebService1
{
    [XmlInclude(typeof(Invoice2))]
    public class Invoice
    {
        int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public Invoice()
        {
        }

        public Invoice(int n)
        {
            Number = n;
        }

        List<InvoiceItem> _items = new List<InvoiceItem>();

        public virtual List<InvoiceItem> Items
        {
          get { return _items; }
          set { _items = value; }
        }

    }
}

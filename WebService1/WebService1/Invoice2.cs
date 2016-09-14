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
    public class Invoice2 : Invoice
    {

        private DateTime _deadline;

        public DateTime Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }
/*
        public List<InvoiceItem> Items
        {
            get { return _items; }
            set 
            { 
                if ( DateTime.Now.CompareTo(Deadline) > 0 )
                    throw new Exception( "DeadlinePassed");

                _items = value; 
             }
        }
*/
        public override List<InvoiceItem> Items
        {
            get
            {
                return base.Items;
            }
            set
            {
                if ( DateTime.Now.CompareTo(Deadline) > 0 )
                    throw new Exception( "DeadlinePassed");

                base.Items = value;
            }
        }
    }
}

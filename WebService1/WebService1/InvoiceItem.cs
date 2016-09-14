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
using System.Xml.Serialization;

namespace WebService1
{
    public class InvoiceItem
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _amount;

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }


        Invoice _container;

        [XmlIgnore]
        public Invoice Container
        {
            get { return _container; }
            set { _container = value; }
        }

        [XmlAttribute("InvoiceId")]
        public int ContainerId
        {
            get
            {
                if (_container != null)
                    return _container.Number;
                else
                    return -1;
            }
            set
            {
            }
        }


 
    }
}

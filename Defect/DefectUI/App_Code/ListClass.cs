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
using DefectUI.DefectService1;

namespace DefectUI
{
    public class ListClass
    {
        public class DefectComparer: IComparer<Defect> {

            string _column;

            public string Column
            {
                get { return _column; }
                set { _column = value; }
            }

            #region IComparer<Defect> Members

            public int Compare(Defect x, Defect y)
            {
                switch (_column)
                {
                    case "Title":
                        return x.Title.CompareTo(y.Title);
                        break;
                    case "CreatedBy":
                        return x.CreatedBy.CompareTo(y.CreatedBy);
                        break;
                    case "State":
                        return x.State.CompareTo(y.State);
                        break;
                    default:
                        return x.Id.CompareTo(y.Id);
                        break;
                }
            }

            #endregion
        }

        public List<Defect> ListDefects(string Column)
        {
            using (Service1 tDef = new Service1())
            {
                List<Defect> result = new List<Defect>(tDef.GetDefects());

                string[] col = Column.Split(new char[] {' '}, 2);
                DefectComparer DefCom = new DefectComparer();
                DefCom.Column = col[0];
                result.Sort(DefCom);
                if (col.Length > 1)
                    result.Reverse();
                HttpContext.Current.Session["List"] = result;
                return result;
            }
        }

        public List<Defect> GetDefect(int id)
        {
            using (Service1 tDef = new Service1())
            {
                List<Defect> def = new List<Defect>();
                Defect result = tDef.GetDefect(id);
                if(result != null) def.Add(result);
                return def;
            }
        }
    }
}

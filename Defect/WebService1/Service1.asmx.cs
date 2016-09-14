using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading;
using System.Web.Configuration;
using System.Xml;

namespace WebService1
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://defects.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        string[] _roles;

        public string[] Roles
        {
          get { return _roles; }
          set { _roles = value; }
        }

        public Service1()
        {
            try
            {
                IIdentity current = HttpContext.Current == null ? Thread.CurrentPrincipal.Identity : HttpContext.Current.User.Identity;
                string name = current.Name;
                if (string.IsNullOrEmpty(name))
                {
                    throw new SoapException("Name is null or empty!", new XmlQualifiedName("MySoapException"));
                }
                string role = WebConfigurationManager.AppSettings[name];
                if (string.IsNullOrEmpty(role))
                {
                    throw new SoapException("Role is null or empty!", new XmlQualifiedName("MySoapException"));
                }
                Roles = role.Split(',');
                GenericPrincipal p = new GenericPrincipal(current, role.Split(','));
                Thread.CurrentPrincipal = p;
            }
            catch (Exception ex)
            {
                throw new SoapException(ex.ToString(), new XmlQualifiedName("MySoapException"));
            }
        }

        [WebMethod]
        public string[] GetRoles()
        {
            try
            {
                return Roles;
            }
            catch (Exception ex)
            {
                throw new SoapException(ex.ToString(), new XmlQualifiedName("MySoapException"));
            }
        }

        [WebMethod]
        public Defect GetDefect(int Id)
        {
            try
            {
                DefectBusinessLogic.BusinessLogic bl = new DefectBusinessLogic.BusinessLogic();
                return bl.GetDefect(Id);
            }
            catch (Exception ex)
            {
                throw new SoapException(ex.ToString(), new XmlQualifiedName("MySoapException"));
            }
        }

        [WebMethod]
        public Defect AddDefect(Defect item)
        {
            try
            {
                DefectBusinessLogic.BusinessLogic bl = new DefectBusinessLogic.BusinessLogic();
                return bl.AddDefect(item);
            }
            catch (Exception ex)
            {
                throw new SoapException(ex.ToString(), new XmlQualifiedName("MySoapException"));
            }
        }

        [WebMethod]
        public List<Defect> GetDefects()
        {
            try
            {
                DefectBusinessLogic.BusinessLogic bl = new DefectBusinessLogic.BusinessLogic();
                return bl.GetDefects();
            }
            catch (Exception ex)
            {
                throw new SoapException(ex.ToString(), new XmlQualifiedName("MySoapException"));
            }
        }

        [WebMethod]
        public Defect SetDefectState(Defect item, DefectState newState)
        {
            try
            {
                DefectBusinessLogic.BusinessLogic bl = new DefectBusinessLogic.BusinessLogic();
                return bl.SetDefectState(item, newState);
            }
            catch (Exception ex)
            {
                throw new SoapException(ex.ToString(), new XmlQualifiedName("MySoapException"));
            }
        }
    }
}

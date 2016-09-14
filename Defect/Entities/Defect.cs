using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.Threading;

namespace WebService1
{
    [XmlInclude(typeof(DefectState))]
    public class Defect
    {
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        string _createdBy;
        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        DefectState _state;
        public DefectState State
        {
            get { return _state; }
            set { _state = value; }
        }

        DateTime? _createdDate;
        public DateTime? CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        string _assignedTo;
        public string AssignedTo
        {
            get { return _assignedTo; }
            set { _assignedTo = value; }
        }

        DateTime? _assignedDate;
        public DateTime? AssignedDate
        {
            get { return _assignedDate; }
            set { _assignedDate = value; }
        }

        DateTime? _closedDate;
        public DateTime? ClosedDate
        {
            get { return _closedDate; }
            set { _closedDate = value; }
        }

        private byte[] _attachedFile;

        public byte[] AttachedFile
        {
            get { return _attachedFile; }
            set { _attachedFile = value; }
        }


        public Defect()
        {
        }

        private bool IsNewStateAndRoleCompatible(DefectState newState )
        {
            bool result = false;

            switch (newState)
            {
                case DefectState.Opened:
                case DefectState.Closed: if (Thread.CurrentPrincipal.IsInRole("tesztelő"))
                                result = true;
                             break;
                case DefectState.UnderDevelopement:
                case DefectState.Resolved:
                case DefectState.Rejected: if (Thread.CurrentPrincipal.IsInRole("fejlesztő"))
                                 result = true;
                               break;
                default:
                    result = false;
                    break;
            }

            return result;
        }


        private bool IsOldStateAndNewStateCompatible(DefectState newState)
        {
            bool result = false;

            switch (State)
            {
                case DefectState.Opened: if (newState == DefectState.UnderDevelopement)
                                result = true;
                             break;
                case DefectState.UnderDevelopement: if ( newState == DefectState.Resolved 
                                                         || newState == DefectState.Rejected
                                                       )
                                 result = true;
                             break;
                case DefectState.Resolved:
                case DefectState.Rejected: if (newState == DefectState.Closed)
                                 result = true;
                             break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        public void SetState(DefectState newState)
        {
            if ( IsNewStateAndRoleCompatible(newState) )
            {
                if (IsOldStateAndNewStateCompatible(newState))
                {
                    State = newState;
                }
                else
                {
                    throw new ApplicationException("Invalid state change!");
                }
            }
            else
            {
                throw new ApplicationException("The new state and the user role are incompatible!");
            }
        }
    }

    public enum DefectState
    {
        Opened, UnderDevelopement, Resolved, Rejected, Closed
    }


}

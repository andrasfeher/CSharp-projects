using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebService1;
using System.Threading;
using DataAccess;
using System.Diagnostics;

namespace DefectBusinessLogic
{
    public class BusinessLogic
    {
        public Defect AddDefect( Defect defectItem )
        {
            Connection conn = new Connection();

            defectItem.CreatedBy = Thread.CurrentPrincipal.Identity.Name;
            defectItem.CreatedDate = DateTime.Now;

            conn.Insert(defectItem);

            return defectItem;

        }

        public List<Defect> GetDefects()
        {
            List<Defect> tempResult = new List<Defect>();
           
            Connection conn = new Connection();

            if (Thread.CurrentPrincipal.IsInRole("tesztelő"))
                tempResult.AddRange(conn.GetCreatedDefects(Thread.CurrentPrincipal.Identity.Name));

            if (Thread.CurrentPrincipal.IsInRole("fejlesztő"))
                tempResult.AddRange(conn.GetAssignedDefects());

            return RemoveDuplicatedItems(tempResult);
        }

        private List<Defect> RemoveDuplicatedItems(List<Defect> tempResult)
        {
       
            List<Defect> result = new List<Defect>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (Defect def in tempResult)
            {
                if (!dict.ContainsKey(def.Id))
                {
                    dict.Add(def.Id, 0);
                    result.Add(def);
                }
            }

            return result;
        }

        public Defect SetDefectState(Defect item, DefectState newState)
        {
            Connection conn = new Connection();

            item = conn.GetDefect(item.Id);
            item.SetState(newState);

            switch (newState)
            {
                case DefectState.Opened: 
                    item.CreatedDate=DateTime.Now;
                    break;
                case DefectState.UnderDevelopement:
                    item.AssignedTo=Thread.CurrentPrincipal.Identity.Name;
                    item.AssignedDate=DateTime.Now;
                    break;
                case DefectState.Closed:
                    item.ClosedDate = DateTime.Now;
                    break;
            }

            conn.Update(item);           

            return item;
        }

        public Defect GetDefect(int id)
        {
            Connection conn = new Connection();

            return conn.GetDefect(id);
        }

    }
}

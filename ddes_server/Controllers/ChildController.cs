using DDES_Server.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDES_Server.Controllers
{
    public static class ChildController
    {
        private static List<Child> ChildrenDB { get; set; } = new();

        private static int NextID = 1;

        public static Child Add(int ParentID, string FirstName, string LastName)
        {
            Child child = new(NextID, ParentID, FirstName, LastName);
            ChildrenDB.Add(child);
            NextID++;
            return child;
        }

        public static Child? Update(int ID, int? ParentID = null, string? FirstName = null, string? LastName = null)
        {
            Child? child = ChildrenDB.Find(x => x.ID.Equals(ID));

            if (child == null) return null;

            if (ParentID != null)
            {
                child.ParentID = (int) ParentID;
            }

            if (FirstName != null)
            {
                child.FirstName = (string) FirstName;
            }

            if (LastName != null)
            {
                child.LastName = (string) LastName;
            }

            return child;
        }

        public static Child? FindByID(int ID)
        {
            Child? child = ChildrenDB.Find(x => x.ID.Equals(ID));
            if (child != null) return child;

            return null;
        }

        public static List<Child> FindByParent(int ID)
        {
            List<Child> results = new();
            foreach (Child child in ChildrenDB)
            {
                if(child.ParentID == ID)
                results.Add(child);
            }
            return results;
        }
    }
}

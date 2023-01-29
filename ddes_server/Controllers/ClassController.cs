using DDES_Server.Interfaces;
using DDES_Server.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DDES_Server.Controllers
{
    public static class ClassController
    {
        private static List<Class> ClassesDB { get; set; } = new();

        private static int NextID = 1;

        public static Class Add(string Name, Teacher Teacher, List<Child> Children)
        {
            Class ddes_class = new(NextID, Name, Teacher, Children);
            ClassesDB.Add(ddes_class);
            NextID++;
            return ddes_class;
        }

        public static Class? Update(int ID, string? Name = null, Teacher? Teacher = null, List<Child>? Children = null)
        {
            Class? ddes_class = ClassesDB.Find(x => x.ID.Equals(ID));

            if (ddes_class == null) return null;

            if (Name != null)
            {
                ddes_class.Name = (string) Name;
            }

            if (Teacher != null)
            {
                ddes_class.Teacher = (Teacher)Teacher;
            }

            if (Children != null)
            {
                ddes_class.Children = (List<Child>)Children;
            }

            return ddes_class;
        }

        public static Class? FindByID(int ID)
        {
            Class? ddes_class = ClassesDB.Find(x => x.ID.Equals(ID));
            if (ddes_class != null) return ddes_class;

            return null;
        }

        public static List<Class> GetAll()
        {
            return ClassesDB;
        }

        public static List<Parent>? GetParents(int ID)
        {
            Class? ddes_class = ClassController.FindByID(ID);
            if (ddes_class == null || ddes_class.Children == null) return null;

            List<Parent> parents = new();

            foreach(Child child in ddes_class.Children)
            {
                int ParentID = child.ParentID;
                Parent? parent = ParentController.FindByID(ParentID);
                if (parent == null) continue;
                parents.Add(parent);
            }
            if (parents.Count < 1) return null;
            return parents;
        }

        public static void AddChild(int ID, Child child)
        {
            Class? ddes_class = ClassController.FindByID(ID);
            if (ddes_class == null) throw new KeyNotFoundException();

            ClassController.AddChild(ddes_class, child);
        }

        public static void AddChild(Class ddes_class, Child child)
        {
            ddes_class.Children ??= new List<Child>();
            ddes_class.Children.Add(child);
            ClassController.Update(ddes_class.ID, null, null, ddes_class.Children);
        }

        public static void RemoveChild(int ID, Child child)
        {
            Class? ddes_class = ClassController.FindByID(ID);
            if (ddes_class == null) throw new KeyNotFoundException();

            ClassController.RemoveChild(ddes_class, child);
        }

        public static void RemoveChild(Class ddes_class, Child child)
        {
            if (ddes_class.Children == null) throw new KeyNotFoundException();

            ddes_class.Children.Remove(child);
            ClassController.Update(ddes_class.ID, null, null, ddes_class.Children);
        }

        public static Teacher GetTeacher(int ID)
        {
            Class? ddes_class = ClassController.FindByID(ID);
            if (ddes_class == null) throw new KeyNotFoundException();
            return ddes_class.Teacher;
        }

        public static void ChangeTeacher(int ID, Teacher Teacher)
        {
            Class? ddes_class = ClassController.FindByID(ID);
            if (ddes_class == null) throw new KeyNotFoundException();
            ClassController.ChangeTeacher(ddes_class, Teacher);
        }

        public static void ChangeTeacher(Class ddes_class, Teacher Teacher)
        {
            ClassController.Update(ddes_class.ID, null, Teacher);
        }
    }
}

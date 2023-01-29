using DDES_Server.Controllers;
using DDES_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDES_Server
{
    public static class SampleData
    {
        public static void CreateData()
        {
            Parent parent1 = ParentController.Add("Bradley", "Shaw", "brad", "1234");
            ChildController.Add(parent1.ID, "Roger", "Smith");

            Child child1 = ChildController.Add(parent1.ID, "Adam", "Shaw");
            ChildController.Update(child1.ID, null, "Adrian");

            ParentController.Add("Bob", "Booth", "boothy", "bobby951");
            ParentController.Add("Timothy", "Andrews", "tandrews", "tandy470");

            Teacher teacher1 = TeacherController.Add("Simon", "Tutorium", "bigbrainsi", "sithe120");

            List<Child> children1 = new();
            children1.Add(child1);
            ClassController.Add("Class1", teacher1, children1);
        }
    }
}

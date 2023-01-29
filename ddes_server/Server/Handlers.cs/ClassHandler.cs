using DDES_Server.Controllers;
using DDES_Server.Interfaces;
using DDES_Server.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DDES_Server.Server.Handlers.cs
{
    public class ClassHandler : IRequestHandler
    {
        public string Process(JObject Context)
        {
            // Return output from a function by the action it wants to run
            switch((string) Context["Action"]) {
                case "GetAll":
                    return this.GetAll(Context);
                case "Add":
                    return this.Add(Context);
                case "AddChild":
                    return this.AddChild(Context);
                default:
                    // If no matching action found, return generic response
                    return "{\"response\":\"Action Not Found\"}";
            }
        }

        private string GetAll(JObject Context)
        {
            // Runs the GetAll function of the class controller, returns JSON object as string
            return JsonConvert.SerializeObject(ClassController.GetAll(), Formatting.Indented);
        }

        private string Add(JObject Context)
        {
            try
            {
                // Attempts to find the child from its
                JArray childrenIDs = (JArray) Context["data"]["childrenIDs"];
                List<Child> children = new();

                foreach (int childID in childrenIDs)
                {
                    Child? child = ChildController.FindByID(childID);
                    if (child != null)
                    {
                        children.Add(child);
                    }
                   
                }

                Teacher? teacher = TeacherController.FindByID((int)Context["data"]["parentID"]);

                if (teacher == null) return "{\"response\":\"Add Class Failed, invalid Teacher\"}";

                // Calls the command in the class controller to add the child
                ClassController.Add((string) Context["data"]["ClassName"], teacher, children);
                return "{\"response\":\"Successful\"}";
            }
            catch
            {
                // If errors are thrown, respond with generic response
                return "{\"response\":\"Add Child Failed\"}";
            }
        }

        private string AddChild(JObject Context)
        {
            try
            {
                // Attempts to find the child from its id
                Child? child = ChildController.FindByID((int)Context["data"]["childID"]);
                if (child == null)
                {
                    return "{\"response\":\"Child Not Found\"}";
                }
                // Calls the command in the class controller to add the child
                ClassController.AddChild((int)Context["data"]["ClassID"], child);
                return "{\"response\":\"Successful\"}";
            }
            catch
            {
                // If errors are thrown, respond with generic response
                return "{\"response\":\"Add Child Failed\"}";
            }
        }
    }
}

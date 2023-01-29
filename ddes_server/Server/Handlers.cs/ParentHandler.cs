using DDES_Server.Controllers;
using DDES_Server.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDES_Server.Server.Handlers.cs
{
    public class ParentHandler : IRequestHandler
    {
        public string Process(JObject Context)
        {
            switch ((string)Context["Action"])
            {
                case "Login":
                    return this.Login(Context);
                default:
                    // If no matching action found, return generic response
                    return "{\"response\":\"Action Not Found\"}";
            }
        }

        private string Login(JObject Context)
        {
            return JsonConvert.SerializeObject(ParentController.Login((string)Context["data"]["UserName"], (string)Context["data"]["Password"]), Formatting.Indented);
        }
    }
}

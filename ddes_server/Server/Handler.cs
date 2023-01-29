using DDES_Server.Interfaces;
using DDES_Server.Server.Handlers.cs;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DDES_Server.Server
{
    // Front Controller
    public static class Handler
    {
        private static Dictionary<string, IRequestHandler> handlers = new();
        public static void Initialise()
        {
            // Add ClassHandler
            handlers.Add("Class", new ClassHandler());
            handlers.Add("Parent", new ParentHandler());
        }

        // Process Request
        public static string Process(JObject jsonRequest)
        {
            // Instantiate request object
            Request request = new((string)jsonRequest["module"], (JObject)jsonRequest["context"]);

            // Attempt to find suitable Front Command (called XXXXXHandler here)
            handlers.TryGetValue(request.Module, out IRequestHandler? module_handler);

            // Throw error if not found
            if(module_handler == null) throw new KeyNotFoundException(request.Module);

            // Return output of that front commands process function
            return module_handler.Process(request.Context);
        }
    }
}

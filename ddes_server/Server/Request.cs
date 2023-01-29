using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DDES_Server.Server
{
    public class Request : IRequest
    {
        public string Module { get; set; }
        public JObject Context { get; set; }

        public Request(string module, JObject context)
        {
            this.Module = module;
            this.Context = context;
        }
    }
}

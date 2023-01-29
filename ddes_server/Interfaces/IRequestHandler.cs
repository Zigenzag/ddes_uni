using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DDES_Server.Interfaces
{
    public interface IRequestHandler
    {
        public string Process(JObject Context);
    }
}

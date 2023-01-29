using DDES_Server.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DDES_Server.Models
{
    public class Child : ISerialisable
    {
        public int ID { get; set; }

        public int ParentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Child(int ID, int ParentID, string FirstName, string LastName )
        {
            this.ID = ID;
            this.ParentID = ParentID;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

using DDES_Server.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDES_Server.Models
{
    public class Class
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Teacher Teacher { get; set; }

        public List<Child>? Children { get; set; } = new();

        public Class(int ID, string Name, Teacher Teacher, List<Child>? Children = null)
        {
            this.ID = ID;
            this.Name = Name;
            this.Teacher = Teacher;
            if (Children != null)
            {
                this.Children = Children;
            }
        }
    }
}

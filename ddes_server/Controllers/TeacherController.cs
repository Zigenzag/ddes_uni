using DDES_Server.Interfaces;
using DDES_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDES_Server.Controllers
{
    public class TeacherController
    {
        private static List<Teacher> TeachersDB { get; set; } = new();

        private static int NextID = 1;

        public static Teacher Add(Teacher teacher)
        {
            TeachersDB.Add(teacher);
            return teacher;
        }

        public static Teacher Add(string FirstName, string LastName, string UserName, string Password)
        {
            Teacher teacher = new(NextID, FirstName, LastName, UserName, Password);
            TeachersDB.Add(teacher);
            NextID++;
            return teacher;
        }

        public static Teacher? FindByID(int ID)
        {
            Teacher? teacher = TeachersDB.Find(x => x.ID.Equals(ID));
            if (teacher != null) return teacher;

            return null;
        }

        public static Teacher? FindByUserName(string UserName)
        {
            Teacher? teacher = TeachersDB.Find(x => x.UserName.Equals(UserName));
            if (teacher != null) return teacher;

            return null;
        }

        public static List<Teacher> GetAll()
        {
            return TeachersDB;
        }

        public static string Login(string username, string password)
        {
            Teacher? teacher = FindByUserName(username);
            if (teacher == null) return "";

            return teacher.VerifyLogin(username, password);
        }
    }
}

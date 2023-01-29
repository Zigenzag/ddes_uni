using DDES_Server.Interfaces;
using DDES_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DDES_Server.Controllers
{
    public static class ParentController
    {
        private static List<Parent> ParentsDB { get; set; } = new();

        private static int NextID = 1;

        public static Parent Add(string FirstName, string LastName, string UserName, string Password)
        {
            Parent parent = new(NextID, FirstName, LastName, UserName, Password);
            ParentsDB.Add(parent);
            NextID++;
            return parent;
        }

        public static Parent? Update(int ID, string? FirstName = null, string? LastName = null, string? UserName = null, string? Password = null)
        {
            Parent? parent = ParentsDB.Find(x => x.ID.Equals(ID));

            if (parent == null) return null;

            if (FirstName != null)
            {
                parent.FirstName = (string)FirstName;
            }

            if (LastName != null)
            {
                parent.LastName = (string)LastName;
            }

            if (UserName != null)
            {
                parent.UserName = (string)UserName;
            }
            
            if (Password != null)
            {
                parent.Password = (string)Password;
            }

            return parent;
        }

        public static Parent? FindByID(int ID)
        {
            Parent? parent = ParentsDB.Find(x => x.ID.Equals(ID));
            if (parent != null) return parent;

            return null;
        }

        public static Parent? FindByUserName(string UserName)
        {
            Parent? parent = ParentsDB.Find(x => x.UserName.Equals(UserName));
            if (parent != null) return parent;

            return null;
        }

        public static List<Parent> GetAll() { 
            return ParentsDB;
        }

        public static string Login(string username, string password)
        {
            Parent? parent = FindByUserName(username);
            if (parent == null) return "";

            return parent.VerifyLogin(username, password);
        }
    }
}

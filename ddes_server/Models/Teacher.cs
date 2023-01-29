using DDES_Server.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DDES_Server.Models
{
    public class Teacher : IUser
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }

        public Teacher(int ID, string FirstName, string LastName, string UserName, string Password)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserName = UserName;
            this.Password = Password;

            string TokenCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            this.Token = new string(
               Enumerable.Repeat(TokenCharacters, 8)
               .Select(token => token[new Random().Next(token.Length)]).ToArray());
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public string VerifyLogin(string username, string password)
        {
            if (username == this.UserName && password == this.Password) return this.Token;
            return "";
        }
    }
}

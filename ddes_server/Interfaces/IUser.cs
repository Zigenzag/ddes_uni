using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDES_Server.Interfaces
{
    public interface IUser
    {
        string FirstName { get; }
        string LastName { get; }

        string UserName { get; }

        string Token { get; }

        string VerifyLogin(string username, string password);
    }
}

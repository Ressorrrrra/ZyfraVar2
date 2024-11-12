using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2.Services.Interfaces
{
    public interface IAuthenticationService
    {
        public UserData? LogIn(string login, string password);

    }
}

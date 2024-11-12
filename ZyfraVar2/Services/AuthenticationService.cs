using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyfraVar2.Repository.Interfaces;
using ZyfraVar2.Services.Interfaces;
using ZyfraVar2.Repository;

namespace ZyfraVar2.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IUserRepository repository;
        
        public AuthenticationService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public UserData? LogIn(string login, string password)
        {
            return repository.LogIn(login, password);
        }

    }
}

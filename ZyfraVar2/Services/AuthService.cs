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
    public class AuthService : IAuthService
    {
        private IUserRepository repository;
        
        public AuthService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public UserData? LogIn(string login, string password)
        {
            return repository.LogIn(login, password);
        }

    }
}

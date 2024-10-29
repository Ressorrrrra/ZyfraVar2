using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyfraVar2.Repository.Interfaces;
using ZyfraVar2.Services.Interfaces;

namespace ZyfraVar2.Services
{
    public class SessionService : ISessionService
    {
        IUserRepository repository;
        public SessionService(IUserRepository repository)
        {
            this.repository = repository;
        }
        public string CreateSession(string login)
        {
           return repository.CreateSession(login);
        }

        public bool DeleteSession(string sessionId)
        {
            return repository.DeleteSession(sessionId);
        }
    }
}

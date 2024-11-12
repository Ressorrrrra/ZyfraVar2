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
        private ISessionRepository sessionRepository;
        public SessionService(ISessionRepository repository)
        {
            this.sessionRepository = repository;
        }

        public bool CheckSession(string sessionId)
        {
            return sessionRepository.CheckSession(sessionId);
        }

        public string CreateSession(string login)
        {
           return sessionRepository.CreateSession(login);
        }

        public bool DeleteSession(string sessionId)
        {
            return sessionRepository.DeleteSession(sessionId);
        }
    }
}

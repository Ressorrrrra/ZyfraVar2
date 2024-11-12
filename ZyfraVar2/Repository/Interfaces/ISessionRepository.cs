using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2.Repository.Interfaces
{
    public interface ISessionRepository
    {
        public string CreateSession(string login);

        public bool DeleteSession(string sessionId);
        public bool CheckSession(string sessionId);
    }
}

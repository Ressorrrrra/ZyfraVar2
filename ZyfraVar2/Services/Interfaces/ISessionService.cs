using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyfraVar2.Repository.Interfaces;

namespace ZyfraVar2.Services.Interfaces
{
    public interface ISessionService
    {
        public string CreateSession(string login);

        public bool DeleteSession(string sessionId);

        public bool CheckSession(string sessionId);

    }
}

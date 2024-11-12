using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyfraVar2.Repository.Interfaces;

namespace ZyfraVar2.Repository
{
    public class SessionRepository : ISessionRepository
    {
        private Dictionary<string, Session> sessions = new Dictionary<string, Session>();

        public string CreateSession(string login)
        {
            var session = new Session(login);
            sessions[session.SessionId.ToString()] = session;
            return session.SessionId.ToString();
        }

        public bool DeleteSession(string sessionId)
        {
            if (sessions.Remove(sessionId))
            {
                return true;
            }
            else
                return false;

        }

        public bool CheckSession(string sessionId)
        {
            if (sessions.TryGetValue(sessionId, out var session) && sessions[sessionId].IsActive == true)
            {
                return true;
            }
            return false;
        }
    }
}

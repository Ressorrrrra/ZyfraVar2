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
        private readonly SessionsContext db;

        public SessionRepository(SessionsContext context)
        {
            db = context;
        }

        public string CreateSession(string login)
        {
            var session = new Session { Owner = login, Id = Guid.NewGuid(), IsActive = true };
            db.Sessions.Add(session);
            db.SaveChanges();
            return session.Id.ToString();
        }

        public bool DeleteSession(Guid sessionId)
        {
            var session = db.Sessions.FirstOrDefault(s => s.Id == sessionId && s.IsActive);
            if (session != default(Session))
            {
                session.IsActive = false;
                db.Update(session);
                db.SaveChanges();
                return true;
            }
            else
                return false;

        }

        public bool CheckSession(Guid sessionId)
        {
            var session = db.Sessions.FirstOrDefault(s => s.Id == sessionId && s.IsActive);
            if (session != default(Session))
            {
                return true;
            }
            else
                return false;
        }

    }
}

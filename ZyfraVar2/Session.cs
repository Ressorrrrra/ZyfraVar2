using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2
{
    public class Session
    {
        public Guid SessionId;
        public string Owner;
        public bool IsActive;

        public Session(string username)
        {
            SessionId = Guid.NewGuid();
            Owner = username;
            IsActive = true;
        }
    }
}

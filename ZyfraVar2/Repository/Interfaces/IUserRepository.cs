using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2.Repository.Interfaces
{
    public interface IUserRepository
    {
        public UserData? FindUser(string login, string password);

        public UserData? FindUser(string sessionId);

        public List<UserData> LoadData(string filePath);

        public string CreateSession(string login);

        public bool DeleteSession(string sessionId);

    }
}

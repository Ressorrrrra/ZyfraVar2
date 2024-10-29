using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyfraVar2.Repository.Interfaces;

namespace ZyfraVar2.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<UserData> userData;

        public UserRepository(string filePath) 
        {
            userData = LoadData(filePath);
        }

        public UserData? FindUser(string login, string password)
        {
            return userData.Find(i => i.Login.Equals(login) && i.Password.Equals(password));
        }
        public UserData? FindUser(string sessionId)
        {
            return userData.Find(i => i.SessionId != null && i.SessionId.Equals(sessionId));
        }


        public List<UserData> LoadData(string filePath)
        {
            List<UserData> userData = new List<UserData>();
            using (var reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var values = line.Split(';');
                    userData.Add(new UserData(values[0], values[1]));
                }
            }

            return userData;
        }

        public string CreateSession(string login)
        {
            Random rand = new Random();
            UserData? user = userData.Find(i => i.Login.Equals(login));
            string sessionId = "";
            for (int i = 0; i < 8; i++)
            {
                sessionId = sessionId.Insert(sessionId.Length, rand.Next(0, 10).ToString());
            }
            user.SessionId = sessionId;
            return sessionId;
        }

        public bool DeleteSession(string sessionId)
        {
            UserData? user = FindUser(sessionId);
            if (user != null)
            {
                user.SessionId = null;
                return true;
            }
            else
                return false;
                
        }
    }
}

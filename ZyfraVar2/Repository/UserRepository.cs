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
        private Dictionary<string, UserData> userData;

        public UserRepository(string filePath) 
        {
            userData = LoadData(filePath).ToDictionary(x => x.Login, x => x);
        }

        public UserData? LogIn(string login, string password)
        {
            if (userData.TryGetValue(login, out var user) && user.Password != password) { user = null; }
            return user;
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


    }
}

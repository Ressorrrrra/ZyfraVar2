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
        private readonly SessionsContext db;

        public UserRepository(SessionsContext context) 
        {
            db = context;
        }

        public User? LogIn(string login, string password)
        {

            var user = db.Users.FirstOrDefault(u => (u.Login == login && u.Password == password));
            return user == default(User) ? null : user;
        }


    }
}

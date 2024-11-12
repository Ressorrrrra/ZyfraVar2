using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2.Repository.Interfaces
{
    public interface IUserRepository
    {
        public UserData? LogIn(string login, string password);


        public List<UserData> LoadData(string filePath);


    }
}

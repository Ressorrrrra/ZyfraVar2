﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2.Services.Interfaces
{
    public interface IAuthService
    {
        public UserData? LogIn(string login, string password);

    }
}
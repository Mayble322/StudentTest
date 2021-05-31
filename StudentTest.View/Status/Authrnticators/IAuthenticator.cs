﻿using StudentTest.Domain.Entities;
using StudentTest.Domain.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.View.Status.Authrnticators
{
    public interface IAuthenticator
    {
        Account CurrentAccount { get; }
        bool IsLoggedIn { get; }

        event Action StateChanged;

        Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword, string userRole);

        Task Login(string username, string password);

        Task LoginAsAdmin(string username, string password);

        void Logout();
    }
}

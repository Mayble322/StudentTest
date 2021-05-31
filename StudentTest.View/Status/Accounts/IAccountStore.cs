using StudentTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.View.Status.Accounts
{
    public interface IAccountStore
    {
        Account CurrentAccount { get; set; }
        event Action StateChanged;
    }
}

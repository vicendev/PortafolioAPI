using MongoDB.Driver;
using Org.Sdt.Users.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Org.Sdt.Users.ContextMongoDb
{
    public interface IUserContext
    {
        IMongoCollection<User> Users { get; }
    }
}

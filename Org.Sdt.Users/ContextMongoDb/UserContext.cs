using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Org.Sdt.Architecture.Core;
using Org.Sdt.Users.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Org.Sdt.Users.ContextMongoDb
{
    public class UserContext : IUserContext
    {
        private IMongoDatabase _db;

        public UserContext(IOptions<MongoSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<User> Users => _db.GetCollection<User>("User");
    }
}

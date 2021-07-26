using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Org.Sdt.Architecture.Core;
using Org.Sdt.Projects.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Org.Sdt.Projects.ContextMongoDb
{
    public class ProjectContext : IProjectContext
    {
        private IMongoDatabase _db;

        public ProjectContext(IOptions<MongoSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<Project> Projects => _db.GetCollection<Project>("Project");
    }
}
